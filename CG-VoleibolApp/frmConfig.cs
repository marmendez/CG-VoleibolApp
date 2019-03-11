using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;




namespace CG_VoleibolApp
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private Commons commones = new Commons();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                

        private void frmConfig_Load(object sender, EventArgs e)
        {
            // Buscar el valor del key que corresponde al folder de conf. principal y asignarlo al textbox
            txtbPlayersFolder.Text = commones.GetValueConfig("pathPlayersNamesFolder");
            txtbTeamsFolder.Text = commones.GetValueConfig("pathTeamsNamesFolder");
        }

        private void btnFindFolderTeams_Click(object sender, EventArgs e)
        {
            // Creamos y configuramos el cuadro de dialogo de busqueda del archivo
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.ShowDialog();
            openFD.Title = "Abrir Archivos de Nombres de Equipos";
            openFD.DefaultExt = "txt";
            openFD.InitialDirectory = @"C:\";
            openFD.RestoreDirectory = true;
            openFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFD.Multiselect = false;
            txtbTeamsFolder.Text = openFD.FileName;

            // Configuramos el archivo de configuracion
            commones.UpdateValueConfig("pathTeamsNamesFolder", txtbTeamsFolder.Text);
        }

        private void btnFindFolderPlayer_Click(object sender, EventArgs e)
        {
            // Creamos y configuramos el cuadro de dialogo de busqueda del archivo
            OpenFileDialog openFD2 = new OpenFileDialog();
            openFD2.ShowDialog();
            openFD2.Title = "Abrir Archivos de Nombres de Jugadores";
            openFD2.DefaultExt = "txt";
            openFD2.InitialDirectory = @"C:\";
            openFD2.RestoreDirectory = true;
            openFD2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFD2.Multiselect = false;
            txtbPlayersFolder.Text = openFD2.FileName;

            // Configuramos el archivo de configuracion
            commones.UpdateValueConfig("pathPlayersNamesFolder", txtbPlayersFolder.Text);
        }

        
    }
}
