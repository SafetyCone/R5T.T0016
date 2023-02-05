using System;

using R5T.T0132;


namespace R5T.T0016
{
    [FunctionalityMarker]
    public partial interface IHtmlTextGenerator : IFunctionalityMarker
    {
        public string GetCopyrightText(string copyrightHolderName)
        {
            var currentYear = Instances.NowOperator.GetCurrentYear();

            var output = $"&copy; {currentYear} {copyrightHolderName}. All rights reserved.";
            return output;
        }
    }
}
