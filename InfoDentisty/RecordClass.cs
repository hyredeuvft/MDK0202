using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoDentisty
{
    internal class RecordClass
    {
        public int IdRecording { get; set; }
        public string Service { get; set; }
        public string Client { get; set; }
        public DateTime StartRecording { get; set; }
        public DateTime EndRecording { get; set; }
    }
}
