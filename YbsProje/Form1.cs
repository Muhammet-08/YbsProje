namespace YbsProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (textBox1.Text == "muhammet" && textBox2.Text == "bayrak" || textBox1.Text == "�mer" && textBox2.Text == "g�le�")
            {
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� AdI veya �ifre hatal�!");
            }

            
        }
    }
}