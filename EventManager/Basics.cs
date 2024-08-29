using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace EventManager
{
    internal class Basics
    {
        public static void OnStartup()
        {
            GUI.dropDown.Items.Add("Create");
            GUI.dropDown.Items.Add("Delete");
            GUI.dropDown.Items.Add("Change");
            GUI.dropDown.Items.Add("Read");
        }
    }
}
