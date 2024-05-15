﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageBuilder.Interfaces;

namespace PageBuilder.Products.HTML
{
    internal class HTMLParagraph : IElement
    {
        private string content;
        private string size;
        private string color;
        private string align;

        public HTMLParagraph(string content, string size, string color, string align)
        {
            this.content = content;
            this.size = size;
            this.color = color;
            this.align = align;
        }

        public string render()
        {
            return "<p style=\"font-size: " + size + "; color: " + color + "; text-align: " + align + ";\">" + content + "</p>";
        }
    }
}