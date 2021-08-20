using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
            }
        }

        public double SurfaceArea()
        {
            return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }
    }
}
