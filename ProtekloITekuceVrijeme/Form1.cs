using System.Windows.Forms;

namespace ProtekloITekuceVrijeme
{
    public partial class Form1 : Form
    {

        DateTime pocetno = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
                TimeSpan proteklo = new TimeSpan();
                proteklo = DateTime.Now - pocetno;
                this.toolStripStatusLabel1.Text = "Proteklo: " +
                proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }

        private void e(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}