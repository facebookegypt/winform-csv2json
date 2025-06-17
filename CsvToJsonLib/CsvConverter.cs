using System.Data;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

public static class CsvToJsonConverter
{
    public static string ConvertCsvToJson(string csvPath)
    {
        DataTable dt = new DataTable();

        using (TextFieldParser parser = new TextFieldParser(csvPath))
        {
            parser.SetDelimiters(new string[] { "," });
            parser.HasFieldsEnclosedInQuotes = true;

            string[] headers = parser.ReadFields();
            foreach (var header in headers)
                dt.Columns.Add(header);

            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();

                // Ensure it doesn’t exceed column count
                if (fields.Length > dt.Columns.Count)
                    fields = fields.Take(dt.Columns.Count).ToArray();
                dt.Rows.Add(fields);
            }
        }
        return JsonConvert.SerializeObject(dt, Formatting.Indented);
    }
}