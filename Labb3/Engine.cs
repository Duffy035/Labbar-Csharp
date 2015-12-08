using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Engine
    {
        private int gears;
        private int horsepowers;
        private int topspeed;
        private int cylinders;
        public void SetGears(int gears)
        {
            this.gears = gears;
        }
        public int GetGears()
        {
            return gears;
        }
        public void SetHorespowers(int horsepowers)
        {
            this.horsepowers = horsepowers;
        }
        public int GetHorsepowers()
        {
            return horsepowers;
        }
        public void SetTopSpeed(int topspeed)
        {
            this.topspeed = topspeed;
        }
        public int GetTopSpeed()
        {
            return topspeed;
        }
        public void SetCylinders(int cylinders)
        {
            this.cylinders = cylinders;
        }
        public int GetCylinders()
        {
            return cylinders;
        }
        internal string PrintEngine()
        {
            return $"Gears: {gears}\r\nHorsepowers: {horsepowers}\r\nTopspeed: {topspeed}\r\nCylinders: {cylinders}";
        }

    }
}
