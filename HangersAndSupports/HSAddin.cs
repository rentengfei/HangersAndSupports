using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aveva.ApplicationFramework;
using Aveva.ApplicationFramework.Presentation;

namespace HangersAndSupports
{
    class HSAddin:IAddin
    {
        public string Name { get { return "HangersAndSupports"; } }

        public string Description { get { return "HangersAndSupports"; } }

        public void Start(ServiceManager serviceManager)
        {
            WindowManager windowManager = (WindowManager)serviceManager.GetService(typeof(WindowManager));
            CommandManager commandManager = (CommandManager)serviceManager.GetService(typeof(CommandManager));
            HSCommand hsCommand = new HSCommand(windowManager);
            commandManager.Commands.Add(hsCommand);
            CommandBarManager commandBarManager = (CommandBarManager)serviceManager.GetService(typeof(CommandBarManager));
            commandBarManager.AddUICustomizationFile(@"C:\AVEVA\Plant\PDMS12.1.SP4\HangersAndSupports.uic", "HangersAndSupports");
       }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
