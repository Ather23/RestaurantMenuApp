using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiazzaMannaForm
{
    public partial class Breakfast : FormBase
    {
        public Breakfast(string imagePath, int screenLocation)
             : base(imagePath, screenLocation)
        {
            this.FormName = nameof(this.Name);
            InitializeComponent();
        }
    }
}
