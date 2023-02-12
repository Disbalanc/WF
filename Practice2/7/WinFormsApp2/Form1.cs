namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Operation_Click(object sender, EventArgs e)
        {
            if (listBox1.Items[0].ToString() == "Сложить")
            {
                label5.Text = $" {Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)}";
            }
            else if (listBox1.Items[1].ToString() == "Вычесть")
            {
                label5.Text = $" {Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)}";
            }
            else if (listBox1.Items[2].ToString() == "Умножить")
            {
                label5.Text = $" {Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)}";
            }
            else
            {
                label5.Text = $" {Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)}";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}