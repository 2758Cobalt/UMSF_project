using FitWat;
using FitWat.Properties;
using System.Drawing.Imaging;
using System.Xml;
using System.Xml.XPath;
using System.Drawing.Drawing2D;

namespace project1
{
    
    public partial class MainPage : Form
    {

        byte age, lastday;// Возраст | Сон минуты| Сон часы | Проснуться минуты | Проснуться часы
        double weigth, height, s_formule,brm, f_formule, physicalActivity;// Вес | Рост | метаболизм
        bool firstStart, state;// Первый запуск |  Пол
        int waterMax,waterCurrnet = 0;// Нужное количество | Текущее кол-во
        int waterTime;
        bool theme;
        DateTimePicker TimeToSleep, TimeWakeUp;
        StartPage form_sp = new StartPage();
        Settings form_settings = new Settings();
        History form_history = new History();
        public MainPage() {InitializeComponent(); DoubleBuffered = true; }
        private void MainPage_Load(object sender, EventArgs e)//Выполняется при загрузке
        {
            TimeToSleep = new DateTimePicker();
            TimeWakeUp = new DateTimePicker();
            LoadData();
            panel1.Location = new Point(15, 100);
            panel2.Location = new Point(15, 100);
            WaterStrip.BackColor = Color.FromArgb(198, 177, 250); // default selected strip
            MenuBar.ShowItemToolTips = true;
            if (firstStart != true)
            {
                waterMax = Convert.ToInt16(30 * weigth);// Расчёт воды
                waterTime = (waterMax / (TimeWakeUp.Value.Hour - TimeToSleep.Value.Hour));
                SizeOfGlass.Maximum = waterMax;
                SizeOfGlass.Value = Math.Abs(waterTime);
                water_counter.Text = waterCurrnet.ToString() + " мл. / " + waterMax.ToString() + " мл.";
                progressBar1.Maximum = waterMax;
            }
            
        }
        private void LoadData()
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("data.xml")) // если существует данный файл
            {
                doc.Load("data.xml");// Загрузка файла
            }
            else
            {
                MessageBox.Show("Отсувствует файл data.xml");
            }
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Name == "fstart") firstStart = bool.Parse(node.InnerText);
                if (node.Name == "state") state = bool.Parse(node.InnerText);
                if (node.Name == "age") age = byte.Parse(node.InnerText);
                if (node.Name == "height") height = double.Parse(node.InnerText);
                if (node.Name == "weigth") weigth = double.Parse(node.InnerText);
                if (node.Name == "physactivity") physicalActivity = double.Parse(node.InnerText);
                if (node.Name == "timetosleep") TimeToSleep.Value = Convert.ToDateTime(node.InnerText);
                if (node.Name == "timewakeup") TimeWakeUp.Value = Convert.ToDateTime(node.InnerText);
                if (node.Name == "lastday") lastday = byte.Parse(node.InnerText);
            }
            
        }
        private void ChangeData()
        {
            if (state == true)
            {
                s_formule = Math.Round((88.362 + (13.397 * weigth) + (4.799 * height) - (5.677 * age)) * physicalActivity,1);
                f_formule = Math.Round((10 * weigth + 6.25 * height - 5 * age + 5) * physicalActivity,1);
            }
            else
            {
                s_formule = Math.Round((447.594 + (9.247 * weigth) + (3.098 * height) - (4.330 * age))* physicalActivity,1);
                f_formule = Math.Round((10 * weigth + 6.25 * height - 5 * age - 161) * physicalActivity,1);
            }
            brm = Math.Round(66 + (13.8 * weigth) + (5 * height) - (6.8 * age),1);
            tbx_brm.Text = brm.ToString();
            display_f_formule.Text = f_formule.ToString();
            dispaly_s_formule.Text = s_formule.ToString();
            tbx_carbohydrates.Text = Math.Round(f_formule * 0.55,1).ToString();
            tbx_squirrels.Text = Math.Round(f_formule * 0.15,1).ToString();
            tbx_fats.Text = Math.Round(f_formule * 0.3,1).ToString();
            if (DateTime.Now.Day == lastday)
            { 
                ShowAlert("Увага", "Ви вже виконали сьогоднішню норму, приходьте завтра", false);
                Alarm.Enabled = false;
                progressBar1.Value = progressBar1.Maximum;
                form_history.AddColumn("Виконали норму", true);
                water_counter.Text = "Ваша норма води виконана";
                water_counter.Location = new Point(water_counter.Location.X - 50, water_counter.Location.Y);
                label2.Text = "Норма виконана";
            }
            else
            {
                Alarm.Enabled = true;
                Alarm.Start();
                label2.Text = $"Вам потрібно на годину {waterTime} мл. води";
            }
        }
        private void SaveData()
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("data.xml")) // если существует данный файл
            {
                doc.Load("data.xml");// Загрузка файла
            }
            else { MessageBox.Show("Отсувствует файл data.xml"); }

            XPathNavigator navigator = doc.CreateNavigator();
            foreach (XPathNavigator nav in navigator.Select("//root"))
            {
                nav.MoveToFollowing("lastday", "");
                nav.SetValue(lastday.ToString());
            }
            doc.Save("data.xml");
        }
        
        // custom methods ^^^
        private void MainPage_Shown(object sender, EventArgs e)
        {
            if (firstStart == true)
            {
                this.Hide();
                form_sp.Show();
            }
            else { ChangeData(); }
        }
        
        private void ColorPallete_Click(object sender, EventArgs e)//Сменить тему1
        {
            ColorPallete.Image = FitWat.Properties.Resources.layers2;
            this.BackgroundImage = FitWat.Properties.Resources.bg_StartPanel;
            form_history.ChangeTheme(true);
            form_settings.ChangeTheme(true);

            MenuBar.BackColor = Color.FromArgb(99, 44, 122);
            BottomBorderPanel1.BackColor = Color.FromArgb(163, 55, 122);

            WaterStrip.BackColor = BottomBorderPanel1.BackColor;
            FoodStrip.BackColor = BottomBorderPanel1.BackColor;
            if(panel1.Visible == true) WaterStrip.BackColor = Color.FromArgb(240, 170, 213);
            else FoodStrip.BackColor = Color.FromArgb(240, 170, 213);

            btn_water_complete.BackgroundImage = FitWat.Properties.Resources.btn_water2;
            
            progressBar1.ForeColor = Color.FromArgb(167, 73, 222);
            progressBar1.BackColor = Color.FromArgb(202, 96, 214);

            panel1.BackColor = Color.FromArgb(50, 154, 67, 159);
            panel2.BackColor = Color.FromArgb(50, 154, 67, 159);
            panel3.BackColor = Color.FromArgb(150, 154, 67, 159);
            panel4.BackColor = Color.FromArgb(150, 154, 67, 159);
            panel5.BackColor = Color.FromArgb(150, 154, 67, 159);

            label7.BackColor = Color.FromArgb(163, 55, 122);
            label14.BackColor = Color.FromArgb(100,160, 84, 191);
            SizeOfGlass.BackColor = Color.FromArgb(163, 55, 122);

            tbx_brm.BackColor = Color.FromArgb(163, 55, 122);
            tbx_carbohydrates.BackColor = Color.FromArgb(163, 55, 122);
            tbx_fats.BackColor = Color.FromArgb(163, 55, 122);
            tbx_squirrels.BackColor = Color.FromArgb(163, 55, 122);
            
            dispaly_s_formule.BackColor = Color.FromArgb(163, 55, 122);
            display_f_formule.BackColor = Color.FromArgb(163, 55, 122);

            ColorPallete.Visible = false;
            ColorPallete2.Visible = true;
            theme = true;
        }
        private void ColorPallete2_Click(object sender, EventArgs e)//Сменить тему2
        {
            ColorPallete.Image = FitWat.Properties.Resources.layers;
            this.BackgroundImage = FitWat.Properties.Resources.bg_panel;
            form_history.ChangeTheme(false);
            form_settings.ChangeTheme(false);

            MenuBar.BackColor = Color.FromArgb(95, 102, 207);
            BottomBorderPanel1.BackColor = Color.FromArgb(135, 109, 204);

            WaterStrip.BackColor = BottomBorderPanel1.BackColor;
            FoodStrip.BackColor = BottomBorderPanel1.BackColor;
            if (panel1.Visible == true) WaterStrip.BackColor = Color.FromArgb(198, 177, 250);
            else FoodStrip.BackColor = Color.FromArgb(198, 177, 250);

            btn_water_complete.BackgroundImage = FitWat.Properties.Resources.btn_water;

            progressBar1.ForeColor = Color.FromArgb(135, 109, 204);
            progressBar1.BackColor = Color.FromArgb(125, 135, 235);
            

            panel1.BackColor = Color.FromArgb(50, 82, 77, 126);
            panel2.BackColor = Color.FromArgb(50, 82, 77, 126);
            panel3.BackColor = Color.FromArgb(150, 87, 88, 179);
            panel4.BackColor = Color.FromArgb(100, 95, 102, 207);
            panel5.BackColor = Color.FromArgb(100, 95, 102, 207);

            label7.BackColor = Color.FromArgb(135, 109, 204);
            label14.BackColor = Color.FromArgb(100, 140, 102, 227);

            SizeOfGlass.BackColor = Color.FromArgb(125, 135, 235);

            tbx_brm.BackColor = Color.FromArgb(125, 135, 235);
            tbx_carbohydrates.BackColor = Color.FromArgb(125, 135, 235);
            tbx_fats.BackColor = Color.FromArgb(125, 135, 235);
            tbx_squirrels.BackColor = Color.FromArgb(125, 135, 235);
            dispaly_s_formule.BackColor = Color.FromArgb(125, 135, 235);
            display_f_formule.BackColor = Color.FromArgb(125, 135, 235);

            ColorPallete.Visible = true;
            ColorPallete2.Visible = false;
            theme = false;
        }
        private void HistoryMenu_Click(object sender, EventArgs e){form_history.Show();this.Hide();}
        private void WaterPick(object sender, EventArgs e)
        {
            
            FoodStrip.BackColor = BottomBorderPanel1.BackColor;
            panel1.Visible = true;
            panel2.Visible = false;
            if (theme == true)//true - красная тема
                WaterStrip.BackColor = Color.FromArgb(240, 170, 213);
            else WaterStrip.BackColor = Color.FromArgb(198, 177, 250);
        }
        private void FoodPick(object sender, EventArgs e)
        {
            WaterStrip.BackColor = BottomBorderPanel1.BackColor;
            panel2.Visible = true;
            panel1.Visible = false;
            if (theme == true)//true - красная тема
                FoodStrip.BackColor = Color.FromArgb(240, 170, 213);
            else FoodStrip.BackColor = Color.FromArgb(198, 177, 250);
        }
        private void Alarm_Tick(object sender, EventArgs e)
        {
            //Выполняется каждый тик | Тик в программе должен быть 1 минута то есть 60 000 -
            //(1 сек = 1000) (1 минута = 60 000) (1 час = 60 000 0)

            if (waterCurrnet != waterMax)//елси стандарт не выполнен, то вызвов showalert
            {
                ShowAlert("Нагадування", "Треба випити води", false);
            }
        }// Tick Event
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Alarm.Stop();
        }
        private void ShowAlert(string title="title",string description="desc",bool hideicon = true)
        {//Функция для отображения уведомлений
            if (NotificationBar.Visible == true)
            {
                NotificationBar.BalloonTipTitle = title;
                NotificationBar.BalloonTipText = description;
                NotificationBar.ShowBalloonTip(1000);//Время, когда уведомление пропадёт
            }
            else
            {
                NotificationBar.Visible = true;//Отображает иконку в трее
                NotificationBar.BalloonTipTitle = title;
                NotificationBar.BalloonTipText = description;
                NotificationBar.ShowBalloonTip(1000);//Время, когда уведомление пропадёт
                if (hideicon == false) NotificationBar.Visible = false;
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {Application.Exit();}
        private void свернутьToolStripMenuItem_Click(object sender, EventArgs e) {this.Hide();ShowAlert("Повідоменя", "Програма працює у фоні");}
        private void btn_water_complete_Click(object sender, EventArgs e)// действие: выпил воды
        {
            waterCurrnet += Convert.ToInt32(SizeOfGlass.Value);

            if (waterCurrnet >= waterMax) {
                progressBar1.Value = waterMax;
                ShowAlert("Повідомлення", "Норма вже досягнута", false);
                waterCurrnet = waterMax;
                label2.Text = "Норма виконана";
                lastday = Convert.ToByte(DateTime.Now.Day);
                SaveData();
            }
            else { progressBar1.Value = waterCurrnet; form_history.AddColumn(Convert.ToInt32(SizeOfGlass.Value).ToString() + " мл.",false); }
            water_counter.Text = waterCurrnet.ToString() + " мл. / " + waterMax.ToString() + " мл.";
        }
        private void GoToSettings(object sender, EventArgs e){form_settings.Show(); this.Hide(); }// Переход в Настройки
        private void NotificationShow_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();//Отображает форму
            NotificationBar.Visible = false;//Скрывает иконку в трее
            WindowState = FormWindowState.Normal;//Восстановит состояние формы (развёрнет)
        }
    }// Кастомный прогресс бар
    public class ProgressBarMaterial : ProgressBar
    {
        public ProgressBarMaterial()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 2; // A single inset value to control teh sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(this.Width, this.Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                    if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

                    LinearGradientBrush brush = new LinearGradientBrush(rect, this.BackColor, this.ForeColor, LinearGradientMode.Vertical);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                }
            }
        }
    }
}