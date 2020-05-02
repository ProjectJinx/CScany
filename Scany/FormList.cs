using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scany
{
    public partial class FormList : Form
    {
        List<Device> devices;
        Token token;
        string server;

        public FormList(string srv, Token tk)
        {
            InitializeComponent();
            token = tk;
            server = srv;
            
        }

        private void FormList_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void dataDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dataDevices.Rows.Clear();
            devices = Requester.GetDevices();
            foreach (Device d in devices)
            {
                dataDevices.Rows.Add(d.ip, d.mac, d.firstconnect, d.lastconnect);
            }
            dataDevices.Update();
        }
    }
}
