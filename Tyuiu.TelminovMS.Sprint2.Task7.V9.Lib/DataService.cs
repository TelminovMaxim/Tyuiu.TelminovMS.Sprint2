using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TelminovMS.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool Sin = y <= Math.Sin(x);
            bool Line = y <= 0.5 && y >= 0;
            bool RangeX = x >= 0 && x <= Math.PI;

            return (Sin && Line && RangeX);
        }
    }
}
