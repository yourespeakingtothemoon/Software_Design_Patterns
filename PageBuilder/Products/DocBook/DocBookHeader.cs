using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;

namespace PageBuilder.Products.DocBook
{
    internal class DocBookHeader : IElement
    {
        private string content;
        private string level;
        private string color;
        private string align;

        public DocBookHeader(string content, string level, string color, string align)
        {
            this.content = content;
            this.level = level;
            this.color = color;
            this.align = align;
        }

        public string render()
        {
           return "sect" + level + " style=\"color: " + color + "; text-align: " + align + ";\">" + "<title>" + content + "</title>" + "</sect" + level + ">";
        }
    }
}

