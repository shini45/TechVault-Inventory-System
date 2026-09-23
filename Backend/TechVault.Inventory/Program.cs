using System;
using System.Windows.Forms;

namespace TechVault.Inventory
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TechVault());
        }
    }
}
