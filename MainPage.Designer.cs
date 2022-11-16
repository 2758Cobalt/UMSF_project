namespace project1
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.HistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPallete = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorPallete2 = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationBar = new System.Windows.Forms.NotifyIcon(this.components);
            this.Alarm = new System.Windows.Forms.Timer(this.components);
            this.BottomBorderPanel1 = new System.Windows.Forms.MenuStrip();
            this.FoodStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.WaterStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new project1.ProgressBarMaterial();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_water_complete = new System.Windows.Forms.Button();
            this.water_counter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SizeOfGlass = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbx_brm = new System.Windows.Forms.TextBox();
            this.dispaly_s_formule = new System.Windows.Forms.TextBox();
            this.display_f_formule = new System.Windows.Forms.TextBox();
            this.tbx_carbohydrates = new System.Windows.Forms.TextBox();
            this.tbx_squirrels = new System.Windows.Forms.TextBox();
            this.tbx_fats = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            this.BottomBorderPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeOfGlass)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.AutoSize = false;
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.MenuBar.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryMenu,
            this.SettingsMenu,
            this.выходToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ColorPallete,
            this.ColorPallete2});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(828, 48);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // HistoryMenu
            // 
            this.HistoryMenu.AutoSize = false;
            this.HistoryMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistoryMenu.Image = global::FitWat.Properties.Resources.history;
            this.HistoryMenu.Name = "HistoryMenu";
            this.HistoryMenu.Size = new System.Drawing.Size(36, 36);
            this.HistoryMenu.ToolTipText = "Історія";
            this.HistoryMenu.Click += new System.EventHandler(this.HistoryMenu_Click);
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.AutoSize = false;
            this.SettingsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsMenu.Image = global::FitWat.Properties.Resources.settings;
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(36, 36);
            this.SettingsMenu.ToolTipText = "Налаштування";
            this.SettingsMenu.Click += new System.EventHandler(this.GoToSettings);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.AutoSize = false;
            this.выходToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выходToolStripMenuItem.Image = global::FitWat.Properties.Resources.cross;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(36, 36);
            this.выходToolStripMenuItem.ToolTipText = "Закрити програму";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Image = global::FitWat.Properties.Resources.Resize_points;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 36);
            this.toolStripMenuItem1.ToolTipText = "Згорнути";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.свернутьToolStripMenuItem_Click);
            // 
            // ColorPallete
            // 
            this.ColorPallete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ColorPallete.AutoSize = false;
            this.ColorPallete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorPallete.Image = global::FitWat.Properties.Resources.layers2;
            this.ColorPallete.Name = "ColorPallete";
            this.ColorPallete.Size = new System.Drawing.Size(36, 36);
            this.ColorPallete.ToolTipText = "Змінити тему";
            this.ColorPallete.Click += new System.EventHandler(this.ColorPallete_Click);
            // 
            // ColorPallete2
            // 
            this.ColorPallete2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ColorPallete2.AutoSize = false;
            this.ColorPallete2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorPallete2.Image = global::FitWat.Properties.Resources.layers;
            this.ColorPallete2.Name = "ColorPallete2";
            this.ColorPallete2.Size = new System.Drawing.Size(36, 36);
            this.ColorPallete2.ToolTipText = "Змінити тему";
            this.ColorPallete2.Visible = false;
            this.ColorPallete2.Click += new System.EventHandler(this.ColorPallete2_Click);
            // 
            // NotificationBar
            // 
            this.NotificationBar.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificationBar.Icon")));
            this.NotificationBar.Text = "FitWat";
            this.NotificationBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotificationShow_MouseClick);
            // 
            // Alarm
            // 
            this.Alarm.Interval = 3600000;
            this.Alarm.Tick += new System.EventHandler(this.Alarm_Tick);
            // 
            // BottomBorderPanel1
            // 
            this.BottomBorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.BottomBorderPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoodStrip,
            this.WaterStrip});
            this.BottomBorderPanel1.Location = new System.Drawing.Point(0, 417);
            this.BottomBorderPanel1.Name = "BottomBorderPanel1";
            this.BottomBorderPanel1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.BottomBorderPanel1.Size = new System.Drawing.Size(828, 44);
            this.BottomBorderPanel1.TabIndex = 4;
            this.BottomBorderPanel1.Text = "menuStrip1";
            // 
            // FoodStrip
            // 
            this.FoodStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FoodStrip.AutoSize = false;
            this.FoodStrip.Image = global::FitWat.Properties.Resources.apple_whole;
            this.FoodStrip.Name = "FoodStrip";
            this.FoodStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FoodStrip.Size = new System.Drawing.Size(390, 40);
            this.FoodStrip.Click += new System.EventHandler(this.FoodPick);
            // 
            // WaterStrip
            // 
            this.WaterStrip.AutoSize = false;
            this.WaterStrip.Image = global::FitWat.Properties.Resources.glass;
            this.WaterStrip.Name = "WaterStrip";
            this.WaterStrip.Padding = new System.Windows.Forms.Padding(0);
            this.WaterStrip.Size = new System.Drawing.Size(380, 40);
            this.WaterStrip.Click += new System.EventHandler(this.WaterPick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(385, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Головна";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(126)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(383, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Їжа";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_water_complete);
            this.panel1.Controls.Add(this.water_counter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SizeOfGlass);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(20, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 297);
            this.panel1.TabIndex = 16;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.progressBar1.Location = new System.Drawing.Point(20, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(750, 10);
            this.progressBar1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(126)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(367, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Вода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Вам потрібно на годину";
            this.toolTip.SetToolTip(this.label2, "Рекомендовано випивати цю кількість води \r\nкожду годину протягом дня");
            // 
            // btn_water_complete
            // 
            this.btn_water_complete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_water_complete.AutoSize = true;
            this.btn_water_complete.BackgroundImage = global::FitWat.Properties.Resources.btn_water;
            this.btn_water_complete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_water_complete.FlatAppearance.BorderSize = 0;
            this.btn_water_complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_water_complete.Location = new System.Drawing.Point(338, 100);
            this.btn_water_complete.Name = "btn_water_complete";
            this.btn_water_complete.Size = new System.Drawing.Size(120, 42);
            this.btn_water_complete.TabIndex = 2;
            this.toolTip.SetToolTip(this.btn_water_complete, "Натисніть цю кнопку,\r\nякщо вжили стакан води");
            this.btn_water_complete.UseVisualStyleBackColor = true;
            this.btn_water_complete.Click += new System.EventHandler(this.btn_water_complete_Click);
            // 
            // water_counter
            // 
            this.water_counter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.water_counter.AutoSize = true;
            this.water_counter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.water_counter.ForeColor = System.Drawing.SystemColors.Control;
            this.water_counter.Location = new System.Drawing.Point(337, 65);
            this.water_counter.Name = "water_counter";
            this.water_counter.Size = new System.Drawing.Size(121, 21);
            this.water_counter.TabIndex = 4;
            this.water_counter.Text = "0 мл. / 0000 мл.";
            this.water_counter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(126)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(600, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Розмір склянки ml.";
            // 
            // SizeOfGlass
            // 
            this.SizeOfGlass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SizeOfGlass.AutoSize = true;
            this.SizeOfGlass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.SizeOfGlass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeOfGlass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeOfGlass.ForeColor = System.Drawing.Color.White;
            this.SizeOfGlass.Location = new System.Drawing.Point(600, 115);
            this.SizeOfGlass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeOfGlass.Name = "SizeOfGlass";
            this.SizeOfGlass.Size = new System.Drawing.Size(150, 25);
            this.SizeOfGlass.TabIndex = 5;
            this.toolTip.SetToolTip(this.SizeOfGlass, "Розмір склянки у мл.");
            this.SizeOfGlass.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.toolTip.ForeColor = System.Drawing.Color.White;
            this.toolTip.ToolTipTitle = "Підказка";
            // 
            // tbx_brm
            // 
            this.tbx_brm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_brm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_brm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_brm.ForeColor = System.Drawing.Color.White;
            this.tbx_brm.Location = new System.Drawing.Point(22, 39);
            this.tbx_brm.Name = "tbx_brm";
            this.tbx_brm.ReadOnly = true;
            this.tbx_brm.Size = new System.Drawing.Size(115, 22);
            this.tbx_brm.TabIndex = 14;
            this.tbx_brm.Text = "None";
            this.tbx_brm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbx_brm, "Ваш рівень метаболізму \r\nза формулою Міффліна Сент-Жоера");
            // 
            // dispaly_s_formule
            // 
            this.dispaly_s_formule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.dispaly_s_formule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dispaly_s_formule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dispaly_s_formule.ForeColor = System.Drawing.Color.White;
            this.dispaly_s_formule.Location = new System.Drawing.Point(22, 84);
            this.dispaly_s_formule.Name = "dispaly_s_formule";
            this.dispaly_s_formule.ReadOnly = true;
            this.dispaly_s_formule.Size = new System.Drawing.Size(115, 22);
            this.dispaly_s_formule.TabIndex = 13;
            this.dispaly_s_formule.Text = "None";
            this.dispaly_s_formule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.dispaly_s_formule, "Ваш рівень метаболізму \r\nза формулою Харріса Бенедікта");
            // 
            // display_f_formule
            // 
            this.display_f_formule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.display_f_formule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display_f_formule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.display_f_formule.ForeColor = System.Drawing.Color.White;
            this.display_f_formule.Location = new System.Drawing.Point(280, 46);
            this.display_f_formule.Name = "display_f_formule";
            this.display_f_formule.ReadOnly = true;
            this.display_f_formule.Size = new System.Drawing.Size(95, 22);
            this.display_f_formule.TabIndex = 12;
            this.display_f_formule.Text = "None";
            this.display_f_formule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.display_f_formule, "Загальна кількість калорій,\r\nякі потрібні для вживання");
            // 
            // tbx_carbohydrates
            // 
            this.tbx_carbohydrates.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbx_carbohydrates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_carbohydrates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_carbohydrates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_carbohydrates.ForeColor = System.Drawing.Color.White;
            this.tbx_carbohydrates.Location = new System.Drawing.Point(183, 39);
            this.tbx_carbohydrates.Name = "tbx_carbohydrates";
            this.tbx_carbohydrates.ReadOnly = true;
            this.tbx_carbohydrates.Size = new System.Drawing.Size(100, 22);
            this.tbx_carbohydrates.TabIndex = 5;
            this.tbx_carbohydrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbx_carbohydrates, "55% Вуглеводів потрібно\r\nвід загальної кількості калорій");
            // 
            // tbx_squirrels
            // 
            this.tbx_squirrels.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbx_squirrels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_squirrels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_squirrels.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_squirrels.ForeColor = System.Drawing.Color.White;
            this.tbx_squirrels.Location = new System.Drawing.Point(183, 77);
            this.tbx_squirrels.Name = "tbx_squirrels";
            this.tbx_squirrels.ReadOnly = true;
            this.tbx_squirrels.Size = new System.Drawing.Size(100, 22);
            this.tbx_squirrels.TabIndex = 6;
            this.tbx_squirrels.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbx_squirrels, "15% білків потрібних\r\nвід загальної кількості калорій");
            // 
            // tbx_fats
            // 
            this.tbx_fats.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbx_fats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(135)))), ((int)(((byte)(235)))));
            this.tbx_fats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_fats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_fats.ForeColor = System.Drawing.Color.White;
            this.tbx_fats.Location = new System.Drawing.Point(183, 113);
            this.tbx_fats.Name = "tbx_fats";
            this.tbx_fats.ReadOnly = true;
            this.tbx_fats.Size = new System.Drawing.Size(100, 22);
            this.tbx_fats.TabIndex = 7;
            this.tbx_fats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbx_fats, "35% жирів потрібних\r\nвід загальної кількості калорій");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.display_f_formule);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(72, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 239);
            this.panel3.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.tbx_brm);
            this.panel5.Controls.Add(this.dispaly_s_formule);
            this.panel5.Location = new System.Drawing.Point(332, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 151);
            this.panel5.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(153, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "за формулою \r\nХарріса Бенедікта";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(153, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 30);
            this.label13.TabIndex = 22;
            this.label13.Text = "за формулою \r\nМіффліна Сент-Жоера";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))), ((int)(((byte)(207)))));
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbx_fats);
            this.panel4.Controls.Add(this.tbx_squirrels);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tbx_carbohydrates);
            this.panel4.Location = new System.Drawing.Point(15, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 151);
            this.panel4.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(140)))), ((int)(((byte)(102)))), ((int)(((byte)(227)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(8, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 21);
            this.label14.TabIndex = 23;
            this.label14.Text = "Детальний розподіл";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вуглеводи (55%)";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Жири (35%)";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(8, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Білки (15%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(198, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Загальна кількість калорій на добу\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(126)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(15, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 297);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(109)))), ((int)(((byte)(204)))));
            this.BackgroundImage = global::FitWat.Properties.Resources.bg_panel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BottomBorderPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.BottomBorderPanel1.ResumeLayout(false);
            this.BottomBorderPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeOfGlass)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuBar;
        private ToolStripMenuItem SettingsMenu;
        private NotifyIcon NotificationBar;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem ColorPallete;
        private System.Windows.Forms.Timer Alarm;
        private MenuStrip BottomBorderPanel1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ColorPallete2;
        private Label label7;
        private Label label11;
        private Panel panel1;
        private Label label2;
        private Button btn_water_complete;
        private Label water_counter;
        private Label label1;
        private NumericUpDown SizeOfGlass;
        private Label label10;
        private ToolStripMenuItem HistoryMenu;
        private ToolTip toolTip;
        private ToolStripMenuItem FoodStrip;
        private ToolStripMenuItem WaterStrip;
        private TextBox tbx_brm;
        private TextBox dispaly_s_formule;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private TextBox tbx_fats;
        private TextBox tbx_squirrels;
        private Label label6;
        private Label label5;
        private TextBox tbx_carbohydrates;
        private Label label9;
        private TextBox display_f_formule;
        private Panel panel2;
        private Label label13;
        private Label label12;
        private Label label14;
        private Panel panel5;
        private ProgressBarMaterial progressBar1;
    }
}