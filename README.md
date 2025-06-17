# WinForms CSV to JSON Converter

This is a Windows Forms application built with C# (.NET Framework 4.7.2) that converts CSV files into JSON format. It features file selection dialogs, CSV validation, malformed line detection, recent file history, and optional export of invalid lines. Built using a modular class-library approach.

![Screenshot](https://github.com/facebookegypt/winform-csv2json/raw/main/screenshot.png)

## 🚀 Features

- 📂 **Browse & select CSV files**
- 📝 **Choose and save output JSON path**
- ✅ **Validate CSV structure (columns count)**
- ⚠️ **Detect & display malformed rows**
- 💾 **Optionally export malformed rows to `.txt`**
- 📜 **Recent file list with auto-fill**
- 🧩 **Built using class libraries for separation of logic**
- 🎯 **Handles malformed fields like extra commas inside cells**

## 📁 Project Structure

- `winform-csv2json/` – WinForms GUI Application
- `CsvToJsonLib/` – Contains the logic for CSV ➜ JSON
- `Check-CSV/` – Validates CSV and extracts malformed rows

## 🛠️ How to Use

1. Launch the app.
2. Click `Open` to choose a CSV file.
3. Click the `...` button to choose the output `.json` file location.
4. After validation, you will be prompted to export malformed rows if found.
5. Click `OK` to convert and save.
6. View malformed rows in the grid if applicable.
7. Use the `Recent` menu to quickly re-load previously used files.

## 🖼️ Screenshot

![Screenshot](https://github.com/facebookegypt/winform-csv2json/raw/main/screenshot.png)

## 🧪 Requirements

- ✅ Windows OS
- ✅ Visual Studio 2017 or later
- ✅ [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
- ✅ [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) NuGet Package

## 🧠 Skills Demonstrated

- WinForms UI/UX Design
- Working with Files and Dialogs
- LINQ, File I/O
- CSV Parsing and Validation
- JSON Serialization
- User Prompting and Messaging
- GitHub Project Setup & Maintenance

## 📄 License

Licensed under the [MIT License](LICENSE).

## 🙋 Author

Ahmed Samir AKA evry1falls — [GitHub/facebookegypt](https://github.com/facebookegypt)(https://adonetaccess2003.blogspot.com)  
Need help or have questions? Open an issue on the repo!

---

## 🧪 Future Plans (TODO)

- Add drag-and-drop CSV support
- Add automatic detection of delimiters (comma, tab, semicolon)
- Implement command-line mode
- Add logging and analytics (optional)
