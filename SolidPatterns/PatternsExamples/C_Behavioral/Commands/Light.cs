using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsExamples.C_Behavioral.Commands
{
    public class Light : ILight
    {
        public bool LightIsOn { get; set; }
    }
}
