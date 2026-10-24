using System.Configuration;
using System;
using System.Collections.Specialized;

namespace Bingo
{
    public class ValidateAppSettings
    {

        public static bool ValidateChurchName(IWin32Window owner)
        {

            string? nameChurchSettings = ConfigurationManager.AppSettings.Get("nameChurch");

            if (nameChurchSettings == "SEM_VALOR_DEFINIDO")
            {
                using var dlg = new Views.SaveChurchName();
                return dlg.ShowDialog(owner) == DialogResult.OK;
            }

            return true;

        }

    }
}
