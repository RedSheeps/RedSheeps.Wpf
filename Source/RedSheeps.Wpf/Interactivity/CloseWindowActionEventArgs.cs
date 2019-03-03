using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSheeps.Wpf.Interactivity
{
    public sealed class CloseWindowActionEventArgs : EventArgs
    {
        public bool Handle { get; set; }
    }
}
