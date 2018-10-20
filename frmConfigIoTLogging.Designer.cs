namespace MissionPlanner
{
    partial class frmConfigIoTLogging
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.txtAzureIoTHubURL = new System.Windows.Forms.TextBox();
            this.lblAzureIoTConnectionString = new System.Windows.Forms.Label();
            this.BtnStartMessaging = new System.Windows.Forms.Button();
            this.BtnStopMessaging = new System.Windows.Forms.Button();
            this.lblMessagingStatus = new System.Windows.Forms.Label();
            this.BtnConnectToAzureIoTHub = new System.Windows.Forms.Button();
            this.btnSaveConnectionSettings = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lblAzureIoTSettings = new System.Windows.Forms.Label();
            this.txtLoggingConsole = new System.Windows.Forms.TextBox();
            this.lblLoggingConsole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(31, 25);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(100, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "INSTRUCTIONS";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Enabled = false;
            this.txtInstructions.Location = new System.Drawing.Point(34, 50);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstructions.Size = new System.Drawing.Size(359, 78);
            this.txtInstructions.TabIndex = 1;
            this.txtInstructions.Text = "This form will host all the controlsl & functionality for configuring Mission Pla" +
    "nner to ALSO log all telemetry log to an Azure IoT Hub repo for archiving & proc" +
    "essing.. \r\n\r\n";
            // 
            // txtAzureIoTHubURL
            // 
            this.txtAzureIoTHubURL.Location = new System.Drawing.Point(209, 182);
            this.txtAzureIoTHubURL.Name = "txtAzureIoTHubURL";
            this.txtAzureIoTHubURL.ReadOnly = true;
            this.txtAzureIoTHubURL.Size = new System.Drawing.Size(316, 20);
            this.txtAzureIoTHubURL.TabIndex = 2;
            // 
            // lblAzureIoTConnectionString
            // 
            this.lblAzureIoTConnectionString.AutoSize = true;
            this.lblAzureIoTConnectionString.Location = new System.Drawing.Point(34, 185);
            this.lblAzureIoTConnectionString.Name = "lblAzureIoTConnectionString";
            this.lblAzureIoTConnectionString.Size = new System.Drawing.Size(160, 13);
            this.lblAzureIoTConnectionString.TabIndex = 3;
            this.lblAzureIoTConnectionString.Text = "Azue IoT Hub Connection String";
            // 
            // BtnStartMessaging
            // 
            this.BtnStartMessaging.Location = new System.Drawing.Point(293, 350);
            this.BtnStartMessaging.Name = "BtnStartMessaging";
            this.BtnStartMessaging.Size = new System.Drawing.Size(75, 32);
            this.BtnStartMessaging.TabIndex = 6;
            this.BtnStartMessaging.Text = "Start";
            this.BtnStartMessaging.UseVisualStyleBackColor = true;
            this.BtnStartMessaging.Click += new System.EventHandler(this.BtnStartMessaging_ClickAsync);
            // 
            // BtnStopMessaging
            // 
            this.BtnStopMessaging.Location = new System.Drawing.Point(396, 350);
            this.BtnStopMessaging.Name = "BtnStopMessaging";
            this.BtnStopMessaging.Size = new System.Drawing.Size(75, 32);
            this.BtnStopMessaging.TabIndex = 7;
            this.BtnStopMessaging.Text = "Stop";
            this.BtnStopMessaging.UseVisualStyleBackColor = true;
            this.BtnStopMessaging.Click += new System.EventHandler(this.BtnStopMessaging_Click);
            // 
            // lblMessagingStatus
            // 
            this.lblMessagingStatus.AutoSize = true;
            this.lblMessagingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessagingStatus.Location = new System.Drawing.Point(290, 323);
            this.lblMessagingStatus.Name = "lblMessagingStatus";
            this.lblMessagingStatus.Size = new System.Drawing.Size(245, 17);
            this.lblMessagingStatus.TabIndex = 8;
            this.lblMessagingStatus.Text = "Azure IoT Hub Messaging Status";
            // 
            // BtnConnectToAzureIoTHub
            // 
            this.BtnConnectToAzureIoTHub.Location = new System.Drawing.Point(34, 350);
            this.BtnConnectToAzureIoTHub.Name = "BtnConnectToAzureIoTHub";
            this.BtnConnectToAzureIoTHub.Size = new System.Drawing.Size(160, 32);
            this.BtnConnectToAzureIoTHub.TabIndex = 9;
            this.BtnConnectToAzureIoTHub.Text = "Connect to AzureIoTHub";
            this.BtnConnectToAzureIoTHub.UseVisualStyleBackColor = true;
            this.BtnConnectToAzureIoTHub.Click += new System.EventHandler(this.BtnConnectToAzureIoTHub_Click);
            // 
            // btnSaveConnectionSettings
            // 
            this.btnSaveConnectionSettings.Location = new System.Drawing.Point(413, 221);
            this.btnSaveConnectionSettings.Name = "btnSaveConnectionSettings";
            this.btnSaveConnectionSettings.Size = new System.Drawing.Size(112, 32);
            this.btnSaveConnectionSettings.TabIndex = 10;
            this.btnSaveConnectionSettings.Text = "Save Settings";
            this.btnSaveConnectionSettings.UseVisualStyleBackColor = true;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(33, 323);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(141, 13);
            this.lblConnectionStatus.TabIndex = 11;
            this.lblConnectionStatus.Text = "CONNECTION STATUS";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(846, 406);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 32);
            this.btnCloseForm.TabIndex = 12;
            this.btnCloseForm.Text = "Done";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lblAzureIoTSettings
            // 
            this.lblAzureIoTSettings.AutoSize = true;
            this.lblAzureIoTSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAzureIoTSettings.Location = new System.Drawing.Point(34, 150);
            this.lblAzureIoTSettings.Name = "lblAzureIoTSettings";
            this.lblAzureIoTSettings.Size = new System.Drawing.Size(140, 13);
            this.lblAzureIoTSettings.TabIndex = 13;
            this.lblAzureIoTSettings.Text = "AZURE IOT SETTINGS";
            // 
            // txtLoggingConsole
            // 
            this.txtLoggingConsole.Location = new System.Drawing.Point(562, 50);
            this.txtLoggingConsole.Multiline = true;
            this.txtLoggingConsole.Name = "txtLoggingConsole";
            this.txtLoggingConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoggingConsole.Size = new System.Drawing.Size(359, 332);
            this.txtLoggingConsole.TabIndex = 14;
            // 
            // lblLoggingConsole
            // 
            this.lblLoggingConsole.AutoSize = true;
            this.lblLoggingConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggingConsole.Location = new System.Drawing.Point(559, 25);
            this.lblLoggingConsole.Name = "lblLoggingConsole";
            this.lblLoggingConsole.Size = new System.Drawing.Size(150, 13);
            this.lblLoggingConsole.TabIndex = 15;
            this.lblLoggingConsole.Text = "IOT LOGGING CONSOLE";
            // 
            // frmConfigIoTLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.lblLoggingConsole);
            this.Controls.Add(this.txtLoggingConsole);
            this.Controls.Add(this.lblAzureIoTSettings);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnSaveConnectionSettings);
            this.Controls.Add(this.BtnConnectToAzureIoTHub);
            this.Controls.Add(this.lblMessagingStatus);
            this.Controls.Add(this.BtnStopMessaging);
            this.Controls.Add(this.BtnStartMessaging);
            this.Controls.Add(this.lblAzureIoTConnectionString);
            this.Controls.Add(this.txtAzureIoTHubURL);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmConfigIoTLogging";
            this.Text = "Configure IoT Logging";
            this.Load += new System.EventHandler(this.frmConfigIoTLogging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.TextBox txtAzureIoTHubURL;
        private System.Windows.Forms.Label lblAzureIoTConnectionString;
        private System.Windows.Forms.Button BtnStartMessaging;
        private System.Windows.Forms.Button BtnStopMessaging;
        private System.Windows.Forms.Label lblMessagingStatus;
        private System.Windows.Forms.Button BtnConnectToAzureIoTHub;
        private System.Windows.Forms.Button btnSaveConnectionSettings;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblAzureIoTSettings;
        private System.Windows.Forms.TextBox txtLoggingConsole;
        private System.Windows.Forms.Label lblLoggingConsole;
    }
}