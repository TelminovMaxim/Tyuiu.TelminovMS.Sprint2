using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TelminovMS.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < b) | (c + 10 > d);
            res[1] = (a == b) & (c * 2 <= d);
            res[2] = (a >= b) || (c - 10 == d);
            res[3] = (a != b) && (c + d < a);
            res[4] = !(a + b == c);
            res[5] = (a * 0 < b) ^ (c <= d);

            return res;
        }
    }
}
