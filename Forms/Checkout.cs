using System;
using System.Windows.Forms;

namespace Forms
{
    internal partial class Checkout : Form
    {
        internal static bool isShowing;
        internal Checkout()
        {
            InitializeComponent();
            isShowing = true;
        }
    }
}
