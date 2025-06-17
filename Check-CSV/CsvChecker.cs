using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Check_CSV
{
    public static class CsvChecker
    {
        public static (bool isValid, List<(int lineNumber, string lineText)> malformedLines) CheckCsv(string path, int expectedColumns = 0)
        {
            var malformed = new List<(int, string)>();
            var lines = File.ReadAllLines(path);
            int maxColumns = expectedColumns;

            for (int i = 0; i < lines.Length; i++)
            {
                var cols = lines[i].Split(',');

                if (expectedColumns == 0 && i == 0)
                    maxColumns = cols.Length;

                if (cols.Length != maxColumns)
                    malformed.Add((i + 1, lines[i]));
            }

            return (malformed.Count == 0, malformed);
        }
    }
    public static class MalformedExporter
    {
        public static void Export(
            List<(int lineNumber, string lineContent)> malformedLines,
            string csvFilePath,
            string jsonFilePath)
        {
            if (malformedLines == null || malformedLines.Count == 0)
                return;

            var confirm = MessageBox.Show(
                $"Detected {malformedLines.Count} malformed line(s).\n" +
                "Do you want to export them to a .txt file?",
                "Export Malformed Lines",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                string csvName = Path.GetFileNameWithoutExtension(csvFilePath);
                string directory = Path.GetDirectoryName(jsonFilePath);
                string malformedPath = Path.Combine(directory, $"malformed_{csvName}.txt");

                if (File.Exists(malformedPath))
                {
                    var overwrite = MessageBox.Show(
                        $"File '{Path.GetFileName(malformedPath)}' already exists.\nOverwrite?",
                        "Confirm Overwrite",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);

                    if (overwrite != DialogResult.OK)
                        return;
                }

                using (var writer = new StreamWriter(malformedPath, false))
                {
                    foreach (var (lineNumber, line) in malformedLines)
                    {
                        writer.WriteLine($"Line {lineNumber}: {line}");
                    }
                }

                MessageBox.Show("Malformed lines saved successfully.",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving malformed lines:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
