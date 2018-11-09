using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;

namespace HangersAndSupports
{
    class HSCommand:Command
    {
        WindowManager _windowManager;
        public HSCommand(WindowManager windowManager)
        {
            _windowManager = windowManager;
            this.Key = "Aveva.HSCommand";
        }

        public override void Execute()
        {
            System.Windows.Forms.Form f = new HSForm();
            f.ShowInTaskbar = false;
            f.Owner = _windowManager.MainForm;
            f.TopMost = true;
            f.Icon = _windowManager.MainForm.Icon;
            f.Show();
        }
    }
}
