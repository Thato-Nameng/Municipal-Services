using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_Services
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportIssues reportForm = new ReportIssues();
            this.Hide();
            reportForm.Show();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            LocalEvents localEvents = new LocalEvents();
            this.Hide();
            localEvents.Show();
        }
    }
}
