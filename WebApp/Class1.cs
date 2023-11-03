using System.Drawing;
using System.Security.Cryptography.X509Certificates;


namespace WebApp
{
    public class Class1
    {
        public static bool ArePointsCollinear(Point p1, Point p2, Point p3)
        {

            return (p3.Y - p2.Y) * (p2.X - p1.X) == (p2.Y - p1.Y) * (p3.X - p2.X);


        }
        
        public static string showpoints(Point p1, Point p2, Point p3)
        {
            return (p1, p2, p3).ToString();
        }

    }
}
