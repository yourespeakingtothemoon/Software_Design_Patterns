using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;
using PageBuilder.Products.HTML;

namespace PageBuilder.Factories
{
    internal class HTMLFactory : IFactory
    {
        public string filesuffix { get; } = ".html";
        public IElement create_paragraph(string content, string size, string color, string align)
        {
            return new HTMLParagraph(content, size, color, align);
        }

        public IElement create_image(string path, string width, string height, string align)
        {
            return new HTMLImage(path, width, height, align);
        }

        public IElement create_heading(string content, string level, string color, string align)
        {
            return new HTMLHeader(content, level, color, align);
        }

        public IElement create_link(string content, string url, string align, string styleType)
        {
            return new HTMLLink(content, url, align, styleType);
        }

    }
}
