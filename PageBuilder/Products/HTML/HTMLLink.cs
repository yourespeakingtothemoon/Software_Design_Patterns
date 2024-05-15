using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;

namespace PageBuilder.Products.HTML
{
    internal class HTMLLink : IElement
    {
        private string content;
        private string url;
        private string align;
        private string styleType;

        public HTMLLink(string content, string url, string align, string styleType)
        {
            this.content = content;
            this.url = url;
            this.align = align;
            this.styleType = styleType;
        }

        public string render()
        {
            switch (styleType)
            {
                case "Button":
                    return "<a style=\" padding: 10px 20px;\r\n    color: #000;\r\n    background-color: #C0C0C0;\r\n    border: 2px outset #C0C0C0;\r\n    text-decoration: none;\r\n    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;\r\n    text-align: center;\r\n    transition: background-color 0.2s ease-out, color 0.2s ease-out;\r\n    margin-left: 10px;\r\n    margin-right: 10px;\"" + align + ";\" href=\"" + url + "\">" + content + "</a>";
                case "Text":
                    return "<a href=\"" + url + "\" style=\"text-align: " + align + ";\">" + content + "</a>";
                default:
                    return "<a href=\"" + url + "\" style=\"text-align: " + align + ";\">" + content + "</a>";
            }
        }
    }
}
