using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Configuration;

namespace CG_VoleibolApp
{
    public class Commons
    {
        public string GetValueConfig(string keyName)
        {
            string valueK = ConfigurationManager.AppSettings[keyName];

            return valueK;
        }


        public void UpdateValueConfig(string keyName, string descValue)
        {
            // Abrirlo en modo exe
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Remover el valor actual
            conf.AppSettings.Settings.Remove(keyName);
            // Agregar el key nuevamente con el nuevo valor
            conf.AppSettings.Settings.Add(keyName, descValue);
            // Guardar y refrescar el archivo de configuracion
            conf.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        
        
    }
}
