using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace API.CLIENTE
{
    public partial class FormAMIIBO : Form
    {


        DBApi dBApi = new DBApi();
        
        public FormAMIIBO()
        {
            InitializeComponent();
            
        }

        private void FormAMIIBO_Load(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.GetA("https://reqres.in/api/users?page=1");
            pictureBox1.ImageLocation = respuesta.data[1].avatar.ToString();
            textBox1.Text = respuesta.data[1].email.ToString();
            textBox2.Text = respuesta.data[1].first_name.ToString();
            textBox3.Text = respuesta.data[1].last_name.ToString();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
