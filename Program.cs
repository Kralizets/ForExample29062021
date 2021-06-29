using System.Collections.Generic;

namespace ForExample29062021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5 };
            List<string> secondList = new List<string> { "1", "2", "3", "4" };
            List<double> thirdList = new List<double>() { 0.5, 0.6, 0.7 };
            
            ShowArray<int> showFirstArray = new ShowArray<int>(firstList);
            ShowArray<string> showSecondArray = new ShowArray<string>(secondList);
            ShowArray<double> showThirdArray = new ShowArray<double>(thirdList);

            showFirstArray.Show();
            showSecondArray.Show();
            showThirdArray.Show();
        }
    }
}
