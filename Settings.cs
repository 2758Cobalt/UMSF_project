

using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.XPath;
using System.Xml;
using System.Windows.Forms;

namespace project1
{
    public partial class Settings : Form
    {
        // находит открытую (скрытую) форму
        public Settings()
        {
            InitializeComponent();
        }
        byte age;
        double weigth, height, physicalActivity;
        bool state;
        public void ChangeTheme(bool theme = false)
        {
            if (theme == true)
            {
                this.BackgroundImage = FitWat.Properties.Resources.bg_StartPanel;
                MenuBar.BackColor = Color.FromArgb(99, 44, 122);
                BottomBorderPanel1.BackColor = Color.FromArgb(163, 55, 122);

                label7.BackColor = Color.FromArgb(163, 55, 122);
                label1.BackColor = label7.BackColor;
                label2.BackColor = label7.BackColor;
                label3.BackColor = label7.BackColor;
                label4.BackColor = label7.BackColor;
                label5.BackColor = label7.BackColor;
                label6.BackColor = label7.BackColor;
                label8.BackColor = label7.BackColor;
                label9.BackColor = label7.BackColor;

                tbx_age.BackColor = Color.FromArgb(196, 67, 147);
                tbx_height.BackColor = tbx_age.BackColor;
                tbx_phyact.BackColor = tbx_age.BackColor;
                tbx_weigth.BackColor = tbx_age.BackColor;
            }
            else
            {
                this.BackgroundImage = FitWat.Properties.Resources.bg_panel;
                MenuBar.BackColor = Color.FromArgb(95, 102, 207);
                BottomBorderPanel1.BackColor = Color.FromArgb(135, 109, 204);

                label1.BackColor = Color.FromArgb(95, 102, 207);
                label2.BackColor = label1.BackColor;
                label3.BackColor = label1.BackColor;
                label4.BackColor = label1.BackColor;
                label5.BackColor = label1.BackColor;
                label6.BackColor = label1.BackColor;
                label8.BackColor = label1.BackColor;
                label9.BackColor = label1.BackColor;
                label7.BackColor = Color.FromArgb(135, 109, 204);

                tbx_age.BackColor = Color.FromArgb(125, 135, 235);
                tbx_height.BackColor = tbx_age.BackColor;
                tbx_phyact.BackColor = Color.FromArgb(95, 102, 207);
                tbx_weigth.BackColor = tbx_age.BackColor;
            }

        }
        private void SaveData()
        {
            XmlDocument doc = new XmlDocument();
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
            if (File.Exists("data.xml")) // если существует данный файл
            {
                doc.Load("data.xml");// Загрузка файла
            }
            else
            {
                MessageBox.Show("Сохранений нет");
            }

            XPathNavigator navigator = doc.CreateNavigator();
            foreach (XPathNavigator nav in navigator.Select("//root"))
            {

                nav.MoveToFollowing("state", "");
                nav.SetValue(state.ToString());

                nav.MoveToFollowing("age", "");
                nav.SetValue(tbx_age.Text.ToString());

                nav.MoveToFollowing("height", "");
                nav.SetValue(tbx_height.Text.ToString());

                nav.MoveToFollowing("weigth", "");
                nav.SetValue(tbx_weigth.Text.ToString());

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
        private void LoadData()
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("data.xml")) // если существует данный файл
            {
                doc.Load("data.xml");// Загрузка файла
            }
            foreach (XmlNode node in doc.DocumentElement)
            {
                if (node.Name == "state") state = bool.Parse(node.InnerText);
                if (node.Name == "age") age = byte.Parse(node.InnerText);
                if (node.Name == "height") height = double.Parse(node.InnerText);
                if (node.Name == "weigth") weigth = double.Parse(node.InnerText);
                if (node.Name == "physactivity") physicalActivity = double.Parse(node.InnerText);
                if (node.Name == "timetosleep") TimeToSleep.Value = Convert.ToDateTime(node.InnerText);
                if (node.Name == "timewakeup") TimeWakeUp.Value = Convert.ToDateTime(node.InnerText);
            }
            if (state == true)
            {label8.Text = "Чоловіча";}
            else { label8.Text = "Жіноча"; }
            tbx_age.Text = age.ToString();
            tbx_height.Text = height.ToString();
            tbx_phyact.Text = physicalActivity.ToString();
            tbx_weigth.Text = weigth.ToString();

        }
        private void TextChanged_event(object sender, EventArgs e)
        {
            
            if(tbx_age.Text == "" && tbx_height.Text == "" && tbx_phyact.Text == "" && tbx_weigth.Text == "")
            {
                btn_apply.Enabled = false;
            }
            else { btn_apply.Enabled = true; }
        }

        private void ExitToMain(object sender, EventArgs e)
        {
            this.Hide();// Закрывает форму (срабатывает formclosed)
            Form main_form = Application.OpenForms[0];
            main_form.Show();// показывает скрытую форму
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;
            state = !state;
            switch (state)
            {
                case false:
                    label8.Text = "Жіноча";
                    break;
                case true:
                    label8.Text = "Чоловіча";
                    break;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            TimeToSleep.CustomFormat = "HH:mm";
            TimeWakeUp.CustomFormat = "HH:mm";
            LoadData();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            SaveData();
            Application.Restart();
        }
    }
}
