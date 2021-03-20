using System;
using System.Collections.Generic;
using System.Text;

namespace FreelancehuntApiClient
{
    public enum Language
    {
        En,
        Uk,
        Ru
    }

    public static class LanguageExtensions
    {
        public static string ToAcceptLanguageValue(this Language language)
        {
            switch (language)
            {
                case Language.En: 
                    return "en";

                case Language.Uk: 
                    return "uk";

                case Language.Ru: 
                    return "ru";

                default: 
                    throw new NotImplementedException();
            }
        }
    }
}
