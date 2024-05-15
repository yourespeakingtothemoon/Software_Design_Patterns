using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;

namespace PageBuilder.Products.DocBook
{
    internal class DocBookLink : IElement
    {
        private string url;
        private string text;
        private string styleType;
        private string align;

        public DocBookLink(string url, string text, string styleType, string align)
        {
            this.url = url;
            this.text = text;
            this.styleType = styleType;
            this.align = align;
        }

        public string render()
        {
            switch (styleType)
            {
                case "Button":
                    return "<button href=\"" + url + "\" style=\"text-align: " + align + ";\">" + text + "</button>";
                case "Text":
                    return "<link href=\"" + url + "\" style=\"text-align: " + align + ";\">" + text + "</link>";
                default:
                    return "<link href=\"" + url + "\" style=\"text-align: " + align + ";\">" + text + "</link>";
            }
        }
    }
}
