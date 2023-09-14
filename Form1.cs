using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1<TEntity> : Form
        where TEntity : class, new()
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Base form here, button1 pressed");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Base form here, button2 pressed");
        }
    }
}
