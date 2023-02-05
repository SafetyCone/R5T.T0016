using System;


namespace R5T.T0016
{
    public class HtmlTags : IHtmlTags
    {
        #region Infrastructure

        public static IHtmlTags Instance { get; } = new HtmlTags();


        private HtmlTags()
        {
        }

        #endregion
    }
}
