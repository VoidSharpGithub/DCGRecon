using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DCGRecon.Classes
{
    public struct ReconStruct
    {
        public List<Receivers> receivers;
        public string appkey;
        public bool updatesenabled;
        public DateTime updatetime;
        public string filter;
        public List<string> filterList;
    }
    public struct Receivers
    {
        public string ipaddress;
        public string receivernumber;
        public string receivername;
        public List<Tuners> tuner;
    }
    public struct Tuners
    {
        public int id;
        public int status;
        public int avstatus;
        public int signallevel;
        public int channel;
        public string eventname;
        public string eventdescription;
        public DateTime eventstart;
        public DateTime eventend;
    }
}
