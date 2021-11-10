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
    public partial class FormCAT : Form
    {
       


        string url = "https://api.thecatapi.com/v1/images/search";
        public FormCAT()
        {
            InitializeComponent();
        }

        private async void FormCAT_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<GetDataCat> lst = JsonConvert.DeserializeObject<List<GetDataCat>>(respuesta);
            dataGridView1.DataSource = lst;

        }
        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
