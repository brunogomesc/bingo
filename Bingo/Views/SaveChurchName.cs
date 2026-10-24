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

            string churchName = this.txb_NameChurch.Text.Trim();
            if (string.IsNullOrWhiteSpace(churchName))
            {
                MessageBox.Show(this, "Informe o nome da igreja.", "Nome da igreja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Remove("nameChurch");
                config.AppSettings.Settings.Add("nameChurch", churchName);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) when (ex is ConfigurationErrorsException
                || ex is UnauthorizedAccessException
                || ex is System.IO.IOException
                || ex is System.Security.SecurityException)
            {
                MessageBox.Show(this, "Não foi possível salvar o nome da igreja. Verifique a permissão de escrita na pasta do aplicativo e tente novamente.", "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
