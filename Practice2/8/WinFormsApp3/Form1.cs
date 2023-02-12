namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Operation_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Text = $" {((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text)) / Convert.ToInt32(textBox2.Text))* 200}";
            } else
            label4.Text = $" {(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)) / Convert.ToInt32(textBox3.Text)*100}";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}