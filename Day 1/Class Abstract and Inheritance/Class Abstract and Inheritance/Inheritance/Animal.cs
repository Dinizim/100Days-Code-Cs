using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Abstract_and_Inheritance.Inheritance;
public abstract class Animal
{
    public string Name { get; set; }
    public string race { get; set; }
    public string diet { get; set; }

    public string IsQuadruped(bool istrue)
    {
        if (istrue == true)
        {
            return "Quadruped";
        }
        else
        {
            return "Biped";
        }
    }



    protected Animal()
    {
    }
}
