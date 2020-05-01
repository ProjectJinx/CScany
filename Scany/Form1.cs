using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scany
{
    public partial class FormLogin : Form
    {
        string server;
        string pass;

        public FormLogin()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            server = txtServer.Text;
            pass = txtPass.Text;
            if (server != "" && pass != "")
            {
                Auth a = new Auth(txtPass.Text);
                string jsonstring = JsonConvert.SerializeObject(a);
                try
                {
                    WebRequest request = WebRequest.Create("https://" + server + "/Auth");
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.Method = "POST";


                    StreamWriter streamWriter = new StreamWriter(request.GetRequestStream());
                    streamWriter.Write(pass);

                    var httpResponse = (HttpWebResponse)request.GetResponse();
                    StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());
                    var result = streamReader.ReadToEnd();
                    MessageBox.Show(result);
                    lbStat.Text = "Connected";
                    lbStat.ForeColor = Color.LimeGreen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        #region Labels
        private void lbPass_Click(object sender, EventArgs e)
        {

        }

        private void lbServer_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbStat_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
