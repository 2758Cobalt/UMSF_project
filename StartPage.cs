using FitWat.Properties;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using Application = System.Windows.Forms.Application;

namespace project1
{
    public partial class StartPage : Form
    {
        byte age;
        double weigth, height, physicalActivity;
        bool firstStart,state;
        byte x = 100;
        public StartPage(){InitializeComponent();this.DoubleBuffered = true; }
        private void visibleObjects(byte idx,bool param)
        {
            if(idx == 0)// Первая панель
            {
                img1.Visible = img2.Visible = btn_grp1.Visible = param;
                panel3.Visible = param;
                label7.Visible = param;
            }
            if (idx == 1)// Вторая панель
            {
                label1.Visible = label2.Visible = label3.Visible = label4.Visible = param;
                btn_cancel1.Visible = btn_grp2.Visible = param;
                tbx_height.Visible = tbx_age.Visible = tbx_weigth.Visible = tbx_phyact.Visible = param;
                panel1.Visible = param;
                label11.Visible = param;
            }
            if (idx == 2)// Третья панель
            {
                TimeToSleep.Visible = TimeWakeUp.Visible = TimeToSleep.Visible = param;
                btn_apply.Visible = btn_cancel2.Visible = TimeToSleep.Visible = label5.Visible = label6.Visible = param;
                panel2.Visible = param;
                label10.Visible = param;
            }
            
        }
        private void btn_male_click(object sender, EventArgs e) {state = true; btn_grp1.Enabled = true; img1.BackColor = Color.FromArgb(67, 180, 101);
            img2.BackColor = Color.FromArgb(200,180, 67, 159);
            label8.BackColor = Color.FromArgb(67, 180, 101);
            label9.BackColor = Color.FromArgb(50,180, 67, 101);
        }
        private void btn_female_click(object sender, EventArgs e){state = false;btn_grp1.Enabled = true; img2.BackColor = Color.FromArgb(67, 180, 101);
            img1.BackColor = Color.FromArgb(200,180, 67, 159);
            label9.BackColor = Color.FromArgb(67, 180, 101);
            label8.BackColor = Color.FromArgb(50, 180, 67, 101);
        }
        private void panel_confirm(object sender, EventArgs e)// Первая панель
        {
            try
            {
                gpanel1.Width = 50;

                

                gpanel1.BackColor = Color.FromArgb(73, 255, 103);
                gpanel2.Width = 350;
                gpanel2.Location = new Point(100 + x, 100);

                gpanel3.Location = new Point(500 + x, 100);

                //Graphycs
                gpanel1.BackColor = Color.FromArgb(200,73, 255, 73);
                gpanel2.BackColor = Color.FromArgb(50, 154, 67, 159);
                visibleObjects(0, false);
                visibleObjects(1, true);
            }
            catch(FormatException)
            {
                MessageBox.Show("Введите все данные");
            }
        }
        private void panel2_confirm(object sender, EventArgs e)// Вторая панель
        {
            visibleObjects(1, false);
            visibleObjects(2, true);
            try
            {
                if (age != null || height != null || weigth != null ||(age != null && height != null && weigth != null))
                {
                    age = byte.Parse(tbx_age.Text);
                    height = Convert.ToDouble(tbx_height.Text);
                    weigth = Convert.ToDouble(tbx_weigth.Text);
                    switch (tbx_phyact.SelectedIndex)
                    {
                        case 0:
                            physicalActivity = 1.2;
                            break;
                        case 1:
                            physicalActivity = 1.375;
                            break;
                        case 2:
                            physicalActivity = 1.725;
                            break;
                        case 3:
                            physicalActivity = 1.9;
                            break;
                    }
                    gpanel2.Width = 50;
                    gpanel2.Location = new Point(100 + x, 100);
                    gpanel3.Width = 350;
                    gpanel3.Location = new Point(200 + x, 100);
                    //Graphycs
                    gpanel2.BackColor = Color.FromArgb(200, 73, 255, 73);
                    gpanel3.BackColor = Color.FromArgb(50, 154, 67, 159);
                }

            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }

        }
        private void StartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main_form = Application.OpenForms[0];// находит открытую (скрытую) формуation.OpenForms[0];
            main_form.Show();
        }
        private void cancel1_click(object sender, EventArgs e)//Cancel1
        {
            gpanel1.Width = 350;
            gpanel2.Width = 50;
            gpanel1.Location = new Point(30 + x, 100);
            gpanel2.Location = new Point(400 + x, 100);
            gpanel3.Location = new Point(500 + x, 100);

            gpanel2.BackColor = Color.FromArgb(200, 208, 255, 73); // yellow
            gpanel1.BackColor = Color.FromArgb(50, 154, 67, 159);//default
            visibleObjects(0, true);
            visibleObjects(1, false);
        }
        private void StartPage_Load(object sender, EventArgs e)
        {
            TimeToSleep.CustomFormat = "HH:mm";
            TimeWakeUp.CustomFormat = "HH:mm";
            gpanel1.Width = 350;

            gpanel1.Location = new Point(30 + x, 100);
            gpanel2.Location = new Point(400 + x, 100);
            gpanel3.Location = new Point(500 + x, 100);

            gpanel2.BackColor = Color.FromArgb(200,255, 73, 73);
            gpanel3.BackColor = Color.FromArgb(200, 255, 73, 73);
            visibleObjects(1, false);
            visibleObjects(2, false);
            

        }
        private void cancel2_click(object sender, EventArgs e)//Cancel2
        {
            gpanel3.Width = 50;
            gpanel2.Width = 350;

            gpanel2.Location = new Point(100 + x, 100);
            gpanel3.Location = new Point(500 + x, 100);

            gpanel2.BackColor = Color.FromArgb(50, 154, 67, 159);//default
            gpanel3.BackColor = Color.FromArgb(200, 208, 255, 73);//yellow
            visibleObjects(1, true);
            visibleObjects(2, false);
        }

        private void LeaveBtn(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (ArgumentOutOfRangeException)
            {
                age = 1;
                height = 1;
                weigth = 1;
                physicalActivity = 1.2;
                firstStart = true;
                SaveData();
            }
        }

        private void btn_grp1_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_grp1.Enabled)
            {
                btn_grp1.BackColor = Color.FromArgb(154, 67, 159);
            }
        }

        private void btn_grp2_EnabledChanged(object sender, EventArgs e)
        {
            if (btn_grp2.Enabled)
            {
                btn_grp2.BackColor = Color.FromArgb(154, 67, 159);
            }
        }

        private void tbx_phyact_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_grp2.Enabled = true;
        }

        private void SaveData()
        {
            XmlDocument doc = new XmlDocument();
            
            if (File.Exists("data.xml")) // если существует данный файл
            {
                doc.Load("data.xml");// Загрузка файла
            }
            else { MessageBox.Show("Сохранений нет");
            }

            XPathNavigator navigator = doc.CreateNavigator();
            foreach (XPathNavigator nav in navigator.Select("//root"))
            {
                nav.MoveToFollowing("fstart", "");
                nav.SetValue(firstStart.ToString());

                nav.MoveToFollowing("state", "");
                nav.SetValue(state.ToString());

                nav.MoveToFollowing("age", "");
                nav.SetValue(age.ToString());

                nav.MoveToFollowing("height", "");
                nav.SetValue(height.ToString());

                nav.MoveToFollowing("weigth", "");
                nav.SetValue(weigth.ToString());

                nav.MoveToFollowing("physactivity", "");
                nav.SetValue(physicalActivity.ToString());
                // Время -\
                nav.MoveToFollowing("timetosleep", "");
                nav.SetValue(TimeToSleep.Value.TimeOfDay.ToString());

                nav.MoveToFollowing("timewakeup", "");
                nav.SetValue(TimeWakeUp.Value.TimeOfDay.ToString());
            }
            doc.Save("data.xml");
        }
        private void apply_click(object sender, EventArgs e)// Apply
        {
            firstStart = false;
            SaveData();            
            this.Close();
            Application.Restart();
        }
        private void StartPage_Shown(object sender, EventArgs e)
        {
            
        }
    }
}