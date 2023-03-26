using System.Windows.Forms;

namespace System
{
    internal class KeyPress
    {
        private Action<object, KeyPressEventArgs> txtNum1_KeyPress;

        public KeyPress(Action<object, KeyPressEventArgs> txtNum1_KeyPress)
        {
            this.txtNum1_KeyPress = txtNum1_KeyPress;
        }
    }
}