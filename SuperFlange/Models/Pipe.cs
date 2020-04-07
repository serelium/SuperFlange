using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.Models
{
    public class Pipe
    {
        public Flange FirstFlange { get; }
        public Flange SecondFlange { get; }
        public Bolt BoltTemplate { get; }
        public Gasket Gasket { get; }

        public Pipe()
        {
            FirstFlange = new Flange();
            SecondFlange = new Flange();
            BoltTemplate = new Bolt();
            Gasket = new Gasket();
        }
    }
}
