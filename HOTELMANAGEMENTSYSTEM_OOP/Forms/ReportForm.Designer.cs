namespace HOTELMANAGEMENTSYSTEM_OOP.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewReports = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dataGridViewReport = new DataGridView();
            Period = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(137, 40);
            label1.TabIndex = 10;
            label1.Text = "REPORT";
            // 
            // dataGridViewReports
            // 
            dataGridViewReports.AllowUserToAddRows = false;
            dataGridViewReports.AllowUserToDeleteRows = false;
            dataGridViewReports.AllowUserToResizeRows = false;
            dataGridViewReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReports.BackgroundColor = Color.White;
            dataGridViewReports.BorderStyle = BorderStyle.None;
            dataGridViewReports.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReports.ColumnHeadersHeight = 30;
            dataGridViewReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewReports.Columns.AddRange(new DataGridViewColumn[] { Column3, Column5 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(178, 203, 222);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewReports.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewReports.EnableHeadersVisualStyles = false;
            dataGridViewReports.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewReports.Location = new Point(50, 109);
            dataGridViewReports.Name = "dataGridViewReports";
            dataGridViewReports.ReadOnly = true;
            dataGridViewReports.RowHeadersVisible = false;
            dataGridViewReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReports.Size = new Size(1151, 751);
            dataGridViewReports.TabIndex = 11;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle2;
            Column3.HeaderText = "Date";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            Column5.DefaultCellStyle = dataGridViewCellStyle3;
            Column5.HeaderText = "Total Earnings";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewReport.AllowUserToDeleteRows = false;
            dataGridViewReport.AllowUserToResizeRows = false;
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReport.BackgroundColor = Color.White;
            dataGridViewReport.BorderStyle = BorderStyle.None;
            dataGridViewReport.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(178, 203, 222);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewReport.ColumnHeadersHeight = 40;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewReport.Columns.AddRange(new DataGridViewColumn[] { Period, Total });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(216, 225, 232);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 7, 45);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewReport.EnableHeadersVisualStyles = false;
            dataGridViewReport.GridColor = Color.FromArgb(0, 7, 45);
            dataGridViewReport.Location = new Point(12, 90);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.Teal;
            dataGridViewReport.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReport.Size = new Size(1198, 805);
            dataGridViewReport.TabIndex = 19;
            // 
            // Period
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            Period.DefaultCellStyle = dataGridViewCellStyle6;
            Period.HeaderText = "Date";
            Period.Name = "Period";
            Period.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            Total.DefaultCellStyle = dataGridViewCellStyle7;
            Total.HeaderText = "Total Earnings";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 907);
            Controls.Add(dataGridViewReport);
            Controls.Add(dataGridViewReports);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewReports;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView dataGridViewReport;
        private DataGridViewTextBoxColumn Period;
        private DataGridViewTextBoxColumn Total;
    }
}