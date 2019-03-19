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

        // Metodos para manejar los puntos
        // Metodo de incremento
        private void pointIncrement(Control lab, string val)
        {
            int valInt = Convert.ToInt32(val);
            valInt = valInt + 1;
            lab.Text = Convert.ToString(valInt);
        }

        // Metodo de decremento
        private void pointDecrement(Control lab, string val)
        {
            int valInt = Convert.ToInt32(val);
            valInt = valInt - 1;
            if (valInt < 0)            
                valInt = 0;
            
            lab.Text = Convert.ToString(valInt);
        }

        // Metodo para actualizar los puntos en los sets
        private void updatePointSet(Control lab, string val)
        {
            lab.Text = val;
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
            // Nombre equipos -- Setiando los nombres cortos desde el valor en el App.config
            winsockCall.wsSendData("[Eq1]=" + commones.GetValueConfig(cbxLocal.Text).Substring(0, 3) + "\r\n");
            winsockCall.wsSendData("[Eq2]=" + commones.GetValueConfig(cbxEqVisitante.Text).Substring(0, 3) + "\r\n");

        }

        private void cbxEqVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

            winsockCall.wsSendData("[Logo2]=" + cbxEqVisitante.Text + ".png" + "\r\n");
            winsockCall.wsSendData("[HomeLong2]=" + commones.GetValueConfig(cbxEqVisitante.Text) + "\r\n");
            winsockCall.wsSendData("[Eq2]=" + commones.GetValueConfig(cbxEqVisitante.Text).Substring(0, 3) + "\r\n");
        }

        private void btnPlusLocal_Click(object sender, EventArgs e)
        {
            pointIncrement(lblPtsLoc, lblPtsLoc.Text);
            winsockCall.wsSendData("[Pts1]=" + lblPtsLoc.Text + "\r\n");
        }

        private void btnMinusLocal_Click(object sender, EventArgs e)
        {
            pointDecrement(lblPtsLoc, lblPtsLoc.Text);
            winsockCall.wsSendData("[Pts1]=" + lblPtsLoc.Text + "\r\n");
        }

        private void btnPlusVisitante_Click(object sender, EventArgs e)
        {
            pointIncrement(lblPtsVis, lblPtsVis.Text);
            winsockCall.wsSendData("[Pts2]=" + lblPtsVis.Text + "\r\n");
        }

        private void btnMinusVisitante_Click(object sender, EventArgs e)
        {
            pointDecrement(lblPtsVis, lblPtsVis.Text);
            winsockCall.wsSendData("[Pts2]=" + lblPtsVis.Text + "\r\n");
        }

        private void lblPtsLoc_TextChanged(object sender, EventArgs e)
        {           

            switch (numericUpDown1.Value)
            {
                case 1:
                    {
                        updatePointSet(lblSet1Loc, lblPtsLoc.Text);
                        break;
                    }
                case 2:
                    {
                        updatePointSet(lblSet2Loc, lblPtsLoc.Text);
                        break;
                    }
                case 3:
                    {
                        updatePointSet(lblSet3Loc, lblPtsLoc.Text);
                        break;
                    }
                case 4:
                    {
                        updatePointSet(lblSet4Loc, lblPtsLoc.Text);
                        break;
                    }
                case 5:
                    {
                        updatePointSet(lblSet5Loc, lblPtsLoc.Text);
                        break;
                    }
                default:
                    break;
            }            
        }

        private void lblPtsVis_TextChanged(object sender, EventArgs e)
        {            

            switch (numericUpDown1.Value)
            {
                case 1:
                    {
                        updatePointSet(lblSet1Vis, lblPtsVis.Text);
                        break;
                    }
                case 2:
                    {
                        updatePointSet(lblSet2Vis, lblPtsVis.Text);
                        break;
                    }
                case 3:
                    {
                        updatePointSet(lblSet3Vis, lblPtsVis.Text);
                        break;
                    }
                case 4:
                    {
                        updatePointSet(lblSet4Vis, lblPtsVis.Text);
                        break;
                    }
                case 5:
                    {
                        updatePointSet(lblSet5Vis, lblPtsVis.Text);
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int ptsLoc, ptsVis;
            ptsLoc = Convert.ToInt32(lblPtsLoc.Text);
            ptsVis = Convert.ToInt32(lblPtsVis.Text);
            if (ptsLoc > ptsVis)
            {
                int temp = Convert.ToInt32(lblSetWinnerLoc.Text);
                temp = temp + 1;
                lblSetWinnerLoc.Text = Convert.ToString(temp);
            } else if (ptsVis > ptsLoc)
            {
                int temp = Convert.ToInt32(lblSetWinnerVis.Text);
                temp = temp + 1;
                lblSetWinnerVis.Text = Convert.ToString(temp);
            }

            lblPtsLoc.Text = "0";
            lblPtsVis.Text = "0";

            switch (numericUpDown1.Value)
            {
                case 1:
                    {
                        lblSet1Loc.Text = Convert.ToString(ptsLoc);
                        lblSet1Vis.Text = Convert.ToString(ptsVis);
                        break;
                    }
                case 2:
                    {
                        lblSet2Loc.Text = Convert.ToString(ptsLoc);
                        lblSet2Vis.Text = Convert.ToString(ptsVis);
                        break;
                    }
                case 3:
                    {
                        lblSet3Loc.Text = Convert.ToString(ptsLoc);
                        lblSet3Vis.Text = Convert.ToString(ptsVis);
                        break;
                    }
                case 4:
                    {
                        lblSet4Loc.Text = Convert.ToString(ptsLoc);
                        lblSet4Vis.Text = Convert.ToString(ptsVis);
                        break;
                    }
                case 5:
                    {
                        lblSet5Loc.Text = Convert.ToString(ptsLoc);
                        lblSet5Vis.Text = Convert.ToString(ptsVis);
                        break;
                    }
                default:
                    break;
            }

            
            if (numericUpDown1.Value <= 4)
            {
                numericUpDown1.Value++;
            }


            ptsLoc = 0; ptsVis = 0;

        }

        private void lblSet1Loc_MouseHover(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(lblSet1Loc, "Click derecho para incrementar, izquierdo para disminuir");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            switch (numericUpDown1.Value)
            {
                case 1:
                    {
                        lblPtsLoc.Text = lblSet1Loc.Text;
                        lblPtsVis.Text = lblSet1Vis.Text;
                        break;
                    }
                case 2:
                    {
                        lblPtsLoc.Text = lblSet2Loc.Text;
                        lblPtsVis.Text = lblSet2Vis.Text;
                        break;
                    }
                case 3:
                    {
                        lblPtsLoc.Text = lblSet3Loc.Text;
                        lblPtsVis.Text = lblSet3Vis.Text;
                        break;
                    }
                case 4:
                    {
                        lblPtsLoc.Text = lblSet4Loc.Text;
                        lblPtsVis.Text = lblSet4Vis.Text;
                        break;
                    }
                case 5:
                    {
                        lblPtsLoc.Text = lblSet5Loc.Text;
                        lblPtsVis.Text = lblSet5Vis.Text;
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnScorebox_Click(object sender, EventArgs e)
        {
            string pathProjects = commones.GetValueConfig("pathProjectXML");

            winsockCall.wsSendData("[Set1]=" + lblSetWinnerLoc.Text + "\r\n");
            winsockCall.wsSendData("[Set2]=" + lblSetWinnerVis.Text + "\r\n");

            winsockCall.wsSendData("[Pts1]=" + lblPtsLoc.Text + "\r\n");
            winsockCall.wsSendData("[Pts2]=" + lblPtsVis.Text + "\r\n");

            if (btnScorebox.BackColor == Color.Lime)
            {
                winsockCall.wsSendData(PROJECT_START + pathProjects + "\\Scorebug.xml" + "\r\n");
                btnScorebox.BackColor = Color.Red;
            }
            else
            {
                winsockCall.wsSendData(PROJECT_STOP + pathProjects + "\\Scorebug.xml" + "\r\n");
                btnScorebox.BackColor = Color.Lime;
            }
        }
    }
}
