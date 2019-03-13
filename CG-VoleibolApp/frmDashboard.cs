using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CG_VoleibolApp
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        public void wsConnect(string ipServer, int portServer)
        {
            axWinsock1.Close();
            axWinsock1.RemoteHost = ipServer;
            axWinsock1.RemotePort = portServer;
            axWinsock1.Connect();
        }

        public void wsSendData(string dataCadena)
        {
            axWinsock1.SendData(dataCadena);
        }

        private void SetFocusStyle(Button mybotton)
        {
            mybotton.BackColor = Color.FromArgb(0, 29, 38);
        }

        private void LeaveFocusStyle(Button mybotton)
        {
            mybotton.BackColor = Color.FromArgb(0, 122, 204);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void OpenFormChild<frmChild>() where frmChild : Form, new()
        {
            Form childForm;
            childForm = pnlShowChild.Controls.OfType<frmChild>().FirstOrDefault();

            if (childForm == null)
            {
                childForm = new frmChild();
                childForm.TopLevel = false;
                pnlShowChild.Controls.Add(childForm);
                pnlShowChild.Tag = childForm;
                childForm.Show();
                childForm.BringToFront();
            } else
            {
                childForm.BringToFront();
            }
        }

        private void btnLives_Click(object sender, EventArgs e)
        {
            OpenFormChild<frmLives>();
            SetFocusStyle(this.btnLives);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenFormChild<frmConfig>();
            //SetFocusStyle(this.btnSetting);
        }
    }
}
