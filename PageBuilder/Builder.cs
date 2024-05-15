using PageBuilder.Interfaces;
using PageBuilder.Products.DocBook;
using PageBuilder.Products.HTML;
using PageBuilder.Factories;
using System.Diagnostics;

namespace PageBuilder
{


    public partial class Builder : Form
    {
        //default to HTML, we love html
        private IFactory factory = new HTMLFactory();
        private List<IElement> elements = new List<IElement>();
        public Builder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Paradd_Click(object sender, EventArgs e)
        {
            elements.Add(factory.create_paragraph(paraContent.Text, paraSize.Text, ColorToHex(paraColor.Color), paraAlign.Text));
            renderElements();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factory = new HTMLFactory();
            hTMLToolStripMenuItem.Checked = true;
            docBookToolStripMenuItem.Checked = false;
            ClearScreen();
        }

        private void docBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factory = new DocBookFactory();
            docBookToolStripMenuItem.Checked = true;
            hTMLToolStripMenuItem.Checked = false;
            ClearScreen();
        }

        private void ClearScreen()
        {
            elements.Clear();
            OutBox.Clear();

        }

        private void renderElements()
        {
            string output = "";
            foreach (IElement element in elements)
            {
                output += element.render() + "\n";
            }
            OutBox.Text = output;
        }

        private void Undo()
        {
            if (elements.Count > 0)
            {
                elements.RemoveAt(elements.Count - 1);
                renderElements();
            }
        }


        private string ColorToHex(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private void Imadd_Click(object sender, EventArgs e)
        {
            if (DefaultSizeToggle.Checked)
            {
                elements.Add(factory.create_image(ImgUrlBox.Text, "auto", "auto", ImageAlign.Text));
            }
            else
            {
                elements.Add(factory.create_image(ImgUrlBox.Text, WidthUpDown.Text, HeightUpDown.Text, ImageAlign.Text));
            }
            renderElements();

        }

        private void Linkadd_Click(object sender, EventArgs e)
        {
            elements.Add(factory.create_link(contentBox.Text, hrefBox.Text, alignBoxLink.Text, linkStyle.Text));
            renderElements();

        }

        private void Headadd_Click(object sender, EventArgs e)
        {
            elements.Add(factory.create_heading(ContentHead.Text, HeadLevelUpDown.Text, ColorToHex(headerColor.Color), alignmentComb.Text));
            renderElements();
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            //save to file and open the file in browser
            string path = Path.GetTempPath() + "pagebuilderpreview" + factory.filesuffix;
            //if it doesnt exist, create file
            File.Create(path).Dispose();
            File.WriteAllText(path, OutBox.Text);
            //open the file
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });

        }

        private void CopyToClip_Click(object sender, EventArgs e)
        {
            //copy text to clipboard
            Clipboard.SetText(OutBox.Text);
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void paraColorPick_Click(object sender, EventArgs e)
        {
            //open color picker dialog
            paraColor.ShowDialog();

        }

        private void ColorOptionBox_Click(object sender, EventArgs e)
        {
            paraColor.ShowDialog();
        }

        private void HeightUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void docBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            factory = new DocBookFactory();
            docBookToolStripMenuItem.Checked = true;
            hTMLToolStripMenuItem.Checked = false;
            ClearScreen();
        }
    }
}
