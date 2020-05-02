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
using RestSharp;
using System.Security.Cryptography;

namespace Scany
{
    public partial class FormLogin : Form
    {
        string server;
        string pass;
        string[] errors = new string[] {"No", "None", "Wrongg"};

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
                string path;
                if (server.StartsWith("http"))
                    path = server;
                else
                    path = "https://" + server;
                
                string data = GetHash(pass);

                Requester.Init(path);
                Token tk = Requester.GetToken(data);

                if (errors.Contains(tk.token))
                    MessageBox.Show("Something went wrong");
                else
                { 
                    lbStat.Text = "Connected";
                    lbStat.ForeColor = Color.LimeGreen;

                    FormList formList = new FormList(path, tk);
                    formList.Show();
                }
            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private static string GetHash(string input)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2"));                    
                }
                return builder.ToString();
            }
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
