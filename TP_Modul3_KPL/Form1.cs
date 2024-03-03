namespace TP_Modul3_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string inputan = InputUser.Text;
            OutputUser.Text = ("Halo " + inputan);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
