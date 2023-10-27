namespace FormApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text))
            {

                int sayi1 = Int32.Parse(textBox1.Text);
                int sayi2 = Int32.Parse(textBox2.Text);
                int sayi3 = Int32.Parse(textBox3.Text);

                if (sayi1 >= sayi2 && sayi1 >= sayi3)
                {
                    label2.Text = sayi1.ToString();
                }
                else if (sayi2 >= sayi1 && sayi2 >= sayi3)
                {
                    label2.Text = sayi2.ToString();
                }
                else if (sayi3 >= sayi1 && sayi3 >= sayi2)
                {
                    label2.Text = sayi3.ToString();
                }

            }
        }
    }
}