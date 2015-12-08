using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Bike
    {
        private string color;
        private Engine engine;

        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetEngineType(Engine engine)
        {
            this.engine = engine; 
        }
        public Engine GetEngine()
        {
            return engine;
        }
    }
}
