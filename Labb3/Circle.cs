using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
   public class Circle
    {
        private double diameter;
        private Point center;

        public void SetDiameter(double diameter)
        {
            if (diameter > 0)
                this.diameter = diameter;
            else
                this.diameter = 5;
        }
        public double GetDiameter()
        {
            return diameter;
        }
        public void SetCenter(Point myPoint)
        {
            center = myPoint;
        }
        public Point GetCenter()
        {
            return center;
        }
        public double GetCircumference()
        {
            double circumferenceSum = diameter * Math.PI;
            return circumferenceSum;
        }
        public string GetCircleString()
        {
            return $"diameter={diameter}\r\nOmkrets={GetCircumference()}\r\nX={center.GetX()}\r\nY={center.GetY()}";
        }
    }


/*----Uppgift 2----*/
    //public class Circle
    //{
    //    private double diameter;

    //    public void SetDiameter(double diameter)
    //    {
    //        if (diameter > 0)
    //            this.diameter = diameter;
    //        else
    //            this.diameter = 5;
    //    }
    //    public double GetDiameter()
    //    {
    //        return diameter;
    //    }
    //    public double GetCircumference()
    //    {
    //        double circumferenceSum = diameter * Math.PI;
    //        return circumferenceSum;
    //    }
    //}

}
