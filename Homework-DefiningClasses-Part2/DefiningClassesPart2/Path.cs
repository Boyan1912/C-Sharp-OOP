using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public Path (List<Point3D> points)
        {
            this.points = points;

        }

        public List<Point3D> Points
        {
            get { return this.points; }
        }

        public void AddPoints(List<Point3D> newPoints)
        {
            foreach (Point3D point in newPoints)
            {
                this.points.Add(point);
            }

        }
        public void AddPoints(Point3D newPoint)
        {
            this.points.Add(newPoint);
        }
    }

    static class PathStorage
    {

        public static void SaveToFile(Path pointsList)
        {
            StringBuilder paths = new StringBuilder();
            foreach (var point in pointsList.Points)
            {
                paths.Append(point.ToString() + Environment.NewLine);
            }
            File.WriteAllText(@"..\..\POINTSLIST.txt", paths.ToString());
        
        }

        public static Path LoadFromFile()
        {
            List<Point3D> paths = new List<Point3D>();
            using (StreamReader reader = new StreamReader(@"..\..\POINTSLIST.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    
                    try
                    {
                        Point3D point = new Point3D();
                        point = point.Parse(line);
                        paths.Add(point);
                    }
                catch(FormatException)
                    {
                        Console.WriteLine("3D point isn't in correct format!");
                    }
                    line = reader.ReadLine();
                }
            }
            return new Path(paths);
        
        }

    }


}
