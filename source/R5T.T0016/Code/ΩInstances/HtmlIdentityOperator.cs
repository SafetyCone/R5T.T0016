using System;


namespace R5T.T0016
{
    public class HtmlIdentityOperator : IHtmlIdentityOperator
    {
        #region Infrastructure

        public static IHtmlIdentityOperator Instance { get; } = new HtmlIdentityOperator();


        private HtmlIdentityOperator()
        {
        }

        #endregion
    }
}
