using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class GraphCoord
    {
        private int id;
        private double x;
        private double y;

        public int Id { get => id; set => id = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public GraphCoord()
        {

        }

        public GraphCoord(int id, double x, double y)
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
        }
    }
}
