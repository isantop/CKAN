using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CKAN.GUI
{
    public partial class Main
    {
        private void viewPlayTimeStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayTime.loadAllPlayTime(manager);
            tabController.ShowTab("PlayTimeTabPage", 2);
            DisableMainWindow();
        }

        private void PlayTime_Done()
        {
            UpdateStatusBar();
            tabController.ShowTab("ManageModsTabPage");
            tabController.HideTab("PlayTimeTabPage");
            EnableMainWindow();
        }
    }
}
