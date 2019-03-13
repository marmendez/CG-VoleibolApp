using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_VoleibolApp
{
    public partial class frmLives : Form
    {
        public frmLives()
        {
            InitializeComponent();
        }

        private frmDashboard winsockCall = new frmDashboard();

        private Commons commones = new Commons();

        const string PROJECT_LOAD = "*PROJECT_LOAD*";
        const string PROJECT_CLOSE = "*PROJECT_CLOSE*";
        const string PROJECT_START = "*PROJECT_PLAY*";
        const string PROJECT_STOP = "*PROJECT_STOP*";
        const string PROJECT_PAUSE = "*PROJECT_PAUSE*";
        const string PROJECT_RESUME = "*PROJECT_RESUME*";
        const string PROJECT_FFW = "*PROJECT_FFW*";

        private void cbTeamsFill(ComboBox comboBox, string ffn)
        {
            using (StreamReader red = new StreamReader(ffn))
            {
                while (red.Peek() >= 0)
                {
                    comboBox.Items.Add(red.ReadLine());
                }
            }
        }

        

        private void frmLives_Load(object sender, EventArgs e)
        {

            // Buscamos el nombre del archivo que contine los nombres de los equipos
            string fullFileName = commones.GetValueConfig("pathTeamsNamesFolder");

            // Rellenamos los combobox con los nombres de los equipos
            cbTeamsFill(cbxEqVisitante, fullFileName);
            cbTeamsFill(cbxLocal, fullFileName);

            winsockCall.wsConnect(commones.GetValueConfig("ipServer"), Convert.ToInt16(commones.GetValueConfig("portServer")));
            
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            string pathProjects = commones.GetValueConfig("pathProjectXML");

            if (btnMatch.BackColor == Color.Lime)
            {
                winsockCall.wsSendData(PROJECT_START + pathProjects + "\\Match.xml" + "\r\n");
                btnMatch.BackColor = Color.Red;
            } else
            {
                winsockCall.wsSendData(PROJECT_STOP + pathProjects + "\\Match.xml" + "\r\n");
                btnMatch.BackColor = Color.Lime;
            }
            
            

        }

        private void cbxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathProjects = commones.GetValueConfig("pathProjectXML");

            // Cargar los proyectos
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Match.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Sexteto.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Scorebug.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Pizarra.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Full.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Info.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\LowerthirdGen.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\LowerthirdLargo.xml" + "\r\n");
            winsockCall.wsSendData(PROJECT_LOAD + pathProjects + "\\Mosca.xml" + "\r\n");


            // Definir variables iniciales
            winsockCall.wsSendData("[Logo1]=" + cbxLocal.Text + ".png" + "\r\n");
            winsockCall.wsSendData("[Logo2]=" + cbxEqVisitante.Text + ".png" + "\r\n");
            // Fecha
            var dateSystem = DateTime.Now;
            string dateConverted;
            dateConverted = string.Format("{0:D}", dateSystem);
            winsockCall.wsSendData("[Date]=" + dateConverted + "\r\n");
            // Nombre equipos -- Buscando los nombres largos desde el valor en el App.config
            winsockCall.wsSendData("[HomeLong1]=" + commones.GetValueConfig(cbxLocal.Text) + "\r\n");
            winsockCall.wsSendData("[HomeLong2]=" + commones.GetValueConfig(cbxEqVisitante.Text) + "\r\n");

        }

        private void cbxEqVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

            winsockCall.wsSendData("[Logo2]=" + cbxEqVisitante.Text + ".png" + "\r\n");
            winsockCall.wsSendData("[HomeLong2]=" + commones.GetValueConfig(cbxEqVisitante.Text) + "\r\n");
        }
    }
}
