using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageBuilder.Interfaces
{
    internal interface IFactory
    {
        public string filesuffix { get; }
        public IElement create_paragraph(string content, string size, string color, string align);
        public IElement create_heading(string content, string level, string color, string align);
        public IElement create_image(string path, string width, string height, string align);
        public IElement create_link(string content, string url, string align, string styleType);
    }
}
