using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;

namespace PageBuilder.Products.HTML
{
    internal class HTMLImage : IElement
    {
        private string path;
        private string width;
        private string height;
        private string align;

        public HTMLImage(string path, string width, string height, string align)
        {
            this.path = path;
            this.width = width;
            this.height = height;
            this.align = align;
        }

        public string render()
        {
            return "<img src=\"" + path + "\" width=\"" + width + "%\" height=\"" + height + "%\" style=\"text-align: " + align + ";\" />";
        }
    }
}
