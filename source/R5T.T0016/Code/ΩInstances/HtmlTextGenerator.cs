using System;


namespace R5T.T0016
{
    public class HtmlTextGenerator : IHtmlTextGenerator
    {
        #region Infrastructure

        public static IHtmlTextGenerator Instance { get; } = new HtmlTextGenerator();


        private HtmlTextGenerator()
        {
        }

        #endregion
    }
}
