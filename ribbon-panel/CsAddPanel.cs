using System;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.Security.Cryptography.X509Certificates;
using Autodesk.Revit.Attributes;
using System.Diagnostics;

namespace Walkthrough 
{
    /// <remarks>
    /// This application's main class. The class must be Public
    /// </remarks>
    public class CsAddPanel:IExternalApplication
    {
        // Both OnStartup and OnShutdown must be Implemented as publi method
        public Result OnStartup(UIControlledApplication application)
        {
            TaskDialog.Show("DEBUG", "OnStartup dipanggil");
            // Add a new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("NewRibbonPanel");
            
            // Create a push button to trigger a command add it to the ribbon panel.

           string   thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData buttonData = new PushButtonData("cmdHelloWorld", "Hello World", thisAssemblyPath, "Walkthrough.HelloWorld");
            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;

            // Optionally, other properties may be assigned to the button 
            // a) tool-tip
            pushButton.ToolTip = "Say hello to the entire world.";

            // b) large bitmap
            //string imagePath = @"C:\Samples\AddPanel\bin\x64\debug\earth.png";
            //if (System.IO.File.Exists(imagePath))
            
                Uri uriImage = new Uri(@"C:\Samples\AddPanel\bin\x64\Debug\earth.png.png");
                BitmapImage largeImage = new BitmapImage(uriImage);
                //largeImage.BeginInit();
                //largeImage.UriSource = new Uri(imagePath, UriKind.Absolute");
                //largeImage.EndInit();
                pushButton.LargeImage = largeImage;
            
            //else
            {
                //TaskDialog.Show("Error", $"Gambar tidak ditemukan:\n{imagePath}");
            }
                return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
        // nothing to clean up in this simple case
        return Result.Succeeded;    
        }
    }
    ///<remarks>
    ///The "HelloWorld" external command. The class must be Public
    ///</remarks>
    [Autodesk.Revit.Attributes .Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class HelloWorld: IExternalCommand
    {
     // The main Excute method (inherited from IExternalCommand) must be public
     public Autodesk.Revit.UI.Result Execute(ExternalCommandData revit, ref string message, ElementSet elements)
       {
            TaskDialog.Show("Revit", "Hello World");
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}
