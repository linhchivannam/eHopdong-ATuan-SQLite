using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eHopdong.PHUQUI
{
    partial class CauhinhHethong : Form
    {
        public CauhinhHethong()
        {
            InitializeComponent();
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (txt_server.Text.Length > 0)
            {
                try
                {
                    string connect = @"Data Source=" + txt_server.Text + ";Initial Catalog=" + txt_data.Text + ";User ID=" + txt_username.Text + ";Password=" + txt_pass.Text + ";MultipleActiveResultSets=True;App=EntityFramework";
                    ConfigSettings.UpdateAppSettings("PQKEY", MyAccess.Config.EncryptPass(connect));                   

                    Application.Exit();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }

            }
        }
    }
    class ConfigSettings
    {
        public static void UpdateAppSettings(string KeyName, string KeyValue)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings[KeyName].Value = KeyValue;
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
    }
}
