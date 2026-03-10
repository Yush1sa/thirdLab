using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdLab
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double x=0, double y=0, double z=0) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string Show() {
            return String.Format("Вектор: ({0}, {1}, {2})", this.x, this.y, this.z);
        }

        public static string operator+(Vector a, Vector b) {
            return new Vector(a.x+b.x, a.y+b.y, a.z+b.z).Show();
        }

        public static string operator-(Vector a, Vector b) {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z).Show();
        }

        public static string operator *(Vector a, Vector b) {
            return new Vector(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x).Show();
        }

        public static string operator&(Vector a, Vector b) {
            return String.Format("Скалярное произведение: {0}", a.x * b.x + a.y * b.y + a.z * b.z);
        }
        public string CalcLength() {
            double length = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            return String.Format("Длина вектора: {0}", length);
        }
        
    }
}
