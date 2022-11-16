
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitWat
{
    public partial class History : Form
    {
        ushort counter = 0;
        public History()
        {
            InitializeComponent();
        }
        public void AddColumn(string result,bool daily = false)
        {
            Random rand = new Random();
            var num = rand.Next(0, 2);
            dataGridView1.Rows.Add((DateTime.Now.Hour + ":" + DateTime.Now.Minute).ToString(),++counter,result);
            if (daily == true)
            {
                label3.Visible = true;
                label4.Visible = true;
                label4.Text = "Норма виконана";
                switch (num)
                {
                    case 0:
                        
                        label3.Text = "Молодець! Непогано йдеш";
                        break;
                    case 1:
                        label3.Text = "Ви зробили чудову роботу! \nприходьте завтра";
                        break;
                    case 2:
                        label3.Text = "Ще один крок до покращення, молодець";
                        break;
                }

            }
        }
        public void ChangeTheme(bool theme = false)
        {
            if(theme == true)
            {
                this.BackgroundImage = FitWat.Properties.Resources.bg_StartPanel;
                MenuBar2.BackColor = Color.FromArgb(99, 44, 122);
                BottomBorderPanel1.BackColor = Color.FromArgb(163, 55, 122);

                label2.BackColor = Color.FromArgb(163, 55, 122);
                label1.BackColor = label2.BackColor;
                panel1.BackColor = Color.FromArgb(100, 154, 67, 159);

                dataGridView1.BackgroundColor = Color.FromArgb(194, 123, 209);
            }
            else
            {
                this.BackgroundImage = FitWat.Properties.Resources.bg_panel;
                MenuBar2.BackColor = Color.FromArgb(95, 102, 207);
                BottomBorderPanel1.BackColor = Color.FromArgb(135, 109, 204);
                dataGridView1.BackgroundColor = Color.FromArgb(150, 150, 250);
                label2.BackColor = Color.FromArgb(135, 109, 204);
                label1.BackColor = Color.FromArgb(150, 150, 250);
                panel1.BackColor = Color.FromArgb(100, 120, 120, 220);
            }
            
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();// Закрывает форму (срабатывает formclosed)
            Form main_form = Application.OpenForms[0];
            main_form.Show();// показывает скрытую форму
        }

        private void History_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
