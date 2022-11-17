using Newtonsoft.Json;
using Shapes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Shapes.BL
{
    class ShapeBL
    {
         
        Dictionary<string, Shape> shapes = new Dictionary<string,Shape>();

            

        public Shape Add(string id, float width, float height, int amountSides, float px, float py, float pz, float scale, float rx, float ry, float rz)
        {
            Shape shape = new Shape();
            shape.ID = id;
            shape.Width = width;
            shape.Height = height;
            shape.AmountSides = amountSides;
            shape.Position = new float[] { px, py, pz };
            shape.Scale = scale;
            shape.Rotation = new float[] { rx, ry, rz };
            return shape;
        }

        public void Store(Shape shape)
        {
            try
            {
                shapes.Add(shape.ID, shape);
            }
            catch (ArgumentException)
            {

                Console.WriteLine("A shape with ID = "+ shape.ID + " already exists.");
            }
        }
        public void Remove(string ID)
        {
            try
            {
                if (!shapes.ContainsKey(ID))
                {
                    Console.WriteLine("Shape with ID = "+ ID +" is not found.");
                }
                else 
                {
                    Console.WriteLine("\n Remove shape with ID =(" + ID +")");
                    shapes.Remove(ID); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void getShapeById(string ID)
        {
            try
            {
                if (!shapes.ContainsKey(ID))
                {
                    Console.WriteLine("Shape with ID = " + ID + " is not found.");
                  
                }
                else
                {
                    Console.WriteLine("\n Information of  shape with ID =(" + ID + ") : \n");
                    Console.WriteLine(shapes[ID].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public void getAllShapes()
        {
            try
            {
                foreach (var item in shapes)
                {
                    Console.WriteLine("\n Information of  shape with ID =(" + item.Value.ID + ") : \n");
                    Console.WriteLine(item.Value.ToString()+" \n");
                }
              
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void editShapePosition(string ID, float x, float y, float z)
        {
            try
            {
                if (!shapes.ContainsKey(ID))
                {
                    Console.WriteLine("Shape with ID = " + ID + " is not found.");
                }
                else
                {
                    Console.WriteLine("\n Edit position of shape whith ID= (" + ID + ")");
                    shapes[ID].Position= new float[] { x, y, z };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void editShapeScale(string ID, float scale)
        {
                try
                {
                    if (!shapes.ContainsKey(ID))
                    {
                        Console.WriteLine("Shape with ID = " + ID + " is not found.");
                    }
                    else
                    {
                        Console.WriteLine("\n Edit scale of shape whith ID= (" + ID + ")");
                        shapes[ID].Scale = scale;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
        }
        public void editShapeRotation(string ID, float x, float y, float z)
        {
            try
            {
                if (!shapes.ContainsKey(ID))
                {
                    Console.WriteLine("Shape with ID = " + ID + " is not found.");
                }
                else
                {
                    Console.WriteLine("\n Edit rotaion of shape whith ID= (" + ID + ")");
                    shapes[ID].Rotation = new float[] { x, y, z };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
