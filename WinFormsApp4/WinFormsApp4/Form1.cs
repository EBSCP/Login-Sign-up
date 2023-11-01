namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textMail.Text == "acc@gmail.com")
            {
                if (textPassword.Text == "1234")
                {
                    MessageBox.Show("Hello To Tab 2");
                    tabControl1.SelectTab(1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textName.Text == "Ali")
            {
                if (textLastName.Text == "Veli" && textLastName.Text.Length < 5)
                {

                    MessageBox.Show("Welcome To the Apply");

                    TabPage tabPage = new TabPage();
                    tabPage.Text = "Apply : 21212";
                    tabPage.BackColor = Color.Green;

                    Label label5 = new Label();
                    label5.Text = "Hello Ali Veli";
                    label5.ForeColor = Color.White;
                    label5.Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
                    label5.Width = 350;

                    tabPage.Controls.Add(label5);

                    tabControl1.TabPages.Add(tabPage);
                    tabControl1.SelectedIndex = 2;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            progressBar1.Value = progressBar1.Value + 1 > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Value + 1;
            lblTimer.Text = count.ToString();

            if (count <=0)
            {
                Random random = new Random();
                Login.Location = new Point(random.Next(0, Size.Width), random.Next(0, Size.Height));
               
            }
            if(count == 0) { 
             MessageBox.Show("You couldnt Login ...Again start");
            }
        }
    }
}