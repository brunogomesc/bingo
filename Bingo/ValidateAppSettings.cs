using System.Configuration;
using System;
using System.Collections.Specialized;

namespace Bingo
{
    public class ValidateAppSettings
    {

        private static void ValidateChurchName()
        {

            String? nameChurchSettings = ConfigurationManager.AppSettings.Get("nameChurch");

            //if (nameChurchSettings?.Length == 0)
            //{

            //    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            //    config.AppSettings.Settings.Remove("nameChurch");
            //    config.AppSettings.Settings.Add("nameChurch", this.tb_CampoNomeIgreja.Text);
            //    config.Save(ConfigurationSaveMode.Modified);
            //    ConfigurationManager.RefreshSection("appSettings");

            //}

        }

    }
}
