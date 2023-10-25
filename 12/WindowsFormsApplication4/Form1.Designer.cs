namespace WindowsFormsApplication4
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
            this.panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StopBtn = new System.Windows.Forms.Button();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.FineLabel = new System.Windows.Forms.Label();
            this.CloudyLabel = new System.Windows.Forms.Label();
            this.RainyLabel = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.trackBar1);
            this.panel.Controls.Add(this.StopBtn);
            this.panel.Controls.Add(this.LaunchBtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(717, 114);
            this.panel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Circe", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(666, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "16x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Circe", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(580, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "4x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Circe", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(491, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "1x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Circe", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(392, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "0.5x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Circe", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(297, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "0.25x";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(301, 34);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(393, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLabel.Location = new System.Drawing.Point(540, 124);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(112, 23);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Время: 0 дней";
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StopBtn.Enabled = false;
            this.StopBtn.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StopBtn.Location = new System.Drawing.Point(157, 34);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(96, 38);
            this.StopBtn.TabIndex = 7;
            this.StopBtn.Text = "Стоп";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.Stop_Click);
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LaunchBtn.Font = new System.Drawing.Font("Circe Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LaunchBtn.Location = new System.Drawing.Point(28, 34);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(96, 38);
            this.LaunchBtn.TabIndex = 6;
            this.LaunchBtn.Text = "Запустить";
            this.LaunchBtn.UseVisualStyleBackColor = false;
            this.LaunchBtn.Click += new System.EventHandler(this.Launch_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Font = new System.Drawing.Font("Circe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeatherLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WeatherLabel.Location = new System.Drawing.Point(12, 128);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(174, 22);
            this.WeatherLabel.TabIndex = 15;
            this.WeatherLabel.Text = "Погода сейчас: солнечно";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Circe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HistoryLabel.Location = new System.Drawing.Point(12, 151);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(75, 22);
            this.HistoryLabel.TabIndex = 16;
            this.HistoryLabel.Text = "История: ";
            // 
            // FineLabel
            // 
            this.FineLabel.AutoSize = true;
            this.FineLabel.Font = new System.Drawing.Font("Circe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FineLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FineLabel.Location = new System.Drawing.Point(12, 177);
            this.FineLabel.Name = "FineLabel";
            this.FineLabel.Size = new System.Drawing.Size(236, 22);
            this.FineLabel.TabIndex = 18;
            this.FineLabel.Text = "% ясных дней (теоретически 38%)";
            // 
            // CloudyLabel
            // 
            this.CloudyLabel.AutoSize = true;
            this.CloudyLabel.Font = new System.Drawing.Font("Circe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloudyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloudyLabel.Location = new System.Drawing.Point(12, 203);
            this.CloudyLabel.Name = "CloudyLabel";
            this.CloudyLabel.Size = new System.Drawing.Size(259, 22);
            this.CloudyLabel.TabIndex = 20;
            this.CloudyLabel.Text = "% облачных дней (теоретически 30%)";
            // 
            // RainyLabel
            // 
            this.RainyLabel.AutoSize = true;
            this.RainyLabel.Font = new System.Drawing.Font("Circe", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RainyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RainyLabel.Location = new System.Drawing.Point(12, 229);
            this.RainyLabel.Name = "RainyLabel";
            this.RainyLabel.Size = new System.Drawing.Size(267, 22);
            this.RainyLabel.TabIndex = 22;
            this.RainyLabel.Text = "% пасмурных дней (теоретически 32%)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(717, 282);
            this.Controls.Add(this.RainyLabel);
            this.Controls.Add(this.CloudyLabel);
            this.Controls.Add(this.FineLabel);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.WeatherLabel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.TimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button LaunchBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label FineLabel;
        private System.Windows.Forms.Label CloudyLabel;
        private System.Windows.Forms.Label RainyLabel;
    }
}

