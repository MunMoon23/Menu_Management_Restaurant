using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Management
{
    internal class MainHelper
    {
        internal static void ShowForm(Form f, Panel MainPanel)
        {
            // Nếu chưa có thì mới add
            if (!MainPanel.Controls.Contains(f))
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                f.StartPosition = FormStartPosition.Manual;
                f.Location = new Point(0, 0);
                MainPanel.Controls.Add(f);
            }

            // Đưa form lên đầu (hiển thị)
            f.BringToFront();
            f.Show();
        }
    }
}
