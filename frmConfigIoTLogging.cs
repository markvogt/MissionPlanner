using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//ADD COMPILER DIRECTIVE for using Azure Devices.Client library...
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using Message = Microsoft.Azure.Devices.Client.Message;

namespace MissionPlanner
{
    public partial class frmConfigIoTLogging : Form
    {
        //DEFINE a constant for the AzureIoTHub Device Connection String... 
        private const String strDeviceConnectionString = "HostName=ps-course-IoT-Hub.azure-devices.net;DeviceId=device-01;SharedAccessKey=UzzCD7ugx7hNjaOg4c5ETEoY3eJGyPipM8LlPRrPAZQ=";

        public DeviceClient oDeviceClient; 

        //DECLARE & INITIALIZE a publicly-scope flag for multiple form buttons to control stopping & starting a messaging loop...
        public Boolean bContinueMessagingFlag = false;

        //DECLARE a publicly-scoped string representing the TopLine of the MP Log file (assuming file is appended at the top)...
        public String strTopLine; 

        public frmConfigIoTLogging()
        {
            InitializeComponent();
        }

        private void btnTESTEnabled_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            //CLOSE this form... 
            this.Close();
        }

        private void BtnConnectToAzureIoTHub_Click(object sender, EventArgs e)
        {
            //INSTANTIATE a new "device client" object... 
            oDeviceClient = DeviceClient.CreateFromConnectionString(strDeviceConnectionString);

            //ESTABLISH a connection between the device on Azure IoT Hub...
            oDeviceClient.OpenAsync();

            //LOG successful connection to console... 
            txtLoggingConsole.AppendText("Device successfully connected ! ...\r\n");
        }

        private async void BtnStartMessaging_ClickAsync(object sender, EventArgs e)
        {

            //INITIALIZE a counter for the loop...
            var count = 1;

            //SET background of btnAzureIoTLoggingEnabled to green... 
            BtnStartMessaging.BackColor = Color.Green;
            BtnStopMessaging.BackColor = Color.Gray;

            //SET a publicly-scoped flag for controlling messaging looping to true...
            bContinueMessagingFlag = true;

            //BEGIN looping (endlessly to start)...
            while (bContinueMessagingFlag)
            {
                var currentcount = count++;

                //CREATE a new message string composed of static text and the current top line of the MP Log file... 
                //var strMessage = "This is Message #" + currentcount + " from device-01 inside MissionPlanner...";
                var strMessage = "Current Line from MP Log: " + strTopLine + "\r\n"; 

                //INSTANTIATE a new message using the Message class..
                var oMessage = new Message( Encoding.ASCII.GetBytes(strMessage) );

                //SEND the message to AzureIoTHub asynchronously and wait for re response... 
                await oDeviceClient.SendEventAsync(oMessage);

                //LOG current status to the txtLoggingConsole control...
                txtLoggingConsole.AppendText(strMessage + "\r\n");

                //PAUSE for some time... 
                Thread.Sleep(2000);
            }

        }

        private void BtnStopMessaging_Click(object sender, EventArgs e)
        {
            //SET the public flag controlling messaging looping to false...
            bContinueMessagingFlag = false;

            //SET background of btnAzureIoTLoggingEnabled to green... 
            BtnStartMessaging.BackColor = Color.Gray;
            BtnStopMessaging.BackColor = Color.Red;
        }

        private void frmConfigIoTLogging_Load(object sender, EventArgs e)
        {
            //UPDATE the value of the DeviceConnectionString text box so we know what device is being connected-to in AzureIoTHub...
            txtAzureIoTHubURL.Text = strDeviceConnectionString;
        }

        private void btnStartReadingMPLog_Click(object sender, EventArgs e)
        {
            //DEFINE & INITIALIZE a variable to hold the path & filename to the MP log file...
            String strFullFileName = txtMPLogFullFileName.Text;

            //INSTANTIATE a Stream (file) object pointed at the MP log...
            StreamReader sr = new StreamReader(strFullFileName);

            //READ only the top (first) line of the file and assign it to the public variable strTopLine... 
            //The existing messaging loop will now use THIS value to post to AzureIoTHub and to the form's Logging textbox...
            strTopLine = sr.ReadLine();
        }

        private void btnStopReadingMPLog_Click(object sender, EventArgs e)
        {
            //STOP reading the MP log... 
        }

        private void btnPickMPLogFile_Click(object sender, EventArgs e)
        {
            //OPEN the OpenFileDialog dialog... 
            openFileDialog1.ShowDialog();

            //ASSIGN the value of the txtbox to the selected value from the dialog... 
            txtMPLogFullFileName.Text = openFileDialog1.FileName;
        }
    }
}
