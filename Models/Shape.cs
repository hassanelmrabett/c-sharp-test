using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Shape
    {

        public string ID { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int AmountSides { get; set; }
        public float[] Position { get; set; }
        public float Scale { get; set; }
        public float[] Rotation { get; set; }

        public Shape()
        {
            
        }

        public override string ToString()
        {
            return "[ID = " + this.ID + ", Width = " + this.Width + ", Height = " + this.Height +
                ", Amount Sides = " + this.AmountSides + 
                ", Position = [" + this.Position[0] + ", " + this.Position[1] + ", " + this.Position[2] + 
                "] , Scale = " + this.Scale + ", Rotation = [" + this.Rotation[0] + ", " + this.Rotation[1] + ", " + this.Rotation[2]+ "]]";
        }


    }
}
