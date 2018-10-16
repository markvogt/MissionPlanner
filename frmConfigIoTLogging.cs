using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class frmConfigIoTLogging : Form
    {
        public frmConfigIoTLogging()
        {
            InitializeComponent();
        }

        private void txtInstructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTESTEnabled_Click(object sender, EventArgs e)
        {

        }

        private void btnEnableIoTLoggingEnable_Click(object sender, EventArgs e)
        {
            //SET background of btnAzureIoTLoggingEnabled to green... 
            btnEnableIoTLoggingEnable.BackColor = Color.Green;
            btnAzureIoTLoggingDisable.BackColor = Color.Gray;
        }

        private void btnAzureIoTLoggingDisable_Click(object sender, EventArgs e)
        {
            //SET background of btnAzureIoTLoggingEnabled to green... 
            btnEnableIoTLoggingEnable.BackColor = Color.Gray;
            btnAzureIoTLoggingDisable.BackColor = Color.Green;
        }

        private void frmConfigIoTLogging_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            //CLOSE this form... 
            this.Close();
        }
    }
}
