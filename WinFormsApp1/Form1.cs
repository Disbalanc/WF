namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            label4.Text = $"Среднее арефметическое введенных чисел = {(Convert.ToInt32(textBox1.Text)+ Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text))/3}";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}