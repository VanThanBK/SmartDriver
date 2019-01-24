namespace SMARTDRIVER
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUSART = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chartSpeed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxController = new System.Windows.Forms.ComboBox();
            this.comboBoxPIDMode = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUP = new System.Windows.Forms.Button();
            this.labelSet = new System.Windows.Forms.Label();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.comboBoxAddressUART = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudrateUART = new System.Windows.Forms.ComboBox();
            this.labelAddressUART = new System.Windows.Forms.Label();
            this.labelBaudrateUART = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKD = new System.Windows.Forms.TextBox();
            this.textBoxKI = new System.Windows.Forms.TextBox();
            this.textBoxKP = new System.Windows.Forms.TextBox();
            this.serialPortDevice = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUSART);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxBaudrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxComPort);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver";
            // 
            // buttonUSART
            // 
            this.buttonUSART.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUSART.ForeColor = System.Drawing.Color.Blue;
            this.buttonUSART.Location = new System.Drawing.Point(217, 32);
            this.buttonUSART.Name = "buttonUSART";
            this.buttonUSART.Size = new System.Drawing.Size(114, 31);
            this.buttonUSART.TabIndex = 4;
            this.buttonUSART.Text = "Connect";
            this.buttonUSART.UseVisualStyleBackColor = true;
            this.buttonUSART.Click += new System.EventHandler(this.buttonUSART_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baudrate";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "250000"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(90, 51);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaudrate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(90, 21);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxComPort.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chartSpeed
            // 
            chartArea1.AxisX.Title = "Time(ms)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Red;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Title = "Velocity";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.MediumBlue;
            chartArea1.Name = "ChartArea1";
            this.chartSpeed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSpeed.Legends.Add(legend1);
            this.chartSpeed.Location = new System.Drawing.Point(-7, 94);
            this.chartSpeed.Name = "chartSpeed";
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Navy;
            series1.Legend = "Legend1";
            series1.Name = "Desired";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Current";
            this.chartSpeed.Series.Add(series1);
            this.chartSpeed.Series.Add(series2);
            this.chartSpeed.Size = new System.Drawing.Size(564, 315);
            this.chartSpeed.TabIndex = 1;
            this.chartSpeed.Text = "chartSpeed";
            this.chartSpeed.DoubleClick += new System.EventHandler(this.chartSpeed_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxController);
            this.groupBox2.Controls.Add(this.comboBoxPIDMode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(352, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(274, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set\r\nValue";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Controller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PID Mode";
            // 
            // comboBoxController
            // 
            this.comboBoxController.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxController.FormattingEnabled = true;
            this.comboBoxController.Items.AddRange(new object[] {
            "UART",
            "DIR-PWM"});
            this.comboBoxController.Location = new System.Drawing.Point(95, 51);
            this.comboBoxController.Name = "comboBoxController";
            this.comboBoxController.Size = new System.Drawing.Size(170, 24);
            this.comboBoxController.TabIndex = 1;
            this.comboBoxController.TextChanged += new System.EventHandler(this.comboBoxController_TextChanged);
            // 
            // comboBoxPIDMode
            // 
            this.comboBoxPIDMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPIDMode.FormattingEnabled = true;
            this.comboBoxPIDMode.Items.AddRange(new object[] {
            "PID SPEED",
            "PID POSITION"});
            this.comboBoxPIDMode.Location = new System.Drawing.Point(95, 21);
            this.comboBoxPIDMode.Name = "comboBoxPIDMode";
            this.comboBoxPIDMode.Size = new System.Drawing.Size(170, 24);
            this.comboBoxPIDMode.TabIndex = 0;
            this.comboBoxPIDMode.TextChanged += new System.EventHandler(this.comboBoxPIDMode_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUP);
            this.groupBox3.Controls.Add(this.labelSet);
            this.groupBox3.Controls.Add(this.textBoxSet);
            this.groupBox3.Controls.Add(this.comboBoxAddressUART);
            this.groupBox3.Controls.Add(this.comboBoxBaudrateUART);
            this.groupBox3.Controls.Add(this.labelAddressUART);
            this.groupBox3.Controls.Add(this.labelBaudrateUART);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxKD);
            this.groupBox3.Controls.Add(this.textBoxKI);
            this.groupBox3.Controls.Add(this.textBoxKP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(563, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 315);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // buttonUP
            // 
            this.buttonUP.Enabled = false;
            this.buttonUP.Location = new System.Drawing.Point(148, 176);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(75, 32);
            this.buttonUP.TabIndex = 12;
            this.buttonUP.Text = "UP";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Location = new System.Drawing.Point(6, 159);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(64, 20);
            this.labelSet.TabIndex = 11;
            this.labelSet.Text = "Velocity";
            // 
            // textBoxSet
            // 
            this.textBoxSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSet.Location = new System.Drawing.Point(10, 182);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.Size = new System.Drawing.Size(120, 22);
            this.textBoxSet.TabIndex = 10;
            // 
            // comboBoxAddressUART
            // 
            this.comboBoxAddressUART.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAddressUART.FormattingEnabled = true;
            this.comboBoxAddressUART.Location = new System.Drawing.Point(133, 285);
            this.comboBoxAddressUART.Name = "comboBoxAddressUART";
            this.comboBoxAddressUART.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAddressUART.TabIndex = 9;
            // 
            // comboBoxBaudrateUART
            // 
            this.comboBoxBaudrateUART.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudrateUART.FormattingEnabled = true;
            this.comboBoxBaudrateUART.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "250000"});
            this.comboBoxBaudrateUART.Location = new System.Drawing.Point(6, 285);
            this.comboBoxBaudrateUART.Name = "comboBoxBaudrateUART";
            this.comboBoxBaudrateUART.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaudrateUART.TabIndex = 8;
            // 
            // labelAddressUART
            // 
            this.labelAddressUART.AutoSize = true;
            this.labelAddressUART.Location = new System.Drawing.Point(129, 260);
            this.labelAddressUART.Name = "labelAddressUART";
            this.labelAddressUART.Size = new System.Drawing.Size(68, 20);
            this.labelAddressUART.TabIndex = 7;
            this.labelAddressUART.Text = "Address";
            // 
            // labelBaudrateUART
            // 
            this.labelBaudrateUART.AutoSize = true;
            this.labelBaudrateUART.Location = new System.Drawing.Point(6, 260);
            this.labelBaudrateUART.Name = "labelBaudrateUART";
            this.labelBaudrateUART.Size = new System.Drawing.Size(75, 20);
            this.labelBaudrateUART.TabIndex = 6;
            this.labelBaudrateUART.Text = "Baudrate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "KD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "KI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "KP";
            // 
            // textBoxKD
            // 
            this.textBoxKD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKD.Location = new System.Drawing.Point(41, 81);
            this.textBoxKD.Name = "textBoxKD";
            this.textBoxKD.Size = new System.Drawing.Size(120, 22);
            this.textBoxKD.TabIndex = 2;
            this.textBoxKD.Text = "0.06";
            this.textBoxKD.DoubleClick += new System.EventHandler(this.textBoxKD_DoubleClick);
            // 
            // textBoxKI
            // 
            this.textBoxKI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKI.Location = new System.Drawing.Point(41, 53);
            this.textBoxKI.Name = "textBoxKI";
            this.textBoxKI.Size = new System.Drawing.Size(120, 22);
            this.textBoxKI.TabIndex = 1;
            this.textBoxKI.Text = "0";
            this.textBoxKI.DoubleClick += new System.EventHandler(this.textBoxKI_DoubleClick);
            // 
            // textBoxKP
            // 
            this.textBoxKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKP.Location = new System.Drawing.Point(41, 25);
            this.textBoxKP.Name = "textBoxKP";
            this.textBoxKP.Size = new System.Drawing.Size(120, 22);
            this.textBoxKP.TabIndex = 0;
            this.textBoxKP.Text = "0.6";
            this.textBoxKP.DoubleClick += new System.EventHandler(this.textBoxKP_DoubleClick);
            // 
            // serialPortDevice
            // 
            this.serialPortDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortDevice_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(835, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartSpeed);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SMARTDRIVER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Button buttonUSART;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxController;
        private System.Windows.Forms.ComboBox comboBoxPIDMode;
        private System.IO.Ports.SerialPort serialPortDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKD;
        private System.Windows.Forms.TextBox textBoxKI;
        private System.Windows.Forms.TextBox textBoxKP;
        private System.Windows.Forms.ComboBox comboBoxAddressUART;
        private System.Windows.Forms.ComboBox comboBoxBaudrateUART;
        private System.Windows.Forms.Label labelAddressUART;
        private System.Windows.Forms.Label labelBaudrateUART;
        private System.Windows.Forms.Label labelSet;
        private System.Windows.Forms.TextBox textBoxSet;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Timer timer;
    }
}

