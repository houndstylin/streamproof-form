using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace streamproofformexample
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        public Form1()
        {
            InitializeComponent();
            const uint WDA_EXCLUDEFROMCAPTURE = 0x00000011;
            SetWindowDisplayAffinity(this.Handle, WDA_EXCLUDEFROMCAPTURE);
        }
    }
}

        