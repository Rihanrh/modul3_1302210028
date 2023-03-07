namespace modul3_1302210028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int angka1, angka2, jumlah;

        private void button1_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 5;
        }

        private void outputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            outputbox.Text = outputbox.Text + 0;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            angka2 = Convert.ToInt32(outputbox.Text);
            jumlah = angka1 + angka2;
            outputbox.Clear();
            outputbox.Text = outputbox.Text + jumlah;
            jumlah = 0;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToInt32(outputbox.Text);
            outputbox.Text = outputbox.Text + "+";
            outputbox.Clear();
        }
    }
}