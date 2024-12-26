using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.StoletovNA.Sprint7.V0.Lib;
using static System.Windows.Forms.LinkLabel;
namespace Tyuiu.StoletovNA.Sprint7.V0 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private DataTable table;
        public string openFilePath;

        // Кнопка <Открыть>
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {

            /// Всё про таблицу
            openFileDialog_SNA.ShowDialog();
            openFilePath = openFileDialog_SNA.FileName;

            table = new DataTable();
            try
            {

                string[] lines = File.ReadAllLines(openFilePath);

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
                        table.Rows.Add(row.Select(value => value.Trim()).ToArray());
                    }
                    dataGridViewFile_SNA.DataSource = table;
                    dataGridViewFile_SNA.ScrollBars = ScrollBars.Both;

                    buttonFormatData_SNA.Enabled = true;
                    ChangeTextColorForSixthColumn();




                }
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении/конвертировании файла.");
            }
            textBoxFilePath_SNA.Text = openFilePath;


            /// Всё про статистику
            int TotalDebt = 0;
            int MinDebt = int.MaxValue;
            int MaxDebt = 0;
            int DebtorCount = 0;
            foreach (DataRow row in table.Rows)
            {

                string hasDebt = row["Задолженность"].ToString();
                int debtAmount = Convert.ToInt32(row["Сумма задолженности"]);


                if (hasDebt == "Да")
                {

                    TotalDebt += debtAmount;
                    MinDebt = Math.Min(MinDebt, debtAmount);
                    MaxDebt = Math.Max(MaxDebt, debtAmount);
                    DebtorCount++;
                }

            }
            textBoxDebtWhole_SNA.Text = TotalDebt.ToString();
            textBoxDebtor_SNA.Text = DebtorCount.ToString();
            textBoxDebtMin_SNA.Text = MinDebt.ToString();
            textBoxDebtMax_SNA.Text = MaxDebt.ToString();


            /// Всё про график
            ChartArea chartArea = new ChartArea("MainArea");
            chartPie_SNA.ChartAreas.Clear();
            chartPie_SNA.ChartAreas.Add(chartArea);
            chartPie_SNA.Series.Clear();


            Series series = new Series("Задолженности по квартирам")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            int totalDebt = 0;
            foreach (DataRow row in table.Rows)
            {
                string hasDebt = row["Задолженность"].ToString();
                if (hasDebt == "Да")
                {
                    totalDebt += Convert.ToInt32(row["Сумма задолженности"]);
                }
            }

            foreach (DataRow row in table.Rows)
            {
                string apartmentNumber = row["Номер квартиры"].ToString();
                int debtAmount = Convert.ToInt32(row["Сумма задолженности"]);
                string hasDebt = row["Задолженность"].ToString();

                if (hasDebt == "Да")
                {
                    double debtPercentage = (double)debtAmount / totalDebt * 100;
                    series.Points.AddXY(apartmentNumber, debtAmount);
                    series.Points[series.Points.Count - 1].Label = $"{apartmentNumber}: {debtPercentage:F2}%";
                }
            }

            chartPie_SNA.Series.Add(series);
            chartPie_SNA.ChartAreas["MainArea"].AxisX.Title = "Номер квартиры";
            chartPie_SNA.ChartAreas["MainArea"].AxisY.Title = "Сумма задолженности";
            chartPie_SNA.Titles.Clear();
            chartPie_SNA.Titles.Add("Распределение задолженности по квартирам");


        }
        // Кнопка <Убрать всех недолжников>
        private void buttonFormatData_SNA_Click(object sender, EventArgs e)
        {
            buttonFormatData_SNA.Enabled = false;

            table = ds.DataTableMaker(openFilePath);
            dataGridViewFile_SNA.DataSource = table;
            ChangeTextColorForSixthColumn();


        }

        // Кнопка <Сохранить>
        private void buttonSaveEditedFile_SNA_Click(object sender, EventArgs e)
        {
            

            saveFileDialog_SNA.FileName = "DomUprProTest_Edited.csv";
            saveFileDialog_SNA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SNA.ShowDialog();
            
            string filepath = saveFileDialog_SNA.FileName;
            using (StreamWriter writer = new StreamWriter(filepath))
            {

                var columnNames = table.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                writer.WriteLine(string.Join(",", columnNames));

                foreach (DataRow row in table.Rows)
                {
                    var fields = row.ItemArray.Select(field => field.ToString().Replace(",", " "));
                    writer.WriteLine(string.Join(",", fields));
                }

            }
        }

        // Кнопка <О программе>
        private void buttonInfo_SNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Столетов Никита Андреевич | ВШЦТ | ИИПб-24-2", "О программе", MessageBoxButtons.OK);
        }

        // Кнопка <Руководство>
        private void buttonManual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопки: \nОткрыть - Показывает окно выбора файла \nУбрать всех недолжников - Убирает из таблицы все строки без задолжности \nСохранить - Показывает окно сохранения файла \n\nДопустимый формат файлов для открытия - .CSV (любые другие вызовут ошибку)", "Руководство", MessageBoxButtons.OK);
        }

        
        private void dataGridViewFile_SNA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            var changedCell = dataGridViewFile_SNA.Rows[e.RowIndex].Cells[e.ColumnIndex];

        }

        // Меняет цвет текста ячейки если долг > 2000
        private void ChangeTextColorForSixthColumn()
        {
            foreach (DataGridViewRow row in dataGridViewFile_SNA.Rows)
            {
                if (!row.IsNewRow)
                {
                    int cellValue;
                    if (int.TryParse(row.Cells[5].Value?.ToString(), out cellValue))
                    {
                        if (cellValue > 2000)
                        {
                            row.Cells[5].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            row.Cells[5].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }


    }
}
