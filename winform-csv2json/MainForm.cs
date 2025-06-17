using System;
using System.IO;
using System.Windows.Forms;
using Check_CSV;
using System.Collections.Specialized;  // Required
using System.Collections.Generic;
// This is the code for your desktop app by Ahmed Samir.

namespace winform_csv2json
{
    public partial class MainForm : Form
    {
        private const int maxRecentFiles = 5;
        //Keydown event was not working before.
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowMalformedLines(List<(int LineNumber, string LineText)> malformedLines)
        {
            malformedListBox.Items.Clear();

            if (malformedLines == null || malformedLines.Count == 0)
            {
                malformedListBox.Items.Add("No malformed lines found.");
                return;
            }

            foreach (var (lineNumber, lineText) in malformedLines)
            {
                malformedListBox.Items.Add($"Line {lineNumber}: {lineText}");
            }
        }
        private void UpdateRecentMenu()
        {
            recentToolStripMenuItem.DropDownItems.Clear();

            var recent = Properties.Settings.Default.RecentFiles;
            if (recent == null) return;

            foreach (string file in recent)
            {
                var item = new ToolStripMenuItem(Path.GetFileName(file)) { Tag = file };
                recentToolStripMenuItem.DropDownItems.Add(item);
                PopulateRecentFilesMenu();
            }
        }
        private void AddToRecent(string path)
        {
            var recent = Properties.Settings.Default.RecentFiles;
            if (recent.Contains("rece&nt")) return;
            if (recent.Contains(path)) recent.Remove(path);
            recent.Insert(0, path);

            while (recent.Count > maxRecentFiles)
                recent.RemoveAt(recent.Count - 1);

            Properties.Settings.Default.Save();
            UpdateRecentMenu();
        }

        private void Mainform_load(object sender, EventArgs e)
        {
            KeyPreview = true;
            csvlocTextBox.ReadOnly = true;
            malformedListBox.Dock = DockStyle.Fill;
            //RecentFiles
            if (Properties.Settings.Default.RecentFiles == null)
                Properties.Settings.Default.RecentFiles = new StringCollection();
            UpdateRecentMenu();
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                ofd.Title = "Select CSV File";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    csvlocTextBox.Text = ofd.FileName;

                    // ✅ Use Check-CSV class library
                    var (isValid, malformedLines) = CsvChecker.CheckCsv(ofd.FileName);
                    if (!isValid)
                    {
                        string msg = $"⚠ Found {malformedLines.Count} malformed line(s).\n" +
                                     $"Example: Line {malformedLines[0].lineNumber} → {malformedLines[0].lineText}\n\n" +
                                     "Do you want to continue and skip these lines?";

                        var choice = MessageBox.Show(msg, "CSV Format Warning",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (choice == DialogResult.No)
                        {
                            MessageBox.Show("Operation aborted by user.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        // Optional: Save malformed lines to a log file
                        // File.WriteAllLines("malformed_lines.log", malformedLines.Select(l => $"Line {l.lineNumber}: {l.lineText}"));
                    }
                    ShowMalformedLines(malformedLines);
                    savejsonTextBox.Text = Path.ChangeExtension(ofd.FileName, ".json");
                    // Trigger optional export with confirmation
                    MalformedExporter.Export(malformedLines, ofd.FileName , savejsonTextBox.Text);
                    MessageBox.Show("CSV file loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            string csvPath = csvlocTextBox.Text;
            string jsonPath = savejsonTextBox.Text;

            try
            {
                // Validate source file
                if (!File.Exists(csvPath))
                {
                    MessageBox.Show("CSV file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ensure the directory exists
                string jsonDir = Path.GetDirectoryName(jsonPath);
                if (!Directory.Exists(jsonDir))
                {
                    Directory.CreateDirectory(jsonDir); // Create the directory if it doesn't exist
                }

                // Convert CSV to JSON
                string json = CsvToJsonConverter.ConvertCsvToJson(csvPath);

                // Save JSON with safe file access
                using (var writer = new StreamWriter(new FileStream(jsonPath, FileMode.Create, FileAccess.Write, FileShare.None)))
                {
                    writer.Write(json);
                }

                MessageBox.Show("Conversion successful!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddToRecent(csvlocTextBox.Text);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Access denied to the file or directory.\n" + ex.Message, "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show("File I/O error:\n" + ex.Message, "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Choose a destination folder for the 'converted json file
        private void jsonLocbtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Save JSON File As";
                saveDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveDialog.DefaultExt = "json";
                saveDialog.AddExtension = true;
                saveDialog.FileName = "converted.json"; // default filename

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    savejsonTextBox.Text = saveDialog.FileName;
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openBtn_Click(sender,e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PopulateRecentFilesMenu()
        {
            recentToolStripMenuItem.DropDownItems.Clear();

            var recentFiles = Properties.Settings.Default.RecentFiles;

            if (recentFiles == null || recentFiles.Count == 0)
            {
                recentToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("No recent files") { Enabled = false });
                return;
            }

            foreach (var file in recentFiles)
            {
                var item = new ToolStripMenuItem(file);
                item.Click += (s, e) => OpenRecentFile(file);
                recentToolStripMenuItem.DropDownItems.Add(item);
            }
        }
        private void OpenRecentFile(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("File not found: " + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            csvlocTextBox.Text = path;
            // Check if the CSV is valid
            var (isValid, malformedLines) = CsvChecker.CheckCsv(path);
            savejsonTextBox.Text = Path.ChangeExtension(path , ".json");

            // Trigger optional export with confirmation
            MalformedExporter.Export(malformedLines, path, savejsonTextBox.Text);
            if (!isValid)
            {
                MessageBox.Show("This file has malformed lines. Please check before proceeding.", "Malformed CSV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // You can also populate a UI control (like a ListBox) here to show the errors.
                ShowMalformedLines(malformedLines);
            }
            // You can add auto-fill savejsonTextBox if you want:
            string defaultJsonPath = Path.ChangeExtension(path, ".json");
            savejsonTextBox.Text = defaultJsonPath;
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savejsonTextBox.Clear();
            csvlocTextBox.Clear();
            malformedListBox.Items.Clear();
        }
    }
}
