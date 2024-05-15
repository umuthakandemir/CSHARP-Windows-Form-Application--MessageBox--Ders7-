namespace MessageBoxUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "TIKLA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();

            result = MessageBox.Show("Butona Tıkladınız..", "UYarı", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
           if (result == DialogResult.Yes)
            {
                MessageBox.Show("yese tıkladın..");
            }else if(result == DialogResult.No)
            {
                MessageBox.Show("no ya tıkladın..");
            }
  
        }
    }
}
