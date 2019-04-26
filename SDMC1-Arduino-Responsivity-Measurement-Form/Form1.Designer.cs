namespace SDMC1_Arduino_Responsivity_Measurement_Form
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SDMC1Port = new System.Windows.Forms.ComboBox();
            this.ArduinoPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SDMC1BaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArduinoBaudRate = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.FileLocationText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveSelectionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.SDMC1SendText = new System.Windows.Forms.TextBox();
            this.SDMC1ReadText = new System.Windows.Forms.TextBox();
            this.ArduinoSendText = new System.Windows.Forms.TextBox();
            this.ArduinoReadText = new System.Windows.Forms.TextBox();
            this.SDMC1SendButton = new System.Windows.Forms.Button();
            this.ArduinoSendButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.ScanButton = new System.Windows.Forms.Button();
            this.SDMC1SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.ArduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.ScanProgress = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SDMC1:";
            // 
            // SDMC1Port
            // 
            this.SDMC1Port.AllowDrop = true;
            this.SDMC1Port.FormattingEnabled = true;
            this.SDMC1Port.Location = new System.Drawing.Point(92, 34);
            this.SDMC1Port.Name = "SDMC1Port";
            this.SDMC1Port.Size = new System.Drawing.Size(231, 21);
            this.SDMC1Port.TabIndex = 1;
            this.SDMC1Port.DropDown += new System.EventHandler(this.SDMC1Port_DropDown);
            // 
            // ArduinoPort
            // 
            this.ArduinoPort.FormattingEnabled = true;
            this.ArduinoPort.Location = new System.Drawing.Point(92, 61);
            this.ArduinoPort.Name = "ArduinoPort";
            this.ArduinoPort.Size = new System.Drawing.Size(231, 21);
            this.ArduinoPort.TabIndex = 2;
            this.ArduinoPort.DropDown += new System.EventHandler(this.ArduinoPort_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arduino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // SDMC1BaudRate
            // 
            this.SDMC1BaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.SDMC1BaudRate.FormattingEnabled = true;
            this.SDMC1BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600"});
            this.SDMC1BaudRate.Location = new System.Drawing.Point(341, 34);
            this.SDMC1BaudRate.Name = "SDMC1BaudRate";
            this.SDMC1BaudRate.Size = new System.Drawing.Size(121, 21);
            this.SDMC1BaudRate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baud Rate";
            // 
            // ArduinoBaudRate
            // 
            this.ArduinoBaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000",
            "500000",
            "1000000",
            "2000000"});
            this.ArduinoBaudRate.FormattingEnabled = true;
            this.ArduinoBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600"});
            this.ArduinoBaudRate.Location = new System.Drawing.Point(341, 60);
            this.ArduinoBaudRate.Name = "ArduinoBaudRate";
            this.ArduinoBaudRate.Size = new System.Drawing.Size(121, 21);
            this.ArduinoBaudRate.TabIndex = 8;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(479, 11);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(117, 49);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // FileLocationText
            // 
            this.FileLocationText.Location = new System.Drawing.Point(108, 353);
            this.FileLocationText.Name = "FileLocationText";
            this.FileLocationText.Size = new System.Drawing.Size(434, 20);
            this.FileLocationText.TabIndex = 10;
            this.FileLocationText.Text = "C:\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Save Scan:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Title = "SaveScanFile";
            // 
            // SaveSelectionButton
            // 
            this.SaveSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSelectionButton.Location = new System.Drawing.Point(548, 353);
            this.SaveSelectionButton.Name = "SaveSelectionButton";
            this.SaveSelectionButton.Size = new System.Drawing.Size(58, 20);
            this.SaveSelectionButton.TabIndex = 12;
            this.SaveSelectionButton.Text = "Save";
            this.SaveSelectionButton.UseVisualStyleBackColor = true;
            this.SaveSelectionButton.Click += new System.EventHandler(this.SaveSelectionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ports Connect";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.Location = new System.Drawing.Point(489, 61);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(117, 31);
            this.DisconnectButton.TabIndex = 10;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // SDMC1SendText
            // 
            this.SDMC1SendText.Enabled = false;
            this.SDMC1SendText.Location = new System.Drawing.Point(281, 162);
            this.SDMC1SendText.Multiline = true;
            this.SDMC1SendText.Name = "SDMC1SendText";
            this.SDMC1SendText.Size = new System.Drawing.Size(100, 75);
            this.SDMC1SendText.TabIndex = 14;
            // 
            // SDMC1ReadText
            // 
            this.SDMC1ReadText.Location = new System.Drawing.Point(387, 183);
            this.SDMC1ReadText.Multiline = true;
            this.SDMC1ReadText.Name = "SDMC1ReadText";
            this.SDMC1ReadText.ReadOnly = true;
            this.SDMC1ReadText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SDMC1ReadText.Size = new System.Drawing.Size(100, 90);
            this.SDMC1ReadText.TabIndex = 15;
            // 
            // ArduinoSendText
            // 
            this.ArduinoSendText.Enabled = false;
            this.ArduinoSendText.Location = new System.Drawing.Point(15, 162);
            this.ArduinoSendText.Multiline = true;
            this.ArduinoSendText.Name = "ArduinoSendText";
            this.ArduinoSendText.Size = new System.Drawing.Size(100, 75);
            this.ArduinoSendText.TabIndex = 16;
            // 
            // ArduinoReadText
            // 
            this.ArduinoReadText.Location = new System.Drawing.Point(121, 183);
            this.ArduinoReadText.Multiline = true;
            this.ArduinoReadText.Name = "ArduinoReadText";
            this.ArduinoReadText.ReadOnly = true;
            this.ArduinoReadText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArduinoReadText.Size = new System.Drawing.Size(100, 90);
            this.ArduinoReadText.TabIndex = 17;
            // 
            // SDMC1SendButton
            // 
            this.SDMC1SendButton.Enabled = false;
            this.SDMC1SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDMC1SendButton.Location = new System.Drawing.Point(281, 243);
            this.SDMC1SendButton.Name = "SDMC1SendButton";
            this.SDMC1SendButton.Size = new System.Drawing.Size(100, 30);
            this.SDMC1SendButton.TabIndex = 18;
            this.SDMC1SendButton.Text = "Send";
            this.SDMC1SendButton.UseVisualStyleBackColor = true;
            this.SDMC1SendButton.Click += new System.EventHandler(this.SDMC1SendButton_Click);
            // 
            // ArduinoSendButton
            // 
            this.ArduinoSendButton.Enabled = false;
            this.ArduinoSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArduinoSendButton.Location = new System.Drawing.Point(15, 243);
            this.ArduinoSendButton.Name = "ArduinoSendButton";
            this.ArduinoSendButton.Size = new System.Drawing.Size(100, 30);
            this.ArduinoSendButton.TabIndex = 20;
            this.ArduinoSendButton.Text = "Send";
            this.ArduinoSendButton.UseVisualStyleBackColor = true;
            this.ArduinoSendButton.Click += new System.EventHandler(this.ArduinoSendButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Enabled = false;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(495, 162);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(117, 49);
            this.HomeButton.TabIndex = 10;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.Enabled = false;
            this.ScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanButton.Location = new System.Drawing.Point(495, 224);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(117, 49);
            this.ScanButton.TabIndex = 22;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // SDMC1SerialPort
            // 
            this.SDMC1SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SDMC1SerialPort_DataReceived);
            // 
            // ArduinoSerialPort
            // 
            this.ArduinoSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ArduinoSerialPort_DataReceived);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "SDMC1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Arduino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Message:";
            // 
            // MessageText
            // 
            this.MessageText.Enabled = false;
            this.MessageText.Location = new System.Drawing.Point(92, 101);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(464, 20);
            this.MessageText.TabIndex = 26;
            // 
            // ScanProgress
            // 
            this.ScanProgress.Location = new System.Drawing.Point(15, 300);
            this.ScanProgress.Name = "ScanProgress";
            this.ScanProgress.Size = new System.Drawing.Size(598, 23);
            this.ScanProgress.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Progress:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Received:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(387, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Received:";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(562, 101);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(44, 20);
            this.ClearButton.TabIndex = 31;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 383);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ScanProgress);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.ArduinoSendButton);
            this.Controls.Add(this.SDMC1SendButton);
            this.Controls.Add(this.ArduinoReadText);
            this.Controls.Add(this.ArduinoSendText);
            this.Controls.Add(this.SDMC1ReadText);
            this.Controls.Add(this.SDMC1SendText);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.SaveSelectionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileLocationText);
            this.Controls.Add(this.ArduinoBaudRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SDMC1BaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArduinoPort);
            this.Controls.Add(this.SDMC1Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SDMC1Port;
        private System.Windows.Forms.ComboBox ArduinoPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SDMC1BaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ArduinoBaudRate;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox FileLocationText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SaveSelectionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox SDMC1SendText;
        private System.Windows.Forms.TextBox SDMC1ReadText;
        private System.Windows.Forms.TextBox ArduinoSendText;
        private System.Windows.Forms.TextBox ArduinoReadText;
        private System.Windows.Forms.Button SDMC1SendButton;
        private System.Windows.Forms.Button ArduinoSendButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button ScanButton;
        private System.IO.Ports.SerialPort SDMC1SerialPort;
        private System.IO.Ports.SerialPort ArduinoSerialPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.ProgressBar ScanProgress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ClearButton;
    }
}

