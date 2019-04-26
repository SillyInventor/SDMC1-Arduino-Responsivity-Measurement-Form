using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace SDMC1_Arduino_Responsivity_Measurement_Form
{
    public partial class Form1 : Form
    {
        int moves = 0;
        int scanLength = 12000;
        int homeDistance = 12100;
        int timeoutMS = 5000;

        string SDMC1Message = "";
        string ArduinoMessage = "";

        List<int> measurementData = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void SDMC1Port_DropDown(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            SDMC1Port.Items.AddRange(ports);
        }

        private void ArduinoPort_DropDown(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            ArduinoPort.Items.AddRange(ports);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(SDMC1BaudRate.SelectedItem == "" || SDMC1Port.SelectedItem == "" || ArduinoPort.SelectedItem == "" || ArduinoBaudRate.SelectedItem == "")
            {
                MessageText.Text = "Specify ports and baudrates";
            }
            else { 
                try
                {
                    //Connect to SDMC1
                    SDMC1SerialPort.PortName = SDMC1Port.SelectedItem.ToString();
                    SDMC1SerialPort.BaudRate = Convert.ToInt32(SDMC1BaudRate.SelectedItem.ToString());
                    SDMC1SerialPort.ReadTimeout = timeoutMS;
                    SDMC1SerialPort.DataBits = 8;
                    SDMC1SerialPort.StopBits = StopBits.One;
                    SDMC1SerialPort.Parity = Parity.None;
                    SDMC1SerialPort.Open();

                    //Connect to Arduino
                    ArduinoSerialPort.PortName = ArduinoPort.SelectedItem.ToString();
                    ArduinoSerialPort.BaudRate = Convert.ToInt32(ArduinoBaudRate.SelectedItem.ToString());
                    ArduinoSerialPort.ReadTimeout = timeoutMS;
                    ArduinoSerialPort.Open();

                    //Change connection interaction
                    DisconnectButton.Enabled = true;
                    SDMC1Port.Enabled = false;
                    SDMC1BaudRate.Enabled = false;
                    ArduinoPort.Enabled = false;
                    ArduinoBaudRate.Enabled = false;
                    ConnectButton.Enabled = false;

                    //Change controller interaction
                    ArduinoSendText.Enabled = true;
                    ArduinoSendButton.Enabled = true;

                    SDMC1SendText.Enabled = true;
                    SDMC1SendButton.Enabled = true;

                    HomeButton.Enabled = true;
                }
                catch (Exception error)
                {
                    MessageText.Text = error.Message;

                    //if something goes wrong, close the ports that may be open
                    SDMC1SerialPort.Close();
                    ArduinoSerialPort.Close();

                    //Change connection interaction
                    SDMC1Port.Enabled = true;
                    SDMC1BaudRate.Enabled = true;
                    ArduinoPort.Enabled = true;
                    ArduinoBaudRate.Enabled = true;
                    ConnectButton.Enabled = true;
                    DisconnectButton.Enabled = false;

                    //Change controller interaction
                    ArduinoSendText.Enabled = false;
                    ArduinoSendButton.Enabled = false;

                    SDMC1SendText.Enabled = false;
                    SDMC1SendButton.Enabled = false;

                    HomeButton.Enabled = false;
                    ScanButton.Enabled = false;
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if something goes wrong, close the ports that may be open
                SDMC1SerialPort.Close();
                ArduinoSerialPort.Close();

                //Change connection interaction
                SDMC1Port.Enabled = true;
                SDMC1BaudRate.Enabled = true;
                ArduinoPort.Enabled = true;
                ArduinoBaudRate.Enabled = true;
                ConnectButton.Enabled = true;
                DisconnectButton.Enabled = false;

                //Change controller interaction
                ArduinoSendText.Enabled = false;
                ArduinoSendButton.Enabled = false;

                SDMC1SendText.Enabled = false;
                SDMC1SendButton.Enabled = false;

                HomeButton.Enabled = false;
                ScanButton.Enabled = false;
            }
            catch (Exception error)
            {
                MessageText.Text = error.Message;
            }
        }

        private void ArduinoSendButton_Click(object sender, EventArgs e)
        {
            ArduinoSerialPort.Write(ArduinoSendText.Text+'\n');
            ArduinoSendText.Text = "";
        }

        private void SDMC1SendButton_Click(object sender, EventArgs e)
        {
            SDMC1SerialPort.Write(SDMC1SendText.Text + '\r');
            SDMC1SendText.Text = "";
        }

        private void SaveSelectionButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileLocationText.Text = saveFileDialog1.FileName;
            try
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                for(int i = 0; i<measurementData.Count; i++)
                {
                    sw.WriteLine(measurementData[i]);
                }
                sw.Close();
            }
            catch (Exception error)
            {
                MessageText.Text = error.Message;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void SDMC1SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                String reply = SDMC1SerialPort.ReadExisting();
                SDMC1ReadText.Invoke(new MethodInvoker(delegate {
                    SDMC1ReadText.Text = SDMC1ReadText.Text + reply;
                }));
            }
            catch (Exception error)
            {
                MessageText.Invoke(new MethodInvoker(delegate
                {
                    MessageText.Text = error.Message;
                }));
            }
        }

        private void ArduinoSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                String reply = ArduinoSerialPort.ReadExisting();
                ArduinoReadText.Invoke(new MethodInvoker(delegate
                {
                    ArduinoReadText.Text = ArduinoReadText.Text + reply;
                }));
            }
            catch (Exception error)
            {
                MessageText.Invoke(new MethodInvoker(delegate
                {
                    MessageText.Text = error.Message;
                }));
            }
        }

        private void HomeSDMC1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int StartPosition = -1;
            int EndPosition = -1;
            try
            {
                SDMC1Message += SDMC1SerialPort.ReadExisting();
                if (SDMC1Message.Contains("\r"))
                {
                    //if it says it just moved, check the limit switches
                    if(SDMC1Message.Contains("-1"))
                    {
                        SDMC1Message = "";
                        SDMC1SerialPort.Write("]\r");
                    }
                    //if it reports the limit switch, check if it's home, if not move
                    else if(SDMC1Message.Contains("]"))
                    {
                        // get only the numeric part of the input by starting at the first character, looking for the first digit, then looking for the first non-digit after that
                        for (int i = 0; i < SDMC1Message.Length; i++)
                        {
                            if (Char.IsDigit(SDMC1Message[i]))
                            {
                                StartPosition = i - 1;
                                break;
                            }
                        }
                        for (int i = StartPosition+1; i<SDMC1Message.Length; i++)
                        {
                            if (!Char.IsDigit(SDMC1Message[i]))
                            {
                                EndPosition = i - 1;
                                break;
                            }
                        }
                        if (StartPosition > 0 && EndPosition > 0)
                        {
                            SDMC1Message = SDMC1Message.Substring(StartPosition, EndPosition);
                        }
                        else if (StartPosition > 0)
                        {
                            SDMC1Message = SDMC1Message.Substring(StartPosition);
                        }

                        
                        Boolean home = (Convert.ToInt32(SDMC1Message) & 128) > 0;
                        if (!home && moves < homeDistance)
                        {
                            SDMC1SerialPort.Write("-1\r");
                            moves++;
                        }
                        else
                        {
                            if (moves > homeDistance - 1)
                            {
                                MessageText.Invoke(new MethodInvoker(delegate {
                                    MessageText.Text = "Over allowed home distance";
                                }));
                            }
                            SDMC1SerialPort.DataReceived -= HomeSDMC1_DataReceived;
                            SDMC1SerialPort.DataReceived += SDMC1SerialPort_DataReceived;
                            HomeButton.Invoke(new MethodInvoker(delegate {
                                HomeButton.Enabled = true;
                            }));
                            ScanButton.Invoke(new MethodInvoker(delegate {
                                ScanButton.Enabled = true;
                            }));
                            SDMC1SerialPort.Write("O0\r");
                        }
                        SDMC1Message = "";
                    }
                }
            }
            catch (Exception error)
            {
                SDMC1SerialPort.DataReceived -= HomeSDMC1_DataReceived;
                SDMC1SerialPort.DataReceived += SDMC1SerialPort_DataReceived;
                MessageText.Invoke(new MethodInvoker(delegate {
                    MessageText.Text = error.Message + " home 2 " + StartPosition + ", " + EndPosition;
                }));
                SDMC1Message = "";
            }
        }

        private void ScanSDMC1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SDMC1Message += SDMC1SerialPort.ReadExisting();
                SDMC1ReadText.Invoke(new MethodInvoker(delegate
                {
                    SDMC1ReadText.Text += SDMC1Message;
                }));
                if (SDMC1Message.Contains("\r"))
                {
                    ArduinoSerialPort.WriteLine("read");
                    SDMC1Message = "";
                }
            }
            catch (Exception error)
            {
                MessageText.Invoke(new MethodInvoker(delegate
                {
                    MessageText.Text = error.Message;
                }));
                SDMC1Message = "";
            }
        }

        private void ScanArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                ArduinoMessage += ArduinoSerialPort.ReadExisting();
                ArduinoReadText.Invoke(new MethodInvoker(delegate
                {
                    ArduinoReadText.Text += ArduinoMessage;
                }));
                if (ArduinoMessage.Contains("\n"))
                {
                    measurementData.Add(Convert.ToInt32(ArduinoMessage));
                    ArduinoMessage = "";
                    ScanProgress.Invoke(new MethodInvoker(delegate
                    {
                        ScanProgress.Value = 1 / scanLength;
                    }));
                    if (measurementData.Count < scanLength)
                    {
                        SDMC1SerialPort.Write("+1\r");
                    }
                    else
                    {
                        SDMC1SerialPort.DataReceived -= ScanSDMC1_DataReceived;
                        SDMC1SerialPort.DataReceived += SDMC1SerialPort_DataReceived;
                        ArduinoSerialPort.DataReceived -= ScanArduino_DataReceived;
                        ArduinoSerialPort.DataReceived += ArduinoSerialPort_DataReceived;
                        SDMC1SerialPort.Write("R0\r");
                        HomeButton.Invoke(new MethodInvoker(delegate
                        {
                            HomeButton.Enabled = true;
                        }));
                        ScanButton.Invoke(new MethodInvoker(delegate
                        {
                            ScanButton.Enabled = true;
                        }));
                    }
                    moves++;
                }
            }
            catch (Exception error)
            {
                MessageText.Invoke(new MethodInvoker(delegate
                {
                    MessageText.Text = error.Message;
                }));
                ArduinoMessage = "";
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            moves = 0;
            SDMC1SerialPort.DataReceived -= SDMC1SerialPort_DataReceived;
            SDMC1SerialPort.DataReceived += HomeSDMC1_DataReceived;
            HomeButton.Enabled = false;
            ScanButton.Enabled = false;
            SDMC1Message = "";
            ArduinoMessage = "";
            SDMC1SerialPort.Write("]\r");
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            moves = 0;
            measurementData = new List<int>();
            SDMC1SerialPort.DataReceived -= SDMC1SerialPort_DataReceived;
            SDMC1SerialPort.DataReceived += ScanSDMC1_DataReceived;
            ArduinoSerialPort.DataReceived -= ArduinoSerialPort_DataReceived;
            ArduinoSerialPort.DataReceived += ScanArduino_DataReceived;
            HomeButton.Enabled = false;
            ScanButton.Enabled = false;
            SDMC1Message = "";
            ArduinoMessage = "";
            SDMC1SerialPort.Write("R0\r");
            SDMC1SerialPort.Write(" \r");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageText.Text = "";
        }
    }
}
