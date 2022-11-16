namespace project1
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.btn_grp1 = new System.Windows.Forms.Button();
            this.btn_cancel1 = new System.Windows.Forms.Button();
            this.tbx_phyact = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_weigth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_grp2 = new System.Windows.Forms.Button();
            this.TimeWakeUp = new System.Windows.Forms.DateTimePicker();
            this.TimeToSleep = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancel2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomBorderPanel1 = new System.Windows.Forms.MenuStrip();
            this.gpanel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gpanel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gpanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gpanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // img2
            // 
            this.img2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.img2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.InitialImage = null;
            this.img2.Location = new System.Drawing.Point(201, 50);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(74, 65);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 15;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.btn_female_click);
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.img1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.InitialImage = null;
            this.img1.Location = new System.Drawing.Point(34, 50);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(74, 65);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 14;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.btn_male_click);
            // 
            // btn_grp1
            // 
            this.btn_grp1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_grp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.btn_grp1.Enabled = false;
            this.btn_grp1.FlatAppearance.BorderSize = 0;
            this.btn_grp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grp1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_grp1.Location = new System.Drawing.Point(50, 259);
            this.btn_grp1.Name = "btn_grp1";
            this.btn_grp1.Size = new System.Drawing.Size(241, 23);
            this.btn_grp1.TabIndex = 0;
            this.btn_grp1.Text = "Далі";
            this.btn_grp1.UseVisualStyleBackColor = false;
            this.btn_grp1.EnabledChanged += new System.EventHandler(this.btn_grp1_EnabledChanged);
            this.btn_grp1.Click += new System.EventHandler(this.panel_confirm);
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.btn_cancel1.FlatAppearance.BorderSize = 0;
            this.btn_cancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel1.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel1.Location = new System.Drawing.Point(-136, 259);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(155, 23);
            this.btn_cancel1.TabIndex = 11;
            this.btn_cancel1.Text = "Назад";
            this.btn_cancel1.UseVisualStyleBackColor = false;
            this.btn_cancel1.Click += new System.EventHandler(this.cancel1_click);
            // 
            // tbx_phyact
            // 
            this.tbx_phyact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_phyact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbx_phyact.FormattingEnabled = true;
            this.tbx_phyact.Items.AddRange(new object[] {
            "Нульова активність",
            "Низька активність (1/2 рази в неділю)",
            "Середня активність (3/4 рази в неділю)",
            "Висока активність (більше 5 раз в неділю)"});
            this.tbx_phyact.Location = new System.Drawing.Point(179, 174);
            this.tbx_phyact.Name = "tbx_phyact";
            this.tbx_phyact.Size = new System.Drawing.Size(128, 23);
            this.tbx_phyact.TabIndex = 10;
            this.tbx_phyact.Text = "Обрати активність";
            this.tbx_phyact.SelectedValueChanged += new System.EventHandler(this.tbx_phyact_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(44, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фізична активність";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_weigth
            // 
            this.tbx_weigth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_weigth.Location = new System.Drawing.Point(179, 123);
            this.tbx_weigth.Name = "tbx_weigth";
            this.tbx_weigth.Size = new System.Drawing.Size(128, 23);
            this.tbx_weigth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вага";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_age
            // 
            this.tbx_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_age.Location = new System.Drawing.Point(179, 84);
            this.tbx_age.Name = "tbx_age";
            this.tbx_age.Size = new System.Drawing.Size(128, 23);
            this.tbx_age.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вік";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_height
            // 
            this.tbx_height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_height.Location = new System.Drawing.Point(179, 42);
            this.tbx_height.Name = "tbx_height";
            this.tbx_height.Size = new System.Drawing.Size(128, 23);
            this.tbx_height.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Зріст";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_grp2
            // 
            this.btn_grp2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_grp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.btn_grp2.Enabled = false;
            this.btn_grp2.FlatAppearance.BorderSize = 0;
            this.btn_grp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grp2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_grp2.Location = new System.Drawing.Point(43, 259);
            this.btn_grp2.Name = "btn_grp2";
            this.btn_grp2.Size = new System.Drawing.Size(145, 23);
            this.btn_grp2.TabIndex = 0;
            this.btn_grp2.Text = "Далі";
            this.btn_grp2.UseVisualStyleBackColor = false;
            this.btn_grp2.EnabledChanged += new System.EventHandler(this.btn_grp2_EnabledChanged);
            this.btn_grp2.Click += new System.EventHandler(this.panel2_confirm);
            // 
            // TimeWakeUp
            // 
            this.TimeWakeUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TimeWakeUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeWakeUp.Location = new System.Drawing.Point(191, 105);
            this.TimeWakeUp.Name = "TimeWakeUp";
            this.TimeWakeUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeWakeUp.ShowUpDown = true;
            this.TimeWakeUp.Size = new System.Drawing.Size(100, 23);
            this.TimeWakeUp.TabIndex = 19;
            this.TimeWakeUp.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // TimeToSleep
            // 
            this.TimeToSleep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TimeToSleep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeToSleep.Location = new System.Drawing.Point(191, 47);
            this.TimeToSleep.Name = "TimeToSleep";
            this.TimeToSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeToSleep.ShowUpDown = true;
            this.TimeToSleep.Size = new System.Drawing.Size(100, 23);
            this.TimeToSleep.TabIndex = 14;
            this.TimeToSleep.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(18, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Коли лягаєте спати?";
            // 
            // btn_cancel2
            // 
            this.btn_cancel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.btn_cancel2.FlatAppearance.BorderSize = 0;
            this.btn_cancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel2.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel2.Location = new System.Drawing.Point(24, 259);
            this.btn_cancel2.Name = "btn_cancel2";
            this.btn_cancel2.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel2.TabIndex = 11;
            this.btn_cancel2.Text = "Назад";
            this.btn_cancel2.UseVisualStyleBackColor = false;
            this.btn_cancel2.Click += new System.EventHandler(this.cancel2_click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Коли прокидаєтеся?";
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.btn_apply.FlatAppearance.BorderSize = 0;
            this.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apply.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_apply.Location = new System.Drawing.Point(-58, 259);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(93, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Приступити";
            this.btn_apply.UseVisualStyleBackColor = false;
            this.btn_apply.Click += new System.EventHandler(this.apply_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(44)))), ((int)(((byte)(122)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 40);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.AutoSize = false;
            this.настройкиToolStripMenuItem.Image = global::FitWat.Properties.Resources.cross;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(36, 36);
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.LeaveBtn);
            // 
            // BottomBorderPanel1
            // 
            this.BottomBorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(122)))));
            this.BottomBorderPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel1.Location = new System.Drawing.Point(0, 499);
            this.BottomBorderPanel1.Name = "BottomBorderPanel1";
            this.BottomBorderPanel1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BottomBorderPanel1.Size = new System.Drawing.Size(865, 24);
            this.BottomBorderPanel1.TabIndex = 15;
            this.BottomBorderPanel1.Text = "menuStrip1";
            // 
            // gpanel1
            // 
            this.gpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.gpanel1.Controls.Add(this.panel3);
            this.gpanel1.Controls.Add(this.btn_grp1);
            this.gpanel1.Location = new System.Drawing.Point(30, 100);
            this.gpanel1.Name = "gpanel1";
            this.gpanel1.Size = new System.Drawing.Size(350, 300);
            this.gpanel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.img2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.img1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(16, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 171);
            this.panel3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(109, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Оберіть стать";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(216, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Жіноча";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(41, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Чоловіча";
            // 
            // gpanel2
            // 
            this.gpanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.gpanel2.Controls.Add(this.panel1);
            this.gpanel2.Controls.Add(this.btn_cancel1);
            this.gpanel2.Controls.Add(this.btn_grp2);
            this.gpanel2.Location = new System.Drawing.Point(400, 100);
            this.gpanel2.Name = "gpanel2";
            this.gpanel2.Size = new System.Drawing.Size(50, 300);
            this.gpanel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbx_height);
            this.panel1.Controls.Add(this.tbx_weigth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbx_age);
            this.panel1.Controls.Add(this.tbx_phyact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-136, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 217);
            this.panel1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.label11.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(68, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Введіть властивості (без пропусків)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpanel3
            // 
            this.gpanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.gpanel3.Controls.Add(this.panel2);
            this.gpanel3.Controls.Add(this.btn_cancel2);
            this.gpanel3.Controls.Add(this.btn_apply);
            this.gpanel3.Location = new System.Drawing.Point(500, 100);
            this.gpanel3.Name = "gpanel3";
            this.gpanel3.Size = new System.Drawing.Size(50, 300);
            this.gpanel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TimeWakeUp);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TimeToSleep);
            this.panel2.Location = new System.Drawing.Point(17, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 186);
            this.panel2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(121, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Оберіть час";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.BackgroundImage = global::FitWat.Properties.Resources.bg_StartPanel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 523);
            this.Controls.Add(this.gpanel3);
            this.Controls.Add(this.gpanel2);
            this.Controls.Add(this.gpanel1);
            this.Controls.Add(this.BottomBorderPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Початок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartPage_FormClosed);
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.Shown += new System.EventHandler(this.StartPage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gpanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_grp1;
        private TextBox tbx_weigth;
        private Label label3;
        private TextBox tbx_age;
        private Label label2;
        private TextBox tbx_height;
        private Label label1;
        private Button btn_grp2;
        private ComboBox tbx_phyact;
        private Label label4;
        private Button btn_cancel1;
        private Button btn_cancel2;
        private Label label5;
        private Button btn_apply;
        private Label label6;
        private PictureBox img2;
        private DateTimePicker TimeToSleep;
        private DateTimePicker TimeWakeUp;
        private PictureBox img1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private MenuStrip BottomBorderPanel1;
        private Panel gpanel1;
        private Panel gpanel2;
        private Panel gpanel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label10;
        private Panel panel3;
        private Label label11;
    }
}