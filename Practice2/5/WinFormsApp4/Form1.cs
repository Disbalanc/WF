namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pounds = 0.453592;
            label2.Text = $"{Convert.ToDouble(textBox1.Text)}ф - это {Math.Round(Convert.ToDouble(textBox1.Text)/ Pounds,5)} кг";
        }
    }
}