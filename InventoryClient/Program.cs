using System;
using System.Windows.Forms;

namespace InventoryClient
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
        
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}