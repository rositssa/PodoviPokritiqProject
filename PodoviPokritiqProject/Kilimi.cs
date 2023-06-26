using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodoviPokritiqProject
{
    public class Kilimi : PodoviPokritiq
    {
        private string color;
        private double length;
        private double width;
        private double price;
        public string Color
        {
            get { return color; }
            set
            {
                if(string.IsNullOrEmpty(color))
                {
                    throw new Exception("Color can't be without a name");
                }
                color = value;
            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Length should be positive number");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width should be positive number");
                }
                width = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price should be positive number");
                }
                price = value;
            }
        }
        public Kilimi(string color, double length, double width, double price, string productType, string materialType):base(productType, materialType)
        {
            this.color = color;
            this.length = length;
            this.width = width;
            this.price = price;
        }
        public override void Print()
        {
            Console.WriteLine($"ProductType:{ProductType}");
            Console.WriteLine($"MaterialType:{MaterialType}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Length:{Length}");
            Console.WriteLine($"Width:{Width}");
            Console.WriteLine($"Price:{Price}");
        }
    }
}
