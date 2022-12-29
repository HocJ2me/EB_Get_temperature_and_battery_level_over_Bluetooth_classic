namespace EB_Bluetooth_temperature_and_battery_level
{
    partial class frmMain
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
            this.Port_deviceTest = new System.IO.Ports.SerialPort(this.components);
            this.cbx_select_port = new System.Windows.Forms.ComboBox();
            this.lbl_select_port = new System.Windows.Forms.Label();
            this.btn_start_log = new System.Windows.Forms.Button();
            this.btn_stop_log = new System.Windows.Forms.Button();
            this.tbx_output = new System.Windows.Forms.TextBox();
            this.tmr_logging_data = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbx_select_port
            // 
            this.cbx_select_port.FormattingEnabled = true;
            this.cbx_select_port.Location = new System.Drawing.Point(164, 36);
            this.cbx_select_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_select_port.Name = "cbx_select_port";
            this.cbx_select_port.Size = new System.Drawing.Size(160, 24);
            this.cbx_select_port.TabIndex = 0;
            // 
            // lbl_select_port
            // 
            this.lbl_select_port.AutoSize = true;
            this.lbl_select_port.Location = new System.Drawing.Point(37, 46);
            this.lbl_select_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_select_port.Name = "lbl_select_port";
            this.lbl_select_port.Size = new System.Drawing.Size(71, 16);
            this.lbl_select_port.TabIndex = 1;
            this.lbl_select_port.Text = "Chọn cổng";
            // 
            // btn_start_log
            // 
            this.btn_start_log.Location = new System.Drawing.Point(41, 108);
            this.btn_start_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_start_log.Name = "btn_start_log";
            this.btn_start_log.Size = new System.Drawing.Size(284, 44);
            this.btn_start_log.TabIndex = 2;
            this.btn_start_log.Text = "Bắt đầu log";
            this.btn_start_log.UseVisualStyleBackColor = true;
            this.btn_start_log.Click += new System.EventHandler(this.btn_start_log_Click);
            // 
            // btn_stop_log
            // 
            this.btn_stop_log.Location = new System.Drawing.Point(41, 175);
            this.btn_stop_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stop_log.Name = "btn_stop_log";
            this.btn_stop_log.Size = new System.Drawing.Size(284, 44);
            this.btn_stop_log.TabIndex = 3;
            this.btn_stop_log.Text = "Kết thúc log";
            this.btn_stop_log.UseVisualStyleBackColor = true;
            this.btn_stop_log.Click += new System.EventHandler(this.btn_stop_log_Click);
            // 
            // tbx_output
            // 
            this.tbx_output.Location = new System.Drawing.Point(403, 25);
            this.tbx_output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_output.Multiline = true;
            this.tbx_output.Name = "tbx_output";
            this.tbx_output.Size = new System.Drawing.Size(615, 482);
            this.tbx_output.TabIndex = 4;
            // 
            // tmr_logging_data
            // 
            this.tmr_logging_data.Tick += new System.EventHandler(this.tmr_logging_data_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbx_output);
            this.Controls.Add(this.btn_stop_log);
            this.Controls.Add(this.btn_start_log);
            this.Controls.Add(this.lbl_select_port);
            this.Controls.Add(this.cbx_select_port);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Port_deviceTest;
        private System.Windows.Forms.ComboBox cbx_select_port;
        private System.Windows.Forms.Label lbl_select_port;
        private System.Windows.Forms.Button btn_start_log;
        private System.Windows.Forms.Button btn_stop_log;
        private System.Windows.Forms.TextBox tbx_output;
        private System.Windows.Forms.Timer tmr_logging_data;
    }
}

