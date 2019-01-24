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

namespace SMARTDRIVER
{
    public partial class Form1 : Form
    {
        int lastportName;
        String DataReceive = "";
        int DesiredVal = 0;

        byte[] SendArray = new byte[3];
        int[] DesiredArray = new int[50];
        float[] DataReceiveArray = new float[50];

        float Kp = 0;
        float Ki = 0;
        float Kd = 0;

        float Kp2 = 0;
        float Ki2 = 0;
        float Kd2 = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portName = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(portName);

            for(int i = 0; i < 127; i++)
            {
                comboBoxAddressUART.Items.Add(i.ToString());
            }

            if (portName.Length > 0)
            {
                comboBoxComPort.SelectedIndex = 0;
            }
            comboBoxBaudrate.SelectedIndex = 3;
            comboBoxPIDMode.Text = "PID SPEED";
            comboBoxController.SelectedIndex = 0;

            Kp = float.Parse("0.6");
            Ki = float.Parse("0.0");
            Kd = float.Parse("0.06");

            Kp2 = float.Parse("5");
            Ki2 = float.Parse("0.0");
            Kd2 = float.Parse("0.06");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortDevice.IsOpen)
            {
                serialPortDevice.Close();
            }
        }
        private void Connect()  // Connect to com port
        {  
            if (serialPortDevice.IsOpen)
            {
                MessageBox.Show("Com Port Opened!", "Notification");
            }
            else
            {
                if (comboBoxComPort.Text == "")
                {
                    MessageBox.Show("Select Com Port!", "Notification");
                } else
                {
                    try
                    {
                        buttonUSART.Text = "Disconnect";
                        serialPortDevice.PortName = comboBoxComPort.Text;
                        serialPortDevice.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);
                        serialPortDevice.Open();
                        timer.Enabled = true;
                        buttonUP.Enabled = true;
                        button1.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Can Not Open Com Port!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        buttonUSART.Text = "Connect";
                    }                      
                }
            }
        }
        private void Disconnect()   // Disconnect to com port
        {
            if (serialPortDevice.IsOpen)
            {
                buttonUSART.Text = "Connect";
                serialPortDevice.Close();
                timer.Enabled = false;
                buttonUP.Enabled = false;
                button1.Enabled = false;
            }        
        }
        private void buttonUSART_Click(object sender, EventArgs e)
        {
            if(buttonUSART.Text == "Connect")
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
            if (buttonUSART.Text != "Connect")
            {
                buttonUSART.ForeColor = Color.Red;
                comboBoxComPort.Enabled = false;
                comboBoxBaudrate.Enabled = false;
            }
            else
            {
                buttonUSART.ForeColor = Color.Blue;
                comboBoxComPort.Enabled = true;
                comboBoxBaudrate.Enabled = true;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if(!serialPortDevice.IsOpen)
            {
                string[] portName = SerialPort.GetPortNames();
                if (portName.Length != lastportName)
                {
                    comboBoxComPort.Items.Clear();
                    comboBoxComPort.Items.AddRange(portName);
                    lastportName = portName.Length;
                    comboBoxComPort.Text = "";
                }
                else
                {
                    //
                }
            }

            for (int i = 0; i < 49; i++)
            {
                DesiredArray[i] = DesiredArray[i + 1];
            }

            if(comboBoxPIDMode.Text == "PID SPEED")
            {
                if (DesiredVal > 0) DesiredArray[49] = DesiredVal;
                else DesiredArray[49] = -DesiredVal;
            }
            else
            {
                DesiredArray[49] = DesiredVal;
            }
            
            for (int i = 0; i < 49; i++)
            {
                DataReceiveArray[i] = DataReceiveArray[i + 1];
            }
            if(DataReceive != "")
            {
                DataReceiveArray[49] = float.Parse(DataReceive);
            }         

            chartSpeed.Series["Current"].Points.Clear();
            chartSpeed.Series["Desired"].Points.Clear();
            for (int i = 1; i < 50; i++)
            {
                chartSpeed.Series["Current"].Points.AddXY(i, DataReceiveArray[i]);
                chartSpeed.Series["Desired"].Points.AddXY(i, DesiredArray[i]);
            }
        }

        private void UART()   // Disconnect to com port
        {
            labelBaudrateUART.Visible = true;
            labelAddressUART.Visible = true;
            comboBoxBaudrateUART.Visible = true;
            comboBoxAddressUART.Visible = true;
        }
        private void DIRPWM()
        {
            labelBaudrateUART.Visible = false;
            labelAddressUART.Visible = false;
            comboBoxBaudrateUART.Visible = false;
            comboBoxAddressUART.Visible = false;
        }
        private void comboBoxController_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxController.Text == "UART")
            {
                UART();
            }
            else
            {
                DIRPWM();
            }
        }

        private void serialPortDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {                    
            try
            {
                DataReceive = serialPortDevice.ReadLine();               
            }
            catch
            {
                Console.WriteLine("\nError reading bytes! ");
            }
        }

        private void comboBoxPIDMode_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxPIDMode.Text == "PID SPEED")
            {
                labelSet.Text = "Velocity";
                chartSpeed.ChartAreas["ChartArea1"].AxisY.Title = "Velocity";

                SendArray[0] = 2;
                SendArray[1] = 1;
                SendArray[2] = 1;

                textBoxKP.Text = Kp.ToString();
                textBoxKI.Text = Ki.ToString();
                textBoxKD.Text = Kd.ToString();
            }
            else
            {
                labelSet.Text = "Position";
                chartSpeed.ChartAreas["ChartArea1"].AxisY.Title = "Position";

                SendArray[0] = 2;
                SendArray[1] = 2;
                SendArray[2] = 2;

                textBoxKP.Text = Kp2.ToString();
                textBoxKI.Text = Ki2.ToString();
                textBoxKD.Text = Kd2.ToString();
            }
            if(serialPortDevice.IsOpen)
            {
                serialPortDevice.Write(SendArray, 0, 3);
            }
            DesiredVal = 0;
            for (int i = 1; i < 50; i++)
            {
                DataReceiveArray[i] = 0;
                DesiredArray[i] = 0;
            }
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            if (textBoxSet.Text != "")
            {
                DesiredVal = int.Parse(textBoxSet.Text);
            }
            if(DesiredVal > 0)
            {
                SendArray[0] = 0;
                SendArray[1] = Convert.ToByte(DesiredVal / 100);
                SendArray[2] = Convert.ToByte(DesiredVal % 100);
            }
            else
            {
                SendArray[0] = 1;
                SendArray[1] = Convert.ToByte(-DesiredVal / 100);
                SendArray[2] = Convert.ToByte(-DesiredVal % 100);
            }
            
            serialPortDevice.Write(SendArray, 0, 3);
        }

        private void chartSpeed_DoubleClick(object sender, EventArgs e)
        {
            if(serialPortDevice.IsOpen)
            {
                if (timer.Enabled == true)
                {
                    timer.Enabled = false;
                }
                else
                {
                    timer.Enabled = true;
                }
            }           
        }

        private void textBoxKP_DoubleClick(object sender, EventArgs e)
        {         
            if (textBoxKP.Text != "")
            {
                if(comboBoxPIDMode.Text == "PID SPEED")
                {
                    Kp = float.Parse(textBoxKP.Text);
                } else
                {
                    Kp2 = float.Parse(textBoxKP.Text);
                }

                int textBoxNum = Convert.ToInt32(float.Parse(textBoxKP.Text) * 100);
 
                SendArray[0] = 3;
                SendArray[1] = Convert.ToByte(textBoxNum / 100);
                SendArray[2] = Convert.ToByte(textBoxNum % 100);
                serialPortDevice.Write(SendArray, 0, 3);
            }
        }

        private void textBoxKI_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxKI.Text != "")
            {
                if (comboBoxPIDMode.Text == "PID SPEED")
                {
                    Ki = float.Parse(textBoxKI.Text);
                }
                else
                {
                    Ki2 = float.Parse(textBoxKI.Text);
                }

                int textBoxNum = Convert.ToInt32(float.Parse(textBoxKI.Text) * 100);

                SendArray[0] = 4;
                SendArray[1] = Convert.ToByte(textBoxNum / 100);
                SendArray[2] = Convert.ToByte(textBoxNum % 100);
                serialPortDevice.Write(SendArray, 0, 3);
            }
        }

        private void textBoxKD_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxKD.Text != "")
            {
                if (comboBoxPIDMode.Text == "PID SPEED")
                {
                    Kd = float.Parse(textBoxKD.Text);
                }
                else
                {
                    Kd2 = float.Parse(textBoxKD.Text);
                }

                int textBoxNum = Convert.ToInt32(float.Parse(textBoxKD.Text) * 100);

                SendArray[0] = 5;
                SendArray[1] = Convert.ToByte(textBoxNum / 100);
                SendArray[2] = Convert.ToByte(textBoxNum % 100);
                serialPortDevice.Write(SendArray, 0, 3);
            }
        }
    }
}
