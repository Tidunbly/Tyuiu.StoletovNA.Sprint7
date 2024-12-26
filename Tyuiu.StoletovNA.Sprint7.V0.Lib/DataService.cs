using System.Data;
using System.Runtime.CompilerServices;

namespace Tyuiu.StoletovNA.Sprint7.V0.Lib {
    public class DataService {

        public DataTable DataTableMaker(string path)
        {
            DataTable table = new DataTable();

            try
            {
                string[] lines = File.ReadAllLines(path);

                if (lines.Length > 0)
                {
                    string[] headers = lines[0].Split(',');

                    foreach (string header in headers)
                    {
                        table.Columns.Add(header.Trim());
                    }

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] row = lines[i].Split(',');

                        if (row[4].Trim() == "Да")
                        {
                            table.Rows.Add(row.Select(value => value.Trim()).ToArray());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении/конвертировании файла.", ex);
            }

            return table;


        }
    }
}
