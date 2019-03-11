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

        private Commons commones = new Commons();

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
        }
    }
}
