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
            this.lblAzureIoTHubURL = new System.Windows.Forms.Label();
            this.txtAzureIoTHubAPIKey = new System.Windows.Forms.TextBox();
            this.lblAzureIoTHubAPIKey = new System.Windows.Forms.Label();
            this.btnEnableIoTLoggingEnable = new System.Windows.Forms.Button();
            this.btnAzureIoTLoggingDisable = new System.Windows.Forms.Button();
            this.lbleAzureIoTLoggingStatus = new System.Windows.Forms.Label();
            this.btnTestAzureIoTConnection = new System.Windows.Forms.Button();
            this.btnSaveConnectionSettings = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
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
            this.txtInstructions.Size = new System.Drawing.Size(366, 144);
            this.txtInstructions.TabIndex = 1;
            this.txtInstructions.Text = "This form will host all the controlsl & functionality for configuring Mission Pla" +
    "nner to ALSO log all telemetry log to an Azure IoT Hub repo for archiving & proc" +
    "essing.. \r\n\r\n";
            this.txtInstructions.TextChanged += new System.EventHandler(this.txtInstructions_TextChanged);
            // 
            // txtAzureIoTHubURL
            // 
            this.txtAzureIoTHubURL.Location = new System.Drawing.Point(137, 237);
            this.txtAzureIoTHubURL.Name = "txtAzureIoTHubURL";
            this.txtAzureIoTHubURL.Size = new System.Drawing.Size(621, 20);
            this.txtAzureIoTHubURL.TabIndex = 2;
            // 
            // lblAzureIoTHubURL
            // 
            this.lblAzureIoTHubURL.AutoSize = true;
            this.lblAzureIoTHubURL.Location = new System.Drawing.Point(33, 241);
            this.lblAzureIoTHubURL.Name = "lblAzureIoTHubURL";
            this.lblAzureIoTHubURL.Size = new System.Drawing.Size(98, 13);
            this.lblAzureIoTHubURL.TabIndex = 3;
            this.lblAzureIoTHubURL.Text = "Azue IoT Hub URL";
            // 
            // txtAzureIoTHubAPIKey
            // 
            this.txtAzureIoTHubAPIKey.Location = new System.Drawing.Point(137, 274);
            this.txtAzureIoTHubAPIKey.Name = "txtAzureIoTHubAPIKey";
            this.txtAzureIoTHubAPIKey.Size = new System.Drawing.Size(440, 20);
            this.txtAzureIoTHubAPIKey.TabIndex = 4;
            // 
            // lblAzureIoTHubAPIKey
            // 
            this.lblAzureIoTHubAPIKey.AutoSize = true;
            this.lblAzureIoTHubAPIKey.Location = new System.Drawing.Point(31, 277);
            this.lblAzureIoTHubAPIKey.Name = "lblAzureIoTHubAPIKey";
            this.lblAzureIoTHubAPIKey.Size = new System.Drawing.Size(98, 13);
            this.lblAzureIoTHubAPIKey.TabIndex = 5;
            this.lblAzureIoTHubAPIKey.Text = "Azue IoT Hub URL";
            // 
            // btnEnableIoTLoggingEnable
            // 
            this.btnEnableIoTLoggingEnable.Location = new System.Drawing.Point(376, 350);
            this.btnEnableIoTLoggingEnable.Name = "btnEnableIoTLoggingEnable";
            this.btnEnableIoTLoggingEnable.Size = new System.Drawing.Size(75, 32);
            this.btnEnableIoTLoggingEnable.TabIndex = 6;
            this.btnEnableIoTLoggingEnable.Text = "Enabled";
            this.btnEnableIoTLoggingEnable.UseVisualStyleBackColor = true;
            this.btnEnableIoTLoggingEnable.Click += new System.EventHandler(this.btnEnableIoTLoggingEnable_Click);
            // 
            // btnAzureIoTLoggingDisable
            // 
            this.btnAzureIoTLoggingDisable.Location = new System.Drawing.Point(460, 350);
            this.btnAzureIoTLoggingDisable.Name = "btnAzureIoTLoggingDisable";
            this.btnAzureIoTLoggingDisable.Size = new System.Drawing.Size(75, 32);
            this.btnAzureIoTLoggingDisable.TabIndex = 7;
            this.btnAzureIoTLoggingDisable.Text = "Disabled";
            this.btnAzureIoTLoggingDisable.UseVisualStyleBackColor = true;
            this.btnAzureIoTLoggingDisable.Click += new System.EventHandler(this.btnAzureIoTLoggingDisable_Click);
            // 
            // lbleAzureIoTLoggingStatus
            // 
            this.lbleAzureIoTLoggingStatus.AutoSize = true;
            this.lbleAzureIoTLoggingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleAzureIoTLoggingStatus.Location = new System.Drawing.Point(373, 324);
            this.lbleAzureIoTLoggingStatus.Name = "lbleAzureIoTLoggingStatus";
            this.lbleAzureIoTLoggingStatus.Size = new System.Drawing.Size(192, 17);
            this.lbleAzureIoTLoggingStatus.TabIndex = 8;
            this.lbleAzureIoTLoggingStatus.Text = "Azure IoT Logging Status";
            // 
            // btnTestAzureIoTConnection
            // 
            this.btnTestAzureIoTConnection.Location = new System.Drawing.Point(34, 350);
            this.btnTestAzureIoTConnection.Name = "btnTestAzureIoTConnection";
            this.btnTestAzureIoTConnection.Size = new System.Drawing.Size(112, 32);
            this.btnTestAzureIoTConnection.TabIndex = 9;
            this.btnTestAzureIoTConnection.Text = "Test Connection";
            this.btnTestAzureIoTConnection.UseVisualStyleBackColor = true;
            // 
            // btnSaveConnectionSettings
            // 
            this.btnSaveConnectionSettings.Location = new System.Drawing.Point(161, 350);
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
            this.btnCloseForm.Location = new System.Drawing.Point(704, 406);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 32);
            this.btnCloseForm.TabIndex = 12;
            this.btnCloseForm.Text = "Done";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmConfigIoTLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnSaveConnectionSettings);
            this.Controls.Add(this.btnTestAzureIoTConnection);
            this.Controls.Add(this.lbleAzureIoTLoggingStatus);
            this.Controls.Add(this.btnAzureIoTLoggingDisable);
            this.Controls.Add(this.btnEnableIoTLoggingEnable);
            this.Controls.Add(this.lblAzureIoTHubAPIKey);
            this.Controls.Add(this.txtAzureIoTHubAPIKey);
            this.Controls.Add(this.lblAzureIoTHubURL);
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
        private System.Windows.Forms.Label lblAzureIoTHubURL;
        private System.Windows.Forms.TextBox txtAzureIoTHubAPIKey;
        private System.Windows.Forms.Label lblAzureIoTHubAPIKey;
        private System.Windows.Forms.Button btnEnableIoTLoggingEnable;
        private System.Windows.Forms.Button btnAzureIoTLoggingDisable;
        private System.Windows.Forms.Label lbleAzureIoTLoggingStatus;
        private System.Windows.Forms.Button btnTestAzureIoTConnection;
        private System.Windows.Forms.Button btnSaveConnectionSettings;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnCloseForm;
    }
}