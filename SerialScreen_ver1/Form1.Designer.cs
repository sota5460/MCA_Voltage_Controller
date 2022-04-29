
using System;
using System.IO.Ports;

namespace SerialScreen_ver1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(30D, "40,50,0,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(25D, "20,21,0,0");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button_close = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart_MCA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_MCA_ON = new System.Windows.Forms.Button();
            this.button_MCA_OFF = new System.Windows.Forms.Button();
            this.button_mca_clear = new System.Windows.Forms.Button();
            this.btn_rx_buf_clear = new System.Windows.Forms.Button();
            this.button_csv_out = new System.Windows.Forms.Button();
            this.button_autoopen = new System.Windows.Forms.Button();
            this.button_adcStart = new System.Windows.Forms.Button();
            this.button_adcStop = new System.Windows.Forms.Button();
            this.label_peak_mca = new System.Windows.Forms.Label();
            this.label_total_count_mca = new System.Windows.Forms.Label();
            this.label_TotalCountingTime = new System.Windows.Forms.Label();
            this.timer_stopwatch = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_VoltageOut = new System.Windows.Forms.TextBox();
            this.textBox_voltageDisaplay = new System.Windows.Forms.TextBox();
            this.button_100down = new System.Windows.Forms.Button();
            this.button_100up = new System.Windows.Forms.Button();
            this.button_voltageOFF = new System.Windows.Forms.Button();
            this.button_VoltageON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_pulse_num = new System.Windows.Forms.TextBox();
            this.label_adc_sample_num = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.clear_thresh_btn = new System.Windows.Forms.Button();
            this.label_adc_threshold = new System.Windows.Forms.Label();
            this.clear_one_samplenum_btn = new System.Windows.Forms.Button();
            this.label_adc_threshold_dis = new System.Windows.Forms.Label();
            this.button_adcsetting1 = new System.Windows.Forms.Button();
            this.button_adcsetting2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_com = new System.Windows.Forms.ToolStripLabel();
            this.timer_connection_check = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MCA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 50000;
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.ReceivedBytesThreshold = 200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_close.Location = new System.Drawing.Point(6, 69);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(112, 32);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "接続を解除";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 7);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(670, 518);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Interval_function);
            // 
            // chart_MCA
            // 
            this.chart_MCA.BackColor = System.Drawing.Color.LightGray;
            this.chart_MCA.BorderlineColor = System.Drawing.Color.Black;
            this.chart_MCA.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart_MCA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_MCA.Legends.Add(legend2);
            this.chart_MCA.Location = new System.Drawing.Point(697, 7);
            this.chart_MCA.Name = "chart_MCA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_MCA.Series.Add(series2);
            this.chart_MCA.Size = new System.Drawing.Size(716, 518);
            this.chart_MCA.TabIndex = 26;
            this.chart_MCA.Text = "chart2";
            // 
            // button_MCA_ON
            // 
            this.button_MCA_ON.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MCA_ON.ForeColor = System.Drawing.Color.Red;
            this.button_MCA_ON.Location = new System.Drawing.Point(126, 29);
            this.button_MCA_ON.Name = "button_MCA_ON";
            this.button_MCA_ON.Size = new System.Drawing.Size(110, 35);
            this.button_MCA_ON.TabIndex = 29;
            this.button_MCA_ON.Text = "MCA ON";
            this.button_MCA_ON.UseVisualStyleBackColor = true;
            this.button_MCA_ON.Click += new System.EventHandler(this.button_MCA_ON_Click);
            // 
            // button_MCA_OFF
            // 
            this.button_MCA_OFF.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MCA_OFF.ForeColor = System.Drawing.Color.Blue;
            this.button_MCA_OFF.Location = new System.Drawing.Point(126, 70);
            this.button_MCA_OFF.Name = "button_MCA_OFF";
            this.button_MCA_OFF.Size = new System.Drawing.Size(110, 35);
            this.button_MCA_OFF.TabIndex = 30;
            this.button_MCA_OFF.Text = "MCA OFF";
            this.button_MCA_OFF.UseVisualStyleBackColor = true;
            this.button_MCA_OFF.Click += new System.EventHandler(this.button_MCA_OFF_Click);
            // 
            // button_mca_clear
            // 
            this.button_mca_clear.Location = new System.Drawing.Point(126, 115);
            this.button_mca_clear.Name = "button_mca_clear";
            this.button_mca_clear.Size = new System.Drawing.Size(110, 35);
            this.button_mca_clear.TabIndex = 31;
            this.button_mca_clear.Text = "MCAクリア";
            this.button_mca_clear.UseVisualStyleBackColor = true;
            this.button_mca_clear.Click += new System.EventHandler(this.button_mca_clear_Click);
            // 
            // btn_rx_buf_clear
            // 
            this.btn_rx_buf_clear.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_rx_buf_clear.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_rx_buf_clear.Location = new System.Drawing.Point(6, 110);
            this.btn_rx_buf_clear.Name = "btn_rx_buf_clear";
            this.btn_rx_buf_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_rx_buf_clear.TabIndex = 32;
            this.btn_rx_buf_clear.Text = "受信バッファ\r\nクリア";
            this.btn_rx_buf_clear.UseVisualStyleBackColor = true;
            this.btn_rx_buf_clear.Click += new System.EventHandler(this.btn_rx_buf_clear_Click);
            // 
            // button_csv_out
            // 
            this.button_csv_out.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_csv_out.ForeColor = System.Drawing.Color.Purple;
            this.button_csv_out.Location = new System.Drawing.Point(6, 151);
            this.button_csv_out.Name = "button_csv_out";
            this.button_csv_out.Size = new System.Drawing.Size(112, 34);
            this.button_csv_out.TabIndex = 35;
            this.button_csv_out.Text = "MCAをcsv出力";
            this.button_csv_out.UseVisualStyleBackColor = true;
            this.button_csv_out.Click += new System.EventHandler(this.button_csv_out_Click);
            // 
            // button_autoopen
            // 
            this.button_autoopen.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_autoopen.Location = new System.Drawing.Point(6, 29);
            this.button_autoopen.Name = "button_autoopen";
            this.button_autoopen.Size = new System.Drawing.Size(112, 34);
            this.button_autoopen.TabIndex = 41;
            this.button_autoopen.Text = "STM32と接続";
            this.button_autoopen.UseVisualStyleBackColor = true;
            this.button_autoopen.Click += new System.EventHandler(this.button_autoopen_Click);
            // 
            // button_adcStart
            // 
            this.button_adcStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_adcStart.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcStart.Location = new System.Drawing.Point(6, 30);
            this.button_adcStart.Name = "button_adcStart";
            this.button_adcStart.Size = new System.Drawing.Size(110, 35);
            this.button_adcStart.TabIndex = 42;
            this.button_adcStart.Text = "ADCスタート";
            this.button_adcStart.UseVisualStyleBackColor = false;
            this.button_adcStart.Click += new System.EventHandler(this.button_adcStart_Click);
            // 
            // button_adcStop
            // 
            this.button_adcStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_adcStop.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcStop.Location = new System.Drawing.Point(6, 70);
            this.button_adcStop.Name = "button_adcStop";
            this.button_adcStop.Size = new System.Drawing.Size(110, 35);
            this.button_adcStop.TabIndex = 43;
            this.button_adcStop.Text = "ADCストップ";
            this.button_adcStop.UseVisualStyleBackColor = false;
            this.button_adcStop.Click += new System.EventHandler(this.button_adcStop_Click);
            // 
            // label_peak_mca
            // 
            this.label_peak_mca.AutoSize = true;
            this.label_peak_mca.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_peak_mca.Location = new System.Drawing.Point(6, 35);
            this.label_peak_mca.Name = "label_peak_mca";
            this.label_peak_mca.Size = new System.Drawing.Size(80, 16);
            this.label_peak_mca.TabIndex = 46;
            this.label_peak_mca.Text = "peak_mca";
            // 
            // label_total_count_mca
            // 
            this.label_total_count_mca.AutoSize = true;
            this.label_total_count_mca.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_total_count_mca.Location = new System.Drawing.Point(6, 100);
            this.label_total_count_mca.Name = "label_total_count_mca";
            this.label_total_count_mca.Size = new System.Drawing.Size(93, 16);
            this.label_total_count_mca.TabIndex = 47;
            this.label_total_count_mca.Text = "TotalCount";
            // 
            // label_TotalCountingTime
            // 
            this.label_TotalCountingTime.AutoSize = true;
            this.label_TotalCountingTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_TotalCountingTime.Location = new System.Drawing.Point(6, 159);
            this.label_TotalCountingTime.Name = "label_TotalCountingTime";
            this.label_TotalCountingTime.Size = new System.Drawing.Size(83, 16);
            this.label_TotalCountingTime.TabIndex = 48;
            this.label_TotalCountingTime.Text = "TotalTime";
            // 
            // timer_stopwatch
            // 
            this.timer_stopwatch.Interval = 1000;
            this.timer_stopwatch.Tick += new System.EventHandler(this.timer_stopwatch_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 14);
            this.label1.TabIndex = 49;
            this.label1.Text = "-CountingTime-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "-TotalCount-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 51;
            this.label3.Text = "-Peak-\r\n";
            // 
            // textBox_VoltageOut
            // 
            this.textBox_VoltageOut.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_VoltageOut.Location = new System.Drawing.Point(8, 85);
            this.textBox_VoltageOut.Name = "textBox_VoltageOut";
            this.textBox_VoltageOut.Size = new System.Drawing.Size(140, 50);
            this.textBox_VoltageOut.TabIndex = 52;
            this.textBox_VoltageOut.Text = "0";
            // 
            // textBox_voltageDisaplay
            // 
            this.textBox_voltageDisaplay.BackColor = System.Drawing.Color.Black;
            this.textBox_voltageDisaplay.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_voltageDisaplay.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_voltageDisaplay.Location = new System.Drawing.Point(8, 29);
            this.textBox_voltageDisaplay.Name = "textBox_voltageDisaplay";
            this.textBox_voltageDisaplay.Size = new System.Drawing.Size(185, 50);
            this.textBox_voltageDisaplay.TabIndex = 55;
            this.textBox_voltageDisaplay.Text = "OFF";
            // 
            // button_100down
            // 
            this.button_100down.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_100down.ForeColor = System.Drawing.Color.Blue;
            this.button_100down.Location = new System.Drawing.Point(105, 141);
            this.button_100down.Name = "button_100down";
            this.button_100down.Size = new System.Drawing.Size(88, 41);
            this.button_100down.TabIndex = 54;
            this.button_100down.Text = "100▼";
            this.button_100down.UseVisualStyleBackColor = true;
            this.button_100down.Click += new System.EventHandler(this.button_100down_Click);
            // 
            // button_100up
            // 
            this.button_100up.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_100up.ForeColor = System.Drawing.Color.Red;
            this.button_100up.Location = new System.Drawing.Point(6, 141);
            this.button_100up.Name = "button_100up";
            this.button_100up.Size = new System.Drawing.Size(88, 41);
            this.button_100up.TabIndex = 53;
            this.button_100up.Text = "100▲";
            this.button_100up.UseVisualStyleBackColor = true;
            this.button_100up.Click += new System.EventHandler(this.button_100up_Click);
            // 
            // button_voltageOFF
            // 
            this.button_voltageOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_voltageOFF.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_voltageOFF.Location = new System.Drawing.Point(196, 104);
            this.button_voltageOFF.Name = "button_voltageOFF";
            this.button_voltageOFF.Size = new System.Drawing.Size(70, 61);
            this.button_voltageOFF.TabIndex = 57;
            this.button_voltageOFF.Text = "OFF";
            this.button_voltageOFF.UseVisualStyleBackColor = false;
            this.button_voltageOFF.Click += new System.EventHandler(this.button_voltageOFF_Click);
            // 
            // button_VoltageON
            // 
            this.button_VoltageON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_VoltageON.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_VoltageON.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_VoltageON.ForeColor = System.Drawing.Color.Black;
            this.button_VoltageON.Location = new System.Drawing.Point(196, 27);
            this.button_VoltageON.Name = "button_VoltageON";
            this.button_VoltageON.Size = new System.Drawing.Size(70, 61);
            this.button_VoltageON.TabIndex = 56;
            this.button_VoltageON.Text = "ON";
            this.button_VoltageON.UseVisualStyleBackColor = false;
            this.button_VoltageON.Click += new System.EventHandler(this.button_VoltageON_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_voltageDisaplay);
            this.groupBox1.Controls.Add(this.textBox_VoltageOut);
            this.groupBox1.Controls.Add(this.button_voltageOFF);
            this.groupBox1.Controls.Add(this.button_100down);
            this.groupBox1.Controls.Add(this.button_VoltageON);
            this.groupBox1.Controls.Add(this.button_100up);
            this.groupBox1.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(148, 531);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 191);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PMT電源";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(154, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 30);
            this.label4.TabIndex = 65;
            this.label4.Text = "V";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_autoopen);
            this.groupBox2.Controls.Add(this.button_close);
            this.groupBox2.Controls.Add(this.btn_rx_buf_clear);
            this.groupBox2.Controls.Add(this.button_csv_out);
            this.groupBox2.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(10, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 191);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接続";
            // 
            // textBox_pulse_num
            // 
            this.textBox_pulse_num.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_pulse_num.Location = new System.Drawing.Point(297, 123);
            this.textBox_pulse_num.Name = "textBox_pulse_num";
            this.textBox_pulse_num.Size = new System.Drawing.Size(119, 21);
            this.textBox_pulse_num.TabIndex = 32;
            this.textBox_pulse_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pulse_num_KeyPress);
            // 
            // label_adc_sample_num
            // 
            this.label_adc_sample_num.AutoSize = true;
            this.label_adc_sample_num.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_sample_num.Location = new System.Drawing.Point(295, 108);
            this.label_adc_sample_num.Name = "label_adc_sample_num";
            this.label_adc_sample_num.Size = new System.Drawing.Size(122, 12);
            this.label_adc_sample_num.TabIndex = 31;
            this.label_adc_sample_num.Text = "1パルスのサンプル数";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_threshold.Location = new System.Drawing.Point(297, 42);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(118, 21);
            this.textBox_threshold.TabIndex = 30;
            this.textBox_threshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_threshold_KeyPress);
            this.textBox_threshold.MouseLeave += new System.EventHandler(this.textBox_threshold_MouseLeave);
            this.textBox_threshold.MouseHover += new System.EventHandler(this.textBox_threshold_MouseHover);
            // 
            // clear_thresh_btn
            // 
            this.clear_thresh_btn.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear_thresh_btn.Location = new System.Drawing.Point(297, 64);
            this.clear_thresh_btn.Name = "clear_thresh_btn";
            this.clear_thresh_btn.Size = new System.Drawing.Size(42, 23);
            this.clear_thresh_btn.TabIndex = 41;
            this.clear_thresh_btn.Text = "clear";
            this.clear_thresh_btn.UseVisualStyleBackColor = true;
            this.clear_thresh_btn.Click += new System.EventHandler(this.clear_thresh_btn_Click);
            // 
            // label_adc_threshold
            // 
            this.label_adc_threshold.AutoSize = true;
            this.label_adc_threshold.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_threshold.Location = new System.Drawing.Point(318, 24);
            this.label_adc_threshold.Name = "label_adc_threshold";
            this.label_adc_threshold.Size = new System.Drawing.Size(69, 14);
            this.label_adc_threshold.TabIndex = 29;
            this.label_adc_threshold.Text = "ADC閾値";
            // 
            // clear_one_samplenum_btn
            // 
            this.clear_one_samplenum_btn.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear_one_samplenum_btn.Location = new System.Drawing.Point(297, 150);
            this.clear_one_samplenum_btn.Name = "clear_one_samplenum_btn";
            this.clear_one_samplenum_btn.Size = new System.Drawing.Size(42, 23);
            this.clear_one_samplenum_btn.TabIndex = 42;
            this.clear_one_samplenum_btn.Text = "clear";
            this.clear_one_samplenum_btn.UseVisualStyleBackColor = true;
            this.clear_one_samplenum_btn.Click += new System.EventHandler(this.clear_one_samplenum_btn_Click);
            // 
            // label_adc_threshold_dis
            // 
            this.label_adc_threshold_dis.AutoSize = true;
            this.label_adc_threshold_dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_adc_threshold_dis.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_threshold_dis.Location = new System.Drawing.Point(252, 37);
            this.label_adc_threshold_dis.Name = "label_adc_threshold_dis";
            this.label_adc_threshold_dis.Size = new System.Drawing.Size(109, 16);
            this.label_adc_threshold_dis.TabIndex = 40;
            this.label_adc_threshold_dis.Text = "0-4095を入力";
            // 
            // button_adcsetting1
            // 
            this.button_adcsetting1.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcsetting1.Location = new System.Drawing.Point(345, 64);
            this.button_adcsetting1.Name = "button_adcsetting1";
            this.button_adcsetting1.Size = new System.Drawing.Size(70, 23);
            this.button_adcsetting1.TabIndex = 43;
            this.button_adcsetting1.Text = "決定";
            this.button_adcsetting1.UseVisualStyleBackColor = true;
            this.button_adcsetting1.Click += new System.EventHandler(this.button_adcsetting1_Click);
            // 
            // button_adcsetting2
            // 
            this.button_adcsetting2.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcsetting2.Location = new System.Drawing.Point(345, 150);
            this.button_adcsetting2.Name = "button_adcsetting2";
            this.button_adcsetting2.Size = new System.Drawing.Size(70, 23);
            this.button_adcsetting2.TabIndex = 44;
            this.button_adcsetting2.Text = "決定";
            this.button_adcsetting2.UseVisualStyleBackColor = true;
            this.button_adcsetting2.Click += new System.EventHandler(this.button_adcsetting2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_adcStart);
            this.groupBox3.Controls.Add(this.button_adcStop);
            this.groupBox3.Controls.Add(this.button_adcsetting2);
            this.groupBox3.Controls.Add(this.button_MCA_ON);
            this.groupBox3.Controls.Add(this.label_adc_threshold_dis);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.clear_one_samplenum_btn);
            this.groupBox3.Controls.Add(this.button_MCA_OFF);
            this.groupBox3.Controls.Add(this.textBox_pulse_num);
            this.groupBox3.Controls.Add(this.label_adc_sample_num);
            this.groupBox3.Controls.Add(this.button_mca_clear);
            this.groupBox3.Controls.Add(this.label_adc_threshold);
            this.groupBox3.Controls.Add(this.textBox_threshold);
            this.groupBox3.Controls.Add(this.button_adcsetting1);
            this.groupBox3.Controls.Add(this.clear_thresh_btn);
            this.groupBox3.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(953, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 191);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MCA用コマンド";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label_peak_mca);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label_total_count_mca);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label_TotalCountingTime);
            this.groupBox4.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(1280, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 206);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MCA Info";
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox5.Location = new System.Drawing.Point(445, 532);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(265, 190);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ゲイン調整";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel_com});
            this.toolStrip1.Location = new System.Drawing.Point(0, 732);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1425, 25);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "接続状態";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_com
            // 
            this.toolStripLabel_com.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel_com.Name = "toolStripLabel_com";
            this.toolStripLabel_com.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel_com.Text = "未接続";
            // 
            // timer_connection_check
            // 
            this.timer_connection_check.Enabled = true;
            this.timer_connection_check.Interval = 5000;
            this.timer_connection_check.Tick += new System.EventHandler(this.timer_connection_check_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1425, 757);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart_MCA);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "STM32F4series MCAアプリケーション";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MCA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private SerialDataReceivedEventHandler serialPort1_DataReceived;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MCA;
        private System.Windows.Forms.Button button_MCA_ON;
        private System.Windows.Forms.Button button_MCA_OFF;
        private System.Windows.Forms.Button button_mca_clear;
        private System.Windows.Forms.Button btn_rx_buf_clear;
        private System.Windows.Forms.Button button_csv_out;
        private System.Windows.Forms.Button button_autoopen;
        private System.Windows.Forms.Button button_adcStart;
        private System.Windows.Forms.Button button_adcStop;
        private System.Windows.Forms.Label label_peak_mca;
        private System.Windows.Forms.Label label_total_count_mca;
        private System.Windows.Forms.Label label_TotalCountingTime;
        private System.Windows.Forms.Timer timer_stopwatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_VoltageOut;
        private System.Windows.Forms.TextBox textBox_voltageDisaplay;
        private System.Windows.Forms.Button button_100down;
        private System.Windows.Forms.Button button_100up;
        private System.Windows.Forms.Button button_voltageOFF;
        private System.Windows.Forms.Button button_VoltageON;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_pulse_num;
        private System.Windows.Forms.Label label_adc_sample_num;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Button clear_thresh_btn;
        private System.Windows.Forms.Label label_adc_threshold;
        private System.Windows.Forms.Button clear_one_samplenum_btn;
        private System.Windows.Forms.Label label_adc_threshold_dis;
        private System.Windows.Forms.Button button_adcsetting1;
        private System.Windows.Forms.Button button_adcsetting2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_com;
        private System.Windows.Forms.Timer timer_connection_check;
    }
}

