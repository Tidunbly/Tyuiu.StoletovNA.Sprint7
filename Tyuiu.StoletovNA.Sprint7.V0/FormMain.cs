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

        // ������ <�������>
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {

            /// �� ��� �������
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
                MessageBox.Show("������ ��� ������/��������������� �����.");
            }
            textBoxFilePath_SNA.Text = openFilePath;


            /// �� ��� ����������
            int TotalDebt = 0;
            int MinDebt = int.MaxValue;
            int MaxDebt = 0;
            int DebtorCount = 0;
            foreach (DataRow row in table.Rows)
            {

                string hasDebt = row["�������������"].ToString();
                int debtAmount = Convert.ToInt32(row["����� �������������"]);


                if (hasDebt == "��")
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


            /// �� ��� ������
            ChartArea chartArea = new ChartArea("MainArea");
            chartPie_SNA.ChartAreas.Clear();
            chartPie_SNA.ChartAreas.Add(chartArea);
            chartPie_SNA.Series.Clear();


            Series series = new Series("������������� �� ���������")
            {
                ChartType = SeriesChartType.Pie,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            int totalDebt = 0;
            foreach (DataRow row in table.Rows)
            {
                string hasDebt = row["�������������"].ToString();
                if (hasDebt == "��")
                {
                    totalDebt += Convert.ToInt32(row["����� �������������"]);
                }
            }

            foreach (DataRow row in table.Rows)
            {
                string apartmentNumber = row["����� ��������"].ToString();
                int debtAmount = Convert.ToInt32(row["����� �������������"]);
                string hasDebt = row["�������������"].ToString();

                if (hasDebt == "��")
                {
                    double debtPercentage = (double)debtAmount / totalDebt * 100;
                    series.Points.AddXY(apartmentNumber, debtAmount);
                    series.Points[series.Points.Count - 1].Label = $"{apartmentNumber}: {debtPercentage:F2}%";
                }
            }

            chartPie_SNA.Series.Add(series);
            chartPie_SNA.ChartAreas["MainArea"].AxisX.Title = "����� ��������";
            chartPie_SNA.ChartAreas["MainArea"].AxisY.Title = "����� �������������";
            chartPie_SNA.Titles.Clear();
            chartPie_SNA.Titles.Add("������������� ������������� �� ���������");


        }
        // ������ <������ ���� �����������>
        private void buttonFormatData_SNA_Click(object sender, EventArgs e)
        {
            buttonFormatData_SNA.Enabled = false;

            table = ds.DataTableMaker(openFilePath);
            dataGridViewFile_SNA.DataSource = table;
            ChangeTextColorForSixthColumn();


        }

        // ������ <���������>
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

        // ������ <� ���������>
        private void buttonInfo_SNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�����������: �������� ������ ��������� | ���� | ����-24-2", "� ���������", MessageBoxButtons.OK);
        }

        // ������ <�����������>
        private void buttonManual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������: \n������� - ���������� ���� ������ ����� \n������ ���� ����������� - ������� �� ������� ��� ������ ��� ����������� \n��������� - ���������� ���� ���������� ����� \n\n���������� ������ ������ ��� �������� - .CSV (����� ������ ������� ������)", "�����������", MessageBoxButtons.OK);
        }

        
        private void dataGridViewFile_SNA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            var changedCell = dataGridViewFile_SNA.Rows[e.RowIndex].Cells[e.ColumnIndex];

        }

        // ������ ���� ������ ������ ���� ���� > 2000
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
