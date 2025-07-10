using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Management
{
    internal class MainHelper
    {
        internal static void ShowForm(Form f, Panel fl)
        {
            fl.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            fl.Controls.Add(f);
            f.Show();
        }
    }
}
