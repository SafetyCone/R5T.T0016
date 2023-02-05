using System;

using R5T.T0131;


namespace R5T.T0016
{
    [ValuesMarker]
    public partial interface IHtmlTags : IValuesMarker
    {
        public const string button = "button";
        public const string Button = IHtmlTags.button;
        public const string div = "div";
        public const string Divider = IHtmlTags.div;
        public const string img = "img";
        public const string Image = IHtmlTags.img;
        public const string span = "span";
        public const string Span = IHtmlTags.span;
    }
}
