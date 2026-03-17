using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thirdLab
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double x = 0, double y = 0, double z = 0) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"Вектор: ({this.x}, {this.y}, {this.z})";
        }

        public static Vector operator +(Vector a, Vector b) {
            return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector operator -(Vector a, Vector b) {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vector operator *(Vector a, Vector b) {
            return new Vector(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x);

        }

        public static double operator &(Vector a, Vector b) {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
        public double Length() {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }

        public override bool Equals(object? obj)
        {
            
            if (obj == null && !(obj is Vector)) return false;

            Vector other = obj as Vector;

            return x ==other.x && y == other.y && z == other.z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }

    }
}
