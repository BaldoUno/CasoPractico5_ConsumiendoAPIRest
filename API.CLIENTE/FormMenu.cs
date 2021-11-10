using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API.CLIENTE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        FormGOB gob  = new FormGOB();
        FormAMIIBO amiibo = new FormAMIIBO();
        FormCAT cat = new FormCAT();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            gob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            amiibo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            cat.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

