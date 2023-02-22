using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    [Serializable]
    public class Monitor
    {
        public string PanelType { get; set; }

        public string Size { get; set; }

        public int RefreshRate { get; set; }
    }
}
