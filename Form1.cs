namespace bankManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int money , saving ,total=0;

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            total = total + saving;
            label6.Text = total.ToString();
            saving = 0;
            label4.Text = saving.ToString();            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            saving = Convert.ToInt32(textBox2.Text);
            saving = money - saving;
            label4.Text = saving.ToString();
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(textBox1.Text);            
            label4.Text = money.ToString();
            textBox1.Text = "0";
        }
    }
}