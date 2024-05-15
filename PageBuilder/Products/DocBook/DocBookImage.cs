using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;

namespace PageBuilder.Products.DocBook
{
    internal class DocBookImage : IElement
    {
        private string path;
        private string align;
        private string width;
        private string height;

        public DocBookImage(string path, string align, string width, string height)
        {
            this.path = path;
            this.align = align;
            this.width = width;
            this.height = height;
        }

        public string render()
        {
            return "<imagedata fileref=\"" + path + "\" align=\"" + align + "\" width=\"" + width + "%\" height=\"" + height + "%\" />";
        }
    }
}

