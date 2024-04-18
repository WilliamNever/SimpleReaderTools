using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.BaseClasses
{
    public class FormBase : Form
    {
        private readonly float defaultFontSize = 14;
        private Font defaultFont;

        protected void SetDefaultFontForTxtContent(TextBox txtContents)
        {
            defaultFont = new Font(FontFamily.GenericSerif, defaultFontSize, FontStyle.Regular, GraphicsUnit.Point);
            txtContents.ForeColor = Color.Black;
            SetFontSizeInTextContent(defaultFontSize, txtContents);
        }

        protected void SetFontSizeInTextContent(float FSize, TextBox txtContents)
        {
            if (FSize > 0)
            {
                txtContents.Font = new Font(defaultFont.FontFamily, FSize,
                    (defaultFont.Bold ? FontStyle.Bold : FontStyle.Regular)
                    | (defaultFont.Italic ? FontStyle.Italic : FontStyle.Regular)
                    | (defaultFont.Strikeout ? FontStyle.Strikeout : FontStyle.Regular)
                    | (defaultFont.Underline ? FontStyle.Underline : FontStyle.Regular)
                    , defaultFont.Unit
                    /*GraphicsUnit.Point*/);
            }
        }

        protected void SetWrap(TextBox txtContents, bool isWrap)
        {
            txtContents.WordWrap = isWrap;
            txtContents.ScrollBars = isWrap ? ScrollBars.Vertical : ScrollBars.Both;
        }

        protected void SetDefaultFont(TextBox txtContents)
        {
            FontDialog fd = new FontDialog();
            fd.ShowEffects = true;
            fd.ShowColor = true;
            fd.AllowScriptChange = false;
            fd.ScriptsOnly = false;
            fd.Font = defaultFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                defaultFont = fd.Font;
                txtContents.Font = defaultFont;
                txtContents.ForeColor = fd.Color;
            }
        }

        protected string Control_DragDrop<CT>(CT sender, DragEventArgs e) where CT:Control
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var fp = files != null && files.Length > 0 ? files[0] : null;
            if (!string.IsNullOrWhiteSpace(fp))
            {
                using (StreamReader srReader = new StreamReader(fp, true))
                {
                    sender.Text = srReader.ReadToEnd();
                }
            }
            return fp;
        }

        protected DragEventArgs Control_DragEnter<CT>(CT sender, DragEventArgs e) where CT : Control
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
            return e;
        }

        protected void ControlHandler_DragDrop(object sender, DragEventArgs e)
        {
            Control_DragDrop(sender as Control, e);
        }

        protected void ControlHandler_DragEnter(object sender, DragEventArgs e)
        {
            Control_DragEnter(sender as Control, e);
        }

    }
}
