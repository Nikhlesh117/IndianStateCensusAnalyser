using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class Statecensusexception : Exception
    {
        public Statecensusexception(string message) : base(message) { }

    }
}
