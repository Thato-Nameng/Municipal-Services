using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Municipal_Services
{
    public partial class DisplayReports : Form
    {
        public DisplayReports()
        {
            InitializeComponent();
        }

        private void DisplayReports_Load(object sender, EventArgs e)
        {

        }

        public void LoadReports(List<List<string>> reports)
        {
            dataGridView1.Rows.Clear();

            if (!dataGridView1.Columns.Contains("AttachFile"))
            {
                DataGridViewTextBoxColumn fileColumn = new DataGridViewTextBoxColumn();
                fileColumn.Name = "AttachFile";
                fileColumn.HeaderText = "Attach File";
                fileColumn.Visible = false;
                dataGridView1.Columns.Add(fileColumn);
            }

            foreach (var report in reports)
            {
                if (report.Count > 5)
                {
                    int rowIndex = dataGridView1.Rows.Add(report[0], report[1], report[2], report[3], report[4]);
                    string filePath = report[5];
                    dataGridView1.Rows[rowIndex].Cells["AttachFile"].Value = filePath;
                }
                else
                {
                    MessageBox.Show("Report data is missing columns.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["colDownload"].Index && e.RowIndex >= 0)
            {
                var filePathCell = dataGridView1.Rows[e.RowIndex].Cells["AttachFile"];
                if (filePathCell.Value != null)
                {
                    string filePath = filePathCell.Value.ToString();
                    if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath))
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = filePath,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to open file: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("File does not exist or path is invalid.");
                    }
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            ReportIssues report = new ReportIssues();
            this.Hide();
            report.Show();
        }
    }
}
