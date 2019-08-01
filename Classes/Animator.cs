using System;
using System.Windows.Forms;

namespace Classes
{
    class Animator
    {

        private bool StartDragging = false;
        private System.Drawing.Point LastPosition;
        private Control ControlFX;

        public void Addcontrol(Control ControlFX, Control MainControl)
        {
            MainControl.MouseDown += OnMouseDown;
            MainControl.MouseMove += OnMouseMove;
            MainControl.MouseUp += OnMouseUp;
            MainControl.MouseEnter += OnMouseEnter;
            this.ControlFX = ControlFX;
        }
        
        private void OnMouseEnter(object o, EventArgs e)
        {
            StartDragging = false;
        }

        private void OnMouseUp(object o, MouseEventArgs e)
        {
            StartDragging = false;
        }

        private void OnMouseDown(object o, MouseEventArgs e)
        {
            LastPosition = e.Location;
            StartDragging = true;
        }

        private void OnMouseMove(object o, MouseEventArgs e)
        {
            int PosX = (ControlFX.Location.X - LastPosition.X) + e.X;
            int PosY = (ControlFX.Location.Y - LastPosition.Y) + e.Y;
            int MaxX = Screen.PrimaryScreen.Bounds.Width - ControlFX.Width;
            int MaxY = Screen.PrimaryScreen.Bounds.Height - ControlFX.Height;
            if (StartDragging)
            {
                PosY = PosY >= 0 ? PosY : 0;
                PosX = PosX >= 0 ? PosX : 0;
                PosX = PosX <= MaxX ? PosX : MaxX;
                PosY = PosY <= MaxY ? PosY : MaxY;
                ControlFX.Location = new System.Drawing.Point(PosX, PosY);
                ControlFX.Update();
            }
        }
    }
}
