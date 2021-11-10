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
    public partial class FormGOB : Form

    {
   
        


        string url = "https://jsonplaceholder.typicode.com/users";
        public FormGOB()
        {
            InitializeComponent();
           
        }
        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void FormGOB_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<GetDataGob> lst = JsonConvert.DeserializeObject<List<GetDataGob>>(respuesta);
            dataGridView1.DataSource = lst;

        }

        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
