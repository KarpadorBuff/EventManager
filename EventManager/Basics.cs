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
        public static void OnStartup(GUI instance)
        {
            instance.dropDown.Items.Add("Create");
            instance.dropDown.Items.Add("Delete");
            instance.dropDown.Items.Add("Change");
            instance.dropDown.Items.Add("Read");
        }
    }
}
