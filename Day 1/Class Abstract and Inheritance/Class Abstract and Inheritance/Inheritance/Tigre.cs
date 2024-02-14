using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Abstract_and_Inheritance.Inheritance;
public class Tiger : Animal
{
    public string locomotion { get; set; }
    public Tiger(string Name, string race, string diet) : base()
    {
        Name = "Tiger";
        race = "Striped tiger";
        diet = "meat";
        locomotion = IsQuadruped(true);

    }
}
