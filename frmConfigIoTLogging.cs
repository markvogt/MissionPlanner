using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                //INSTANTIATE a new message using the Message class... 
                var oMessage = new Message( Encoding.ASCII.GetBytes("This is message #" + currentcount + " from device-01 inside MissionPlanner...") );

                //SEND the message to AzureIoTHub asynchronously and wait for re response... 
                await oDeviceClient.SendEventAsync(oMessage);

                //LOG current status to the txtLoggingConsole control...
                txtLoggingConsole.AppendText("oMessage" + currentcount + " sent to AzureIoTHub in the cloud...\r\n");

                //SLEEP for some time... 
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
    }
}
