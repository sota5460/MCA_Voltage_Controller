
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
            this.clear_one_samplenum_btn = new System.Windows.Forms.Button();
            this.clear_thresh_btn = new System.Windows.Forms.Button();
            this.label_adc_threshold_dis = new System.Windows.Forms.Label();
            this.textBox_pulse_num = new System.Windows.Forms.TextBox();
            this.label_adc_sample_num = new System.Windows.Forms.Label();
            this.label_adc_threshold = new System.Windows.Forms.Label();
            this.textBox_threshold = new System.Windows.Forms.TextBox();
            this.button_autoopen = new System.Windows.Forms.Button();
            this.button_adcStart = new System.Windows.Forms.Button();
            this.button_adcStop = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_adcsetting2 = new System.Windows.Forms.Button();
            this.button_adcsetting1 = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MCA)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.button_close.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_close.Location = new System.Drawing.Point(21, 588);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(144, 42);
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
            this.chart1.Size = new System.Drawing.Size(743, 518);
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
            this.chart_MCA.Location = new System.Drawing.Point(770, 7);
            this.chart_MCA.Name = "chart_MCA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_MCA.Series.Add(series2);
            this.chart_MCA.Size = new System.Drawing.Size(643, 518);
            this.chart_MCA.TabIndex = 26;
            this.chart_MCA.Text = "chart2";
            // 
            // button_MCA_ON
            // 
            this.button_MCA_ON.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MCA_ON.ForeColor = System.Drawing.Color.Red;
            this.button_MCA_ON.Location = new System.Drawing.Point(687, 541);
            this.button_MCA_ON.Name = "button_MCA_ON";
            this.button_MCA_ON.Size = new System.Drawing.Size(111, 41);
            this.button_MCA_ON.TabIndex = 29;
            this.button_MCA_ON.Text = "MCA ON";
            this.button_MCA_ON.UseVisualStyleBackColor = true;
            this.button_MCA_ON.Click += new System.EventHandler(this.button_MCA_ON_Click);
            // 
            // button_MCA_OFF
            // 
            this.button_MCA_OFF.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MCA_OFF.ForeColor = System.Drawing.Color.Blue;
            this.button_MCA_OFF.Location = new System.Drawing.Point(687, 588);
            this.button_MCA_OFF.Name = "button_MCA_OFF";
            this.button_MCA_OFF.Size = new System.Drawing.Size(111, 42);
            this.button_MCA_OFF.TabIndex = 30;
            this.button_MCA_OFF.Text = "MCA OFF";
            this.button_MCA_OFF.UseVisualStyleBackColor = true;
            this.button_MCA_OFF.Click += new System.EventHandler(this.button_MCA_OFF_Click);
            // 
            // button_mca_clear
            // 
            this.button_mca_clear.Location = new System.Drawing.Point(1322, 455);
            this.button_mca_clear.Name = "button_mca_clear";
            this.button_mca_clear.Size = new System.Drawing.Size(75, 23);
            this.button_mca_clear.TabIndex = 31;
            this.button_mca_clear.Text = "MCAクリア";
            this.button_mca_clear.UseVisualStyleBackColor = true;
            this.button_mca_clear.Click += new System.EventHandler(this.button_mca_clear_Click);
            // 
            // btn_rx_buf_clear
            // 
            this.btn_rx_buf_clear.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_rx_buf_clear.Location = new System.Drawing.Point(577, 635);
            this.btn_rx_buf_clear.Name = "btn_rx_buf_clear";
            this.btn_rx_buf_clear.Size = new System.Drawing.Size(104, 34);
            this.btn_rx_buf_clear.TabIndex = 32;
            this.btn_rx_buf_clear.Text = "受信バッファをクリア";
            this.btn_rx_buf_clear.UseVisualStyleBackColor = true;
            this.btn_rx_buf_clear.Click += new System.EventHandler(this.btn_rx_buf_clear_Click);
            // 
            // button_csv_out
            // 
            this.button_csv_out.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_csv_out.ForeColor = System.Drawing.Color.Purple;
            this.button_csv_out.Location = new System.Drawing.Point(687, 636);
            this.button_csv_out.Name = "button_csv_out";
            this.button_csv_out.Size = new System.Drawing.Size(111, 34);
            this.button_csv_out.TabIndex = 35;
            this.button_csv_out.Text = "MCAをcsv出力";
            this.button_csv_out.UseVisualStyleBackColor = true;
            this.button_csv_out.Click += new System.EventHandler(this.button_csv_out_Click);
            // 
            // clear_one_samplenum_btn
            // 
            this.clear_one_samplenum_btn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear_one_samplenum_btn.Location = new System.Drawing.Point(392, 46);
            this.clear_one_samplenum_btn.Name = "clear_one_samplenum_btn";
            this.clear_one_samplenum_btn.Size = new System.Drawing.Size(56, 23);
            this.clear_one_samplenum_btn.TabIndex = 42;
            this.clear_one_samplenum_btn.Text = "clear";
            this.clear_one_samplenum_btn.UseVisualStyleBackColor = true;
            this.clear_one_samplenum_btn.Click += new System.EventHandler(this.clear_one_samplenum_btn_Click);
            // 
            // clear_thresh_btn
            // 
            this.clear_thresh_btn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear_thresh_btn.Location = new System.Drawing.Point(111, 47);
            this.clear_thresh_btn.Name = "clear_thresh_btn";
            this.clear_thresh_btn.Size = new System.Drawing.Size(56, 23);
            this.clear_thresh_btn.TabIndex = 41;
            this.clear_thresh_btn.Text = "clear";
            this.clear_thresh_btn.UseVisualStyleBackColor = true;
            this.clear_thresh_btn.Click += new System.EventHandler(this.clear_thresh_btn_Click);
            // 
            // label_adc_threshold_dis
            // 
            this.label_adc_threshold_dis.AutoSize = true;
            this.label_adc_threshold_dis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_adc_threshold_dis.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_threshold_dis.Location = new System.Drawing.Point(22, 73);
            this.label_adc_threshold_dis.Name = "label_adc_threshold_dis";
            this.label_adc_threshold_dis.Size = new System.Drawing.Size(109, 16);
            this.label_adc_threshold_dis.TabIndex = 40;
            this.label_adc_threshold_dis.Text = "0-4095を入力";
            // 
            // textBox_pulse_num
            // 
            this.textBox_pulse_num.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_pulse_num.Location = new System.Drawing.Point(286, 46);
            this.textBox_pulse_num.Name = "textBox_pulse_num";
            this.textBox_pulse_num.Size = new System.Drawing.Size(100, 23);
            this.textBox_pulse_num.TabIndex = 32;
            this.textBox_pulse_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pulse_num_KeyPress);
            // 
            // label_adc_sample_num
            // 
            this.label_adc_sample_num.AutoSize = true;
            this.label_adc_sample_num.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_sample_num.Location = new System.Drawing.Point(323, 24);
            this.label_adc_sample_num.Name = "label_adc_sample_num";
            this.label_adc_sample_num.Size = new System.Drawing.Size(160, 16);
            this.label_adc_sample_num.TabIndex = 31;
            this.label_adc_sample_num.Text = "トリガー後のサンプル数";
            // 
            // label_adc_threshold
            // 
            this.label_adc_threshold.AutoSize = true;
            this.label_adc_threshold.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_adc_threshold.Location = new System.Drawing.Point(75, 24);
            this.label_adc_threshold.Name = "label_adc_threshold";
            this.label_adc_threshold.Size = new System.Drawing.Size(92, 16);
            this.label_adc_threshold.TabIndex = 29;
            this.label_adc_threshold.Text = "ADCトリガー";
            // 
            // textBox_threshold
            // 
            this.textBox_threshold.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_threshold.Location = new System.Drawing.Point(6, 47);
            this.textBox_threshold.Name = "textBox_threshold";
            this.textBox_threshold.Size = new System.Drawing.Size(99, 23);
            this.textBox_threshold.TabIndex = 30;
            this.textBox_threshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_threshold_KeyPress);
            this.textBox_threshold.MouseLeave += new System.EventHandler(this.textBox_threshold_MouseLeave);
            this.textBox_threshold.MouseHover += new System.EventHandler(this.textBox_threshold_MouseHover);
            // 
            // button_autoopen
            // 
            this.button_autoopen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_autoopen.Location = new System.Drawing.Point(21, 539);
            this.button_autoopen.Name = "button_autoopen";
            this.button_autoopen.Size = new System.Drawing.Size(144, 43);
            this.button_autoopen.TabIndex = 41;
            this.button_autoopen.Text = "STM32と接続";
            this.button_autoopen.UseVisualStyleBackColor = true;
            this.button_autoopen.Click += new System.EventHandler(this.button_autoopen_Click);
            // 
            // button_adcStart
            // 
            this.button_adcStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_adcStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcStart.Location = new System.Drawing.Point(537, 539);
            this.button_adcStart.Name = "button_adcStart";
            this.button_adcStart.Size = new System.Drawing.Size(144, 42);
            this.button_adcStart.TabIndex = 42;
            this.button_adcStart.Text = "ADCスタート";
            this.button_adcStart.UseVisualStyleBackColor = false;
            this.button_adcStart.Click += new System.EventHandler(this.button_adcStart_Click);
            // 
            // button_adcStop
            // 
            this.button_adcStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_adcStop.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcStop.Location = new System.Drawing.Point(537, 587);
            this.button_adcStop.Name = "button_adcStop";
            this.button_adcStop.Size = new System.Drawing.Size(144, 42);
            this.button_adcStop.TabIndex = 43;
            this.button_adcStop.Text = "ADCストップ";
            this.button_adcStop.UseVisualStyleBackColor = false;
            this.button_adcStop.Click += new System.EventHandler(this.button_adcStop_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button_adcsetting2);
            this.panel3.Controls.Add(this.button_adcsetting1);
            this.panel3.Controls.Add(this.label_adc_threshold_dis);
            this.panel3.Controls.Add(this.clear_one_samplenum_btn);
            this.panel3.Controls.Add(this.label_adc_threshold);
            this.panel3.Controls.Add(this.clear_thresh_btn);
            this.panel3.Controls.Add(this.textBox_threshold);
            this.panel3.Controls.Add(this.label_adc_sample_num);
            this.panel3.Controls.Add(this.textBox_pulse_num);
            this.panel3.Location = new System.Drawing.Point(827, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 129);
            this.panel3.TabIndex = 45;
            // 
            // button_adcsetting2
            // 
            this.button_adcsetting2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcsetting2.Location = new System.Drawing.Point(454, 46);
            this.button_adcsetting2.Name = "button_adcsetting2";
            this.button_adcsetting2.Size = new System.Drawing.Size(56, 23);
            this.button_adcsetting2.TabIndex = 44;
            this.button_adcsetting2.Text = "決定";
            this.button_adcsetting2.UseVisualStyleBackColor = true;
            this.button_adcsetting2.Click += new System.EventHandler(this.button_adcsetting2_Click);
            // 
            // button_adcsetting1
            // 
            this.button_adcsetting1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_adcsetting1.Location = new System.Drawing.Point(173, 47);
            this.button_adcsetting1.Name = "button_adcsetting1";
            this.button_adcsetting1.Size = new System.Drawing.Size(56, 23);
            this.button_adcsetting1.TabIndex = 43;
            this.button_adcsetting1.Text = "決定";
            this.button_adcsetting1.UseVisualStyleBackColor = true;
            this.button_adcsetting1.Click += new System.EventHandler(this.button_adcsetting1_Click);
            // 
            // label_peak_mca
            // 
            this.label_peak_mca.AutoSize = true;
            this.label_peak_mca.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_peak_mca.Location = new System.Drawing.Point(1296, 152);
            this.label_peak_mca.Name = "label_peak_mca";
            this.label_peak_mca.Size = new System.Drawing.Size(97, 20);
            this.label_peak_mca.TabIndex = 46;
            this.label_peak_mca.Text = "peak_mca";
            // 
            // label_total_count_mca
            // 
            this.label_total_count_mca.AutoSize = true;
            this.label_total_count_mca.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_total_count_mca.Location = new System.Drawing.Point(1290, 249);
            this.label_total_count_mca.Name = "label_total_count_mca";
            this.label_total_count_mca.Size = new System.Drawing.Size(112, 20);
            this.label_total_count_mca.TabIndex = 47;
            this.label_total_count_mca.Text = "TotalCount";
            // 
            // label_TotalCountingTime
            // 
            this.label_TotalCountingTime.AutoSize = true;
            this.label_TotalCountingTime.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_TotalCountingTime.Location = new System.Drawing.Point(1300, 338);
            this.label_TotalCountingTime.Name = "label_TotalCountingTime";
            this.label_TotalCountingTime.Size = new System.Drawing.Size(102, 20);
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
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1300, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "計測時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(1289, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "総カウント数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1300, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "ピーク値";
            // 
            // textBox_VoltageOut
            // 
            this.textBox_VoltageOut.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_VoltageOut.Location = new System.Drawing.Point(205, 539);
            this.textBox_VoltageOut.Name = "textBox_VoltageOut";
            this.textBox_VoltageOut.Size = new System.Drawing.Size(185, 61);
            this.textBox_VoltageOut.TabIndex = 52;
            this.textBox_VoltageOut.Text = "0";
            // 
            // textBox_voltageDisaplay
            // 
            this.textBox_voltageDisaplay.BackColor = System.Drawing.Color.Black;
            this.textBox_voltageDisaplay.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_voltageDisaplay.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox_voltageDisaplay.Location = new System.Drawing.Point(204, 656);
            this.textBox_voltageDisaplay.Name = "textBox_voltageDisaplay";
            this.textBox_voltageDisaplay.Size = new System.Drawing.Size(185, 61);
            this.textBox_voltageDisaplay.TabIndex = 55;
            this.textBox_voltageDisaplay.Text = "OFF";
            // 
            // button_100down
            // 
            this.button_100down.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_100down.ForeColor = System.Drawing.Color.Blue;
            this.button_100down.Location = new System.Drawing.Point(301, 609);
            this.button_100down.Name = "button_100down";
            this.button_100down.Size = new System.Drawing.Size(88, 41);
            this.button_100down.TabIndex = 54;
            this.button_100down.Text = "100▼";
            this.button_100down.UseVisualStyleBackColor = true;
            this.button_100down.Click += new System.EventHandler(this.button_100down_Click);
            // 
            // button_100up
            // 
            this.button_100up.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_100up.ForeColor = System.Drawing.Color.Red;
            this.button_100up.Location = new System.Drawing.Point(204, 609);
            this.button_100up.Name = "button_100up";
            this.button_100up.Size = new System.Drawing.Size(88, 41);
            this.button_100up.TabIndex = 53;
            this.button_100up.Text = "100▲";
            this.button_100up.UseVisualStyleBackColor = true;
            this.button_100up.Click += new System.EventHandler(this.button_100up_Click);
            // 
            // button_voltageOFF
            // 
            this.button_voltageOFF.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_voltageOFF.Location = new System.Drawing.Point(395, 609);
            this.button_voltageOFF.Name = "button_voltageOFF";
            this.button_voltageOFF.Size = new System.Drawing.Size(92, 61);
            this.button_voltageOFF.TabIndex = 57;
            this.button_voltageOFF.Text = "OFF";
            this.button_voltageOFF.UseVisualStyleBackColor = true;
            this.button_voltageOFF.Click += new System.EventHandler(this.button_voltageOFF_Click);
            // 
            // button_VoltageON
            // 
            this.button_VoltageON.Font = new System.Drawing.Font("MS UI Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_VoltageON.Location = new System.Drawing.Point(395, 539);
            this.button_VoltageON.Name = "button_VoltageON";
            this.button_VoltageON.Size = new System.Drawing.Size(92, 61);
            this.button_VoltageON.TabIndex = 56;
            this.button_VoltageON.Text = "ON";
            this.button_VoltageON.UseVisualStyleBackColor = true;
            this.button_VoltageON.Click += new System.EventHandler(this.button_VoltageON_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(190, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 199);
            this.panel1.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1425, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_voltageOFF);
            this.Controls.Add(this.button_VoltageON);
            this.Controls.Add(this.textBox_voltageDisaplay);
            this.Controls.Add(this.button_100down);
            this.Controls.Add(this.button_100up);
            this.Controls.Add(this.textBox_VoltageOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_TotalCountingTime);
            this.Controls.Add(this.label_total_count_mca);
            this.Controls.Add(this.label_peak_mca);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_adcStop);
            this.Controls.Add(this.button_adcStart);
            this.Controls.Add(this.button_autoopen);
            this.Controls.Add(this.button_csv_out);
            this.Controls.Add(this.button_mca_clear);
            this.Controls.Add(this.btn_rx_buf_clear);
            this.Controls.Add(this.button_MCA_OFF);
            this.Controls.Add(this.button_MCA_ON);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.chart_MCA);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "STM32F4series MCAアプリケーション";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MCA)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox_pulse_num;
        private System.Windows.Forms.Label label_adc_sample_num;
        private System.Windows.Forms.Label label_adc_threshold;
        private System.Windows.Forms.TextBox textBox_threshold;
        private System.Windows.Forms.Label label_adc_threshold_dis;
        private System.Windows.Forms.Button clear_one_samplenum_btn;
        private System.Windows.Forms.Button clear_thresh_btn;
        private System.Windows.Forms.Button button_autoopen;
        private System.Windows.Forms.Button button_adcStart;
        private System.Windows.Forms.Button button_adcStop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_peak_mca;
        private System.Windows.Forms.Label label_total_count_mca;
        private System.Windows.Forms.Label label_TotalCountingTime;
        private System.Windows.Forms.Button button_adcsetting2;
        private System.Windows.Forms.Button button_adcsetting1;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

