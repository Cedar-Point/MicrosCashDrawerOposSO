using System;
using System.Windows.Forms;
using OposCashDrawer_1_7_Lib;
using OPOSCONSTANTSLib;

namespace MicrosCashDrawerOposTestApp
{
    public partial class Window : Form
    {
        private OPOSCashDrawer Drawer;
        public Window()
        {
            InitializeComponent();
            Drawer = new OPOSCashDrawer();
            Drawer.ClaimDevice(10);
            Drawer.Open("CashDrawer");
            Drawer.DeviceEnabled = true;
            Drawer.StatusUpdateEvent += Drawer_StatusUpdateEvent;
        }
        private void Drawer_StatusUpdateEvent(int Data)
        {
            lblStatus.Text = ((OPOSCashDrawerConstants)Data).ToString();
        }
        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            Drawer.OpenDrawer();
        }
    }
}