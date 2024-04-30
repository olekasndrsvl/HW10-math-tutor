using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    /// <summary>
    /// Класс-симулятор декартовой плоскости.
    /// </summary>
    public class CartesianPlane
    {

        public List<GeometricObjects> objects = new List<GeometricObjects>();
        
        /// <summary>
        /// Метод печати всех геометрических объектов плоскости
        /// </summary>
        public void Print()
        {
           foreach (var obj in objects)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        /// <summary>
        /// Метод добавления объекта на декартову плоскость
        /// </summary>
        /// <param name="obj"></param>
        public void AddObljectToPlane(GeometricObjects obj) 
        {
            
            objects.Add(obj);
        
        }



        /// <summary>
        /// Класс, содержащий геометрические объекты на декартовой плоскости.
        /// </summary>
        public class GeometricObjects 
        {
            /// <summary>
            /// Класс точки на декартовой плоскости 
            /// </summary>
            public class Point: GeometricObjects // класс точки на декартовой плоскости
            {
                public double x;
                public double y;
                public Point(double x, double y)
                {
                    this.x = x;
                    this.y = y;
                }

                public override string ToString()
                {
                    return "(" + x + "," + y + ")";
                }
            }

            /// <summary>
            /// Класс объекта прямоугольник, определяемый 4 мя точками декартовой плоскости
            /// </summary>
            public class Rectangle : GeometricObjects // класс объекта прямоугольник, определяемый 4 мя точками декартовой плоскости
            {
                public Point[] points = new Point[4];
                /// <summary>
                /// Конструктор класса Rectangle, принимает на вход массив из 4 объектов класса Point
                /// </summary>
                /// <param name="points_"></param>
                /// <exception cref="ArgumentException"></exception>
                public Rectangle(Point[] points_) // инициализация объекта прямоугольник
                {
                    if (points_.Length == 4 && IsRectangle(points_))
                    {
                        for (int i = 0; i < points_.Length; i++)
                        {
                            points[i] = new Point(points_[i].x, points_[i].y);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Amount of points to define object \"Rectagle\" must be 4"); // Ошибка количества точек
                    }
                }
                /// <summary>
                /// Периметр прямоугольника
                /// </summary>
                /// <returns>
                /// Периметр(double)
                /// </returns>
                public double Perimetr()
                {
                    double side1 = Math.Sqrt(Math.Pow(points[1].x - points[0].x, 2) + Math.Pow(points[1].y - points[0].y, 2));
                    double side2 = Math.Sqrt(Math.Pow(points[2].x - points[1].x, 2) + Math.Pow(points[2].y - points[1].y, 2));
                    double side3 = Math.Sqrt(Math.Pow(points[3].x - points[2].x, 2) + Math.Pow(points[3].y - points[2].y, 2));
                    double side4 = Math.Sqrt(Math.Pow(points[3].x - points[0].x, 2) + Math.Pow(points[3].y - points[0].y, 2));
                    return (side1 + side2 + side3 + side4);

                }



                private bool IsRectangle(Point[] arr) // проверка является ли заданный четырехугольник прямоугольником
                {
                    double side1 = Math.Sqrt(Math.Pow(arr[1].x - arr[0].x, 2) + Math.Pow(arr[1].y - arr[0].y, 2));
                    double side2 = Math.Sqrt(Math.Pow(arr[2].x - arr[1].x, 2) + Math.Pow(arr[2].y - arr[1].y, 2));
                    double side3 = Math.Sqrt(Math.Pow(arr[3].x - arr[2].x, 2) + Math.Pow(arr[3].y - arr[2].y, 2));
                    double side4 = Math.Sqrt(Math.Pow(arr[3].x - arr[0].x, 2) + Math.Pow(arr[3].y - arr[0].y, 2));

                    double diagonal1 = Math.Sqrt(Math.Pow(arr[2].x - arr[0].x, 2) + Math.Pow(arr[2].y - arr[0].y, 2));
                    double diagonal2 = Math.Sqrt(Math.Pow(arr[3].x - arr[1].x, 2) + Math.Pow(arr[3].y - arr[1].y, 2));

                    return (side1 == side3 && side2 == side4 && diagonal1 == diagonal2);

                }





                public override string ToString()
                {
                    return points[0].ToString() + " " + points[1].ToString() + " " + points[2].ToString() + " " + points[3].ToString();
                }




            }


        }


    }
}
