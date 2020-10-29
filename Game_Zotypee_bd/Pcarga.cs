using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Zotypee_bd
{
    public partial class Pcarga : Form
    {
        public Pcarga()
        {
            InitializeComponent();
        }

        private void Pcarga_Load(object sender, EventArgs e)
        {

            trespuntos.Parent = pictureBox1;
            trespuntos.BackColor = Color.Transparent;
        }
        public void Provarcarga()
        {
            CargaBar.Increment(1);
            trespuntos.Text = CargaBar.ToString() + "%";
            if (CargaBar.Value == CargaBar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                PMenu ff = new PMenu();
                ff.Show();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Provarcarga();
        }
    }
}
