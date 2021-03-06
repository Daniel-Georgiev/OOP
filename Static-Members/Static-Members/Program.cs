﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Point3d
{
    class Point3D
    {
        private double x;
        private double y;
        private double z;
        public double X { get { return this.x; } set { this.x = value; } }
        public double Y { get { return this.y; } set { this.y = value; } }
        public double Z { get { return this.z; } set { this.z = value; } }

        public Point3D(double x, double y, double z){
            
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        //static Point3D()
        //{
        //    Point3D startPoint = new Point3D(0, 0, 0);
        //}
        private static readonly Point3D startPoint = new Point3D(0, 0, 0);
       public static Point3D StartPoint
       {
           get { return startPoint; }
       }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Starting Point: " + StartPoint);
            //The program works without the line above
            output.AppendFormat("Point X: {0}\nPoint Y: {1}\nPoint Z: {2}", this.x, this.y, this.z);
            return output.ToString();
        }
    }
}
