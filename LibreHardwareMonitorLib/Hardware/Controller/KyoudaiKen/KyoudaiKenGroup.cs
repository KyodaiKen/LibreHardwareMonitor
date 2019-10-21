using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreHardwareMonitor.Hardware.Controller.KyoudaiKen
{
    class KyoudaiKenGroup : IGroup
    {
        private readonly List<IHardware> _hardware = new List<IHardware>();
        private readonly StringBuilder _report = new StringBuilder();

        private SerialPort Serial;

        public KyoudaiKenGroup(ISettings settings)
        {

        }
        public IEnumerable<IHardware> Hardware => _hardware;

        public void Close()
        {
            foreach (IHardware iHardware in _hardware)
            {
                if (iHardware is Hardware hardware)
                    hardware.Close();
            }
        }

        public string GetReport()
        {
            return _report.ToString();
        }
    }
}
