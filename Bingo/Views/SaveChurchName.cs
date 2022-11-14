using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo.Views
{
    public partial class SaveChurchName : Form
    {
        public SaveChurchName()
        {
            InitializeComponent();
        }

        private void Btn_SaveNameChurch_Click(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            config.AppSettings.Settings.Remove("nameChurch");
            config.AppSettings.Settings.Add("nameChurch", this.txb_NameChurch.Text);
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("appSettings");

        }
    }
}
