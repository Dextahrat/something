using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomWidget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MakeWin();
            InitializeComponent();
        }


        #region Gedget Yapmek için

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hP, IntPtr hC, string sC, string sW);

        void MakeWin()
        {
            IntPtr nWinHandle = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
            nWinHandle = FindWindowEx(nWinHandle, IntPtr.Zero, "SHELLDLL_DefView", null);
            SetParent(Handle, nWinHandle);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
