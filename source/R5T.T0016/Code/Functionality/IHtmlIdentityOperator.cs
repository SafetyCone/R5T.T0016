using System;

using R5T.T0132;


namespace R5T.T0016
{
    [FunctionalityMarker]
    public partial interface IHtmlIdentityOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Gets the HTML ID for an HTML heading value.
        /// This is useful for identifying headings in an HTML page, such that they can be linked to from other locations on the page.
        /// </summary>
        /// <remarks>
        /// ID and NAME tokens must begin with a letter ([A-Za-z]) and may be followed by any number of letters, digits ([0-9]), hyphens ("-"), underscores ("_"), colons (":"), and periods (".").
        /// Source: https://www.w3.org/TR/html4/types.html#:~:text=ID%20and%20NAME%20tokens%20must,periods%20(%22.%22).
        /// </remarks>
        public string GetHeadingIdentity(string headingValue)
        {
            // For now, just return the heading value with spaces exchanged for dashes.
            var output = headingValue.Replace(
                Instances.Characters.Space,
                Instances.Characters.Dash);

            return output;
        }
    }
}
