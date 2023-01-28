using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphInConsole.Graph;
internal static class Angle
{
    public static double ToDegree(double radian)
    {
        return radian * (180 / Math.PI);
    }

    public static double ToRadian(double degree) 
    {
        return Math.PI * degree / 180;
    }
}
