using System;

using R5T.T0131;


namespace R5T.T0016
{
    [ValuesMarker]
    public partial interface IHtmlTags : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        public string button => "button";
        public string div => "div";
        public string img => "img";
        public string span => "span";
#pragma warning restore IDE1006 // Naming Styles

        public string Button => this.button;
        public string Divider => this.div;
        public string Image => this.img;
        public string Span => this.span;
    }
}
