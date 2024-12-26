namespace Tyuiu.StoletovNA.Sprint7.V0
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialog_SNA = new OpenFileDialog();
            buttonOpenFile_SNA = new Button();
            dataGridViewFile_SNA = new DataGridView();
            textBoxFilePath_SNA = new TextBox();
            textBoxFilePathNamer_SNA = new TextBox();
            textBoxDebtWholeNamer_SNA = new TextBox();
            textBoxDebtWhole_SNA = new TextBox();
            textBoxDebtor_SNA = new TextBox();
            textBoxDebtMin_SNA = new TextBox();
            textBoxDebtMax_SNA = new TextBox();
            textBoxDebtorNamer_SNA = new TextBox();
            textBoxDebtMinNamer_SNA = new TextBox();
            textBoxDebtMaxNamer_SNA = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chartPie_SNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonFormatData_SNA = new Button();
            saveFileDialog_SNA = new SaveFileDialog();
            buttonSaveEditedFile_SNA = new Button();
            buttonInfo_SNA = new Button();
            buttonManual_SNA = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile_SNA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie_SNA).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog_SNA
            // 
            openFileDialog_SNA.FileName = "openFileDialog_SNA";
            // 
            // buttonOpenFile_SNA
            // 
            buttonOpenFile_SNA.BackColor = Color.FromArgb(192, 255, 255);
            buttonOpenFile_SNA.Location = new Point(12, 12);
            buttonOpenFile_SNA.Name = "buttonOpenFile_SNA";
            buttonOpenFile_SNA.Size = new Size(77, 70);
            buttonOpenFile_SNA.TabIndex = 0;
            buttonOpenFile_SNA.Text = "Открыть";
            buttonOpenFile_SNA.UseVisualStyleBackColor = false;
            buttonOpenFile_SNA.Click += buttonOpenFile_Click;
            // 
            // dataGridViewFile_SNA
            // 
            dataGridViewFile_SNA.AllowUserToOrderColumns = true;
            dataGridViewFile_SNA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataGridViewFile_SNA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFile_SNA.GridColor = SystemColors.Menu;
            dataGridViewFile_SNA.Location = new Point(551, 12);
            dataGridViewFile_SNA.Name = "dataGridViewFile_SNA";
            dataGridViewFile_SNA.RowHeadersVisible = false;
            dataGridViewFile_SNA.Size = new Size(649, 389);
            dataGridViewFile_SNA.TabIndex = 1;
            // 
            // textBoxFilePath_SNA
            // 
            textBoxFilePath_SNA.Location = new Point(95, 41);
            textBoxFilePath_SNA.Name = "textBoxFilePath_SNA";
            textBoxFilePath_SNA.ReadOnly = true;
            textBoxFilePath_SNA.Size = new Size(374, 23);
            textBoxFilePath_SNA.TabIndex = 2;
            // 
            // textBoxFilePathNamer_SNA
            // 
            textBoxFilePathNamer_SNA.Location = new Point(95, 12);
            textBoxFilePathNamer_SNA.Name = "textBoxFilePathNamer_SNA";
            textBoxFilePathNamer_SNA.ReadOnly = true;
            textBoxFilePathNamer_SNA.Size = new Size(100, 23);
            textBoxFilePathNamer_SNA.TabIndex = 3;
            textBoxFilePathNamer_SNA.Text = "Путь";
            // 
            // textBoxDebtWholeNamer_SNA
            // 
            textBoxDebtWholeNamer_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtWholeNamer_SNA.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            textBoxDebtWholeNamer_SNA.Location = new Point(580, 407);
            textBoxDebtWholeNamer_SNA.Name = "textBoxDebtWholeNamer_SNA";
            textBoxDebtWholeNamer_SNA.ReadOnly = true;
            textBoxDebtWholeNamer_SNA.Size = new Size(122, 21);
            textBoxDebtWholeNamer_SNA.TabIndex = 4;
            textBoxDebtWholeNamer_SNA.Text = "Общая задолжность";
            // 
            // textBoxDebtWhole_SNA
            // 
            textBoxDebtWhole_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtWhole_SNA.BackColor = Color.FromArgb(255, 192, 192);
            textBoxDebtWhole_SNA.Location = new Point(718, 407);
            textBoxDebtWhole_SNA.Name = "textBoxDebtWhole_SNA";
            textBoxDebtWhole_SNA.ReadOnly = true;
            textBoxDebtWhole_SNA.Size = new Size(100, 23);
            textBoxDebtWhole_SNA.TabIndex = 5;
            // 
            // textBoxDebtor_SNA
            // 
            textBoxDebtor_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtor_SNA.BackColor = Color.FromArgb(255, 192, 192);
            textBoxDebtor_SNA.Location = new Point(718, 436);
            textBoxDebtor_SNA.Name = "textBoxDebtor_SNA";
            textBoxDebtor_SNA.ReadOnly = true;
            textBoxDebtor_SNA.Size = new Size(100, 23);
            textBoxDebtor_SNA.TabIndex = 6;
            // 
            // textBoxDebtMin_SNA
            // 
            textBoxDebtMin_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtMin_SNA.BackColor = Color.FromArgb(255, 192, 192);
            textBoxDebtMin_SNA.Location = new Point(718, 465);
            textBoxDebtMin_SNA.Name = "textBoxDebtMin_SNA";
            textBoxDebtMin_SNA.ReadOnly = true;
            textBoxDebtMin_SNA.Size = new Size(100, 23);
            textBoxDebtMin_SNA.TabIndex = 7;
            // 
            // textBoxDebtMax_SNA
            // 
            textBoxDebtMax_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtMax_SNA.BackColor = Color.FromArgb(255, 192, 192);
            textBoxDebtMax_SNA.Location = new Point(718, 494);
            textBoxDebtMax_SNA.Name = "textBoxDebtMax_SNA";
            textBoxDebtMax_SNA.ReadOnly = true;
            textBoxDebtMax_SNA.Size = new Size(100, 23);
            textBoxDebtMax_SNA.TabIndex = 8;
            // 
            // textBoxDebtorNamer_SNA
            // 
            textBoxDebtorNamer_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtorNamer_SNA.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxDebtorNamer_SNA.Location = new Point(580, 436);
            textBoxDebtorNamer_SNA.Name = "textBoxDebtorNamer_SNA";
            textBoxDebtorNamer_SNA.ReadOnly = true;
            textBoxDebtorNamer_SNA.Size = new Size(122, 21);
            textBoxDebtorNamer_SNA.TabIndex = 9;
            textBoxDebtorNamer_SNA.Text = "Кол-во должников";
            // 
            // textBoxDebtMinNamer_SNA
            // 
            textBoxDebtMinNamer_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtMinNamer_SNA.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            textBoxDebtMinNamer_SNA.Location = new Point(580, 465);
            textBoxDebtMinNamer_SNA.Name = "textBoxDebtMinNamer_SNA";
            textBoxDebtMinNamer_SNA.ReadOnly = true;
            textBoxDebtMinNamer_SNA.Size = new Size(122, 21);
            textBoxDebtMinNamer_SNA.TabIndex = 10;
            textBoxDebtMinNamer_SNA.Text = "Min задолжность";
            // 
            // textBoxDebtMaxNamer_SNA
            // 
            textBoxDebtMaxNamer_SNA.Anchor = AnchorStyles.Right;
            textBoxDebtMaxNamer_SNA.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            textBoxDebtMaxNamer_SNA.Location = new Point(580, 494);
            textBoxDebtMaxNamer_SNA.Name = "textBoxDebtMaxNamer_SNA";
            textBoxDebtMaxNamer_SNA.ReadOnly = true;
            textBoxDebtMaxNamer_SNA.Size = new Size(122, 21);
            textBoxDebtMaxNamer_SNA.TabIndex = 11;
            textBoxDebtMaxNamer_SNA.Text = "Max задолжность";
            // 
            // chartPie_SNA
            // 
            chartPie_SNA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chartPie_SNA.BackColor = Color.Silver;
            chartArea1.Name = "ChartArea1";
            chartPie_SNA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartPie_SNA.Legends.Add(legend1);
            chartPie_SNA.Location = new Point(25, 198);
            chartPie_SNA.Name = "chartPie_SNA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPie_SNA.Series.Add(series1);
            chartPie_SNA.Size = new Size(449, 433);
            chartPie_SNA.TabIndex = 12;
            // 
            // buttonFormatData_SNA
            // 
            buttonFormatData_SNA.BackColor = Color.FromArgb(255, 192, 192);
            buttonFormatData_SNA.Font = new Font("Days Sans Black", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFormatData_SNA.Location = new Point(12, 88);
            buttonFormatData_SNA.Name = "buttonFormatData_SNA";
            buttonFormatData_SNA.Size = new Size(240, 66);
            buttonFormatData_SNA.TabIndex = 13;
            buttonFormatData_SNA.Text = "Убрать всех недолжников";
            buttonFormatData_SNA.UseVisualStyleBackColor = false;
            buttonFormatData_SNA.Click += buttonFormatData_SNA_Click;
            // 
            // buttonSaveEditedFile_SNA
            // 
            buttonSaveEditedFile_SNA.BackColor = Color.FromArgb(192, 255, 192);
            buttonSaveEditedFile_SNA.Location = new Point(258, 88);
            buttonSaveEditedFile_SNA.Name = "buttonSaveEditedFile_SNA";
            buttonSaveEditedFile_SNA.Size = new Size(90, 66);
            buttonSaveEditedFile_SNA.TabIndex = 14;
            buttonSaveEditedFile_SNA.Text = "Сохранить";
            buttonSaveEditedFile_SNA.UseVisualStyleBackColor = false;
            buttonSaveEditedFile_SNA.Click += buttonSaveEditedFile_SNA_Click;
            // 
            // buttonInfo_SNA
            // 
            buttonInfo_SNA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo_SNA.BackColor = SystemColors.ActiveCaption;
            buttonInfo_SNA.Location = new Point(1090, 608);
            buttonInfo_SNA.Name = "buttonInfo_SNA";
            buttonInfo_SNA.Size = new Size(154, 23);
            buttonInfo_SNA.TabIndex = 15;
            buttonInfo_SNA.Text = "О программе";
            buttonInfo_SNA.UseVisualStyleBackColor = false;
            buttonInfo_SNA.Click += buttonInfo_SNA_Click;
            // 
            // buttonManual_SNA
            // 
            buttonManual_SNA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonManual_SNA.BackColor = Color.FromArgb(255, 255, 128);
            buttonManual_SNA.Location = new Point(1090, 637);
            buttonManual_SNA.Name = "buttonManual_SNA";
            buttonManual_SNA.Size = new Size(154, 23);
            buttonManual_SNA.TabIndex = 16;
            buttonManual_SNA.Text = "Руководство";
            buttonManual_SNA.UseVisualStyleBackColor = false;
            buttonManual_SNA.Click += buttonManual_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 668);
            Controls.Add(buttonManual_SNA);
            Controls.Add(buttonInfo_SNA);
            Controls.Add(buttonSaveEditedFile_SNA);
            Controls.Add(buttonFormatData_SNA);
            Controls.Add(chartPie_SNA);
            Controls.Add(textBoxDebtMaxNamer_SNA);
            Controls.Add(textBoxDebtMinNamer_SNA);
            Controls.Add(textBoxDebtorNamer_SNA);
            Controls.Add(textBoxDebtMax_SNA);
            Controls.Add(textBoxDebtMin_SNA);
            Controls.Add(textBoxDebtor_SNA);
            Controls.Add(textBoxDebtWhole_SNA);
            Controls.Add(textBoxDebtWholeNamer_SNA);
            Controls.Add(textBoxFilePathNamer_SNA);
            Controls.Add(textBoxFilePath_SNA);
            Controls.Add(dataGridViewFile_SNA);
            Controls.Add(buttonOpenFile_SNA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "ДомPro";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile_SNA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie_SNA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog_SNA;
        private Button buttonOpenFile_SNA;
        private DataGridView dataGridViewFile_SNA;
        private TextBox textBoxFilePath_SNA;
        private TextBox textBoxFilePathNamer_SNA;
        private TextBox textBoxDebtWholeNamer_SNA;
        private TextBox textBoxDebtWhole_SNA;
        private TextBox textBoxDebtor_SNA;
        private TextBox textBoxDebtMin_SNA;
        private TextBox textBoxDebtMax_SNA;
        private TextBox textBoxDebtorNamer_SNA;
        private TextBox textBoxDebtMinNamer_SNA;
        private TextBox textBoxDebtMaxNamer_SNA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie_SNA;
        private Button buttonFormatData_SNA;
        private SaveFileDialog saveFileDialog_SNA;
        private Button buttonSaveEditedFile_SNA;
        private Button buttonInfo_SNA;
        private Button buttonManual_SNA;
    }
}
