﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReaderTools.InterFace
{
    public interface IFormFunctions
    {
        void CopyTextToForm(string txt, bool isAppend);
        System.Windows.Forms.TextBox GetContentsBox();
    }
}
