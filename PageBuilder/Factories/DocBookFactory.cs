using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;
using PageBuilder.Products.DocBook;

namespace PageBuilder.Factories
{
    internal class DocBookFactory : IFactory
    {
        public string filesuffix { get; } = ".xml";
        public IElement create_paragraph(string content, string size, string color, string align)
        {
            return new DocBookParagraph(content, size, color, align);
        }

        public IElement create_link(string url, string text, string styleType, string align)
        {
            return new DocBookLink(url, text, styleType, align);
        }

        public IElement create_image(string path, string align, string width, string height)
        {
            return new DocBookImage(path, align, width, height);
        }

        public IElement create_heading(string content, string level, string color, string align)
        {
            return new DocBookHeader(content, level, color, align);
        }

    }
    
}
