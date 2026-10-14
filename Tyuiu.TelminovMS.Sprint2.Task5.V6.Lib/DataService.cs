using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TelminovMS.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string name = "";
            string value = "";
            switch (value1)
            {
                case 1:
                    name = "пик";
                    break;
                case 2:
                    name = "треф";
                    break;
                case 3:
                    name = "бубен";
                    break;
                case 4:
                    name = "черв";
                    break;
            }
            switch (value2)
            {
                case 6:
                    value = "шестёрка";
                    break;
                case 7:
                    value = "семёрка";
                    break;
                case 8:
                    value = "восьмёрка";
                    break;
                case 9:
                    value = "девятка";
                    break;
                case 10:
                    value = "десятка";
                    break;
                case 11:
                    value = "валет";
                    break;
                case 12:
                    value = "дама";
                    break;
                case 13:
                    value = "король";
                    break;
                case 14:
                    value = "туз";
                    break;

            }
            return (value + " " + name);
        }
    }
}
