﻿using System.Configuration;
using System;
using System.Collections.Specialized;

namespace Bingo
{
    public class ValidateAppSettings
    {

        public static bool ValidateChurchName()
        {

            string? nameChurchSettings = ConfigurationManager.AppSettings.Get("nameChurch");

            if (nameChurchSettings == "SEM_VALOR_DEFINIDO")
            {
                Application.Run(new Views.SaveChurchName());
                return false;
            }

            return true;

        }

    }
}
