using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class MonitorBuilder
    {
        private Monitor _monitor;

        public MonitorBuilder()
        {
            _monitor = new Monitor();
        }

        public void SetPanelType(string paneltype)
        {
            _monitor.PanelType = paneltype;
        }

        public void SetSize(string size)
        {
            _monitor.Size = size;
        }

        public void SetRefreshRate(int refreshRate)
        {
            _monitor.RefreshRate = refreshRate;
        }

        public Monitor GetMonitor()
        {
            return _monitor;
        }
    }
}
