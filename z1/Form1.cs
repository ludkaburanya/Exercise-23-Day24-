namespace z1
{
    public partial class Form1 : Form
    {
        public int n0, n1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];

            n0 = 0;
            n1 = 0;

            foreach (Char c in str)
            {
                if (c== 48)
                    n0++;
                else if (c==49)
                    n1++;
            }

            label1.Text = "Количество 0 = " + n0;
            label2.Text = "Количество 1 = " + n1;
        }
    }
}