using System;
using System.Collections.Generic;
using System.Drawing;
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
    }
}
