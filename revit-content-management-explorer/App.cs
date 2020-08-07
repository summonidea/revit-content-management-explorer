using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Events;
using System.Reflection;

namespace ContentExplorer
{
    public class App : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("Content Explorer");
            string path = Assembly.GetExecutingAssembly().Location;
            PushButtonData button = new PushButtonData("Start Exploring", "Opens a window to explore directory", path, "ContentExplorer.Command");
            RibbonPanel panel = application.CreateRibbonPanel("Content Explorer", "Panel");

            panel.AddItem(button);

            return Result.Succeeded;
        }

    }
}
