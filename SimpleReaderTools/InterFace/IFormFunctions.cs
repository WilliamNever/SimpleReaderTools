using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleReaderTools.InterFace
{
    public interface IFormFunctions
    {
        void CopyTextToForm(string txt, bool isAppend, string winName);
        TextBox GetContentsBox();
        ToolStripStatusLabel GetWinWorkingStatus();
    }
}
