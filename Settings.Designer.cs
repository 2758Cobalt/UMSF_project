namespace project1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomBorderPanel1 = new System.Windows.Forms.MenuStrip();
            this.btn_apply = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeWakeUp = new System.Windows.Forms.DateTimePicker();
            this.TimeToSleep = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_phyact = new System.Windows.Forms.ComboBox();
            this.tbx_height = new System.Windows.Forms.TextBox();
            this.tbx_age = new System.Windows.Forms.TextBox();
            this.tbx_weigth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.BottomBorderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.AutoSize = false;
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.MenuBar.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(677, 48);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.AutoSize = false;
            this.настройкиToolStripMenuItem.Image = global::FitWat.Properties.Resources.back;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(36, 36);
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.ExitToMain);
            // 
            // BottomBorderPanel1
            // 
            this.BottomBorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.BottomBorderPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_apply});
            this.BottomBorderPanel1.Location = new System.Drawing.Point(0, 390);
            this.BottomBorderPanel1.Name = "BottomBorderPanel1";
            this.BottomBorderPanel1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BottomBorderPanel1.Size = new System.Drawing.Size(677, 40);
            this.BottomBorderPanel1.TabIndex = 5;
            this.BottomBorderPanel1.Text = "menuStrip1";
            // 
            // btn_apply
            // 
            this.btn_apply.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_apply.AutoSize = false;
            this.btn_apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_apply.Enabled = false;
            this.btn_apply.Image = global::FitWat.Properties.Resources.check;
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_apply.Size = new System.Drawing.Size(36, 36);
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(0, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Налаштування";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Стать";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вік";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Зріст";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(28, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Вага";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(200, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Коли прокидаєтесь?";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(200, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Коли лягаєте спати?";
            // 
            // TimeWakeUp
            // 
            this.TimeWakeUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TimeWakeUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeWakeUp.Location = new System.Drawing.Point(336, 213);
            this.TimeWakeUp.Name = "TimeWakeUp";
            this.TimeWakeUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeWakeUp.ShowUpDown = true;
            this.TimeWakeUp.Size = new System.Drawing.Size(131, 23);
            this.TimeWakeUp.TabIndex = 27;
            this.TimeWakeUp.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // TimeToSleep
            // 
            this.TimeToSleep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TimeToSleep.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.TimeToSleep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeToSleep.Location = new System.Drawing.Point(336, 177);
            this.TimeToSleep.Name = "TimeToSleep";
            this.TimeToSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeToSleep.ShowUpDown = true;
            this.TimeToSleep.Size = new System.Drawing.Size(131, 23);
            this.TimeToSleep.TabIndex = 26;
            this.TimeToSleep.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(200, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Фізична активність";
            // 
            // tbx_phyact
            // 
            this.tbx_phyact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbx_phyact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.tbx_phyact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbx_phyact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_phyact.ForeColor = System.Drawing.Color.White;
            this.tbx_phyact.FormattingEnabled = true;
            this.tbx_phyact.Items.AddRange(new object[] {
            "Нульова активність",
            "Низька активність (1/2 рази в неділю)",
            "Середня активність (3/4 рази в неділю)",
            "Висока активність (більше 5 раз в неділю)"});
            this.tbx_phyact.Location = new System.Drawing.Point(336, 133);
            this.tbx_phyact.Name = "tbx_phyact";
            this.tbx_phyact.Size = new System.Drawing.Size(131, 21);
            this.tbx_phyact.TabIndex = 29;
            this.tbx_phyact.Text = "Обрати активність";
            // 
            // tbx_height
            // 
            this.tbx_height.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_height.ForeColor = System.Drawing.Color.White;
            this.tbx_height.Location = new System.Drawing.Point(111, 132);
            this.tbx_height.Name = "tbx_height";
            this.tbx_height.Size = new System.Drawing.Size(46, 16);
            this.tbx_height.TabIndex = 30;
            // 
            // tbx_age
            // 
            this.tbx_age.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_age.ForeColor = System.Drawing.Color.White;
            this.tbx_age.Location = new System.Drawing.Point(111, 174);
            this.tbx_age.Name = "tbx_age";
            this.tbx_age.Size = new System.Drawing.Size(46, 16);
            this.tbx_age.TabIndex = 31;
            this.tbx_age.TextChanged += new System.EventHandler(this.TextChanged_event);
            // 
            // tbx_weigth
            // 
            this.tbx_weigth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_weigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_weigth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_weigth.ForeColor = System.Drawing.Color.White;
            this.tbx_weigth.Location = new System.Drawing.Point(111, 213);
            this.tbx_weigth.Name = "tbx_weigth";
            this.tbx_weigth.Size = new System.Drawing.Size(46, 16);
            this.tbx_weigth.TabIndex = 32;
            this.tbx_weigth.TextChanged += new System.EventHandler(this.TextChanged_event);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(113, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "N/A";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::FitWat.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(200, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 20);
            this.button1.TabIndex = 34;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.BackgroundImage = global::FitWat.Properties.Resources.bg_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_age);
            this.Controls.Add(this.tbx_weigth);
            this.Controls.Add(this.tbx_height);
            this.Controls.Add(this.tbx_phyact);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TimeWakeUp);
            this.Controls.Add(this.TimeToSleep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BottomBorderPanel1);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.BottomBorderPanel1.ResumeLayout(false);
            this.BottomBorderPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip MenuBar;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private MenuStrip BottomBorderPanel1;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker TimeWakeUp;
        private DateTimePicker TimeToSleep;
        private Label label9;
        private ComboBox tbx_phyact;
        private TextBox tbx_height;
        private TextBox tbx_age;
        private TextBox tbx_weigth;
        private ToolStripMenuItem btn_apply;
        private Label label8;
        private Button button1;
    }
}