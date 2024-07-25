using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public interface IAvailability
    {
        public  string getAvailability();
        public  void setAvailability(string availability);
    }
}
