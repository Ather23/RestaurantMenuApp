using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiazzaMannaForm
{ 
    public class FormBase:Form
    {
        protected string FormName { get; set; }
        public FormBase(string imageName,int screenLocation)
        {
            Image myPicture = new Bitmap($"{Config.ImageDir}{imageName}");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Screen.AllScreens[screenLocation].WorkingArea.Location;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = myPicture;
            this.Text = "Form2";
        }
    }
}
