using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AOC_05
{
    internal class BoxStorage
    {
        List<string> ColumnOne{ get; set; }
        List<string> ColumnTwo { get; set; }
        List<string> ColumnThree { get; set; }
        List<string> ColumnFour { get; set; }
        List<string> ColumnFive { get; set; }
        List<string> ColumnSix { get; set; }
        List<string> ColumnSeven { get; set; }
        List<string> ColumnEight { get; set; }
        List<string> ColumnNine { get; set; }

        public BoxStorage(int x, int y)
        {
            List<string> columnOne = new List<string>();
            columnOne.Add("R");
            columnOne.Add("N");
            columnOne.Add("P");
            columnOne.Add("G");
            List<string> columnTwo = new List<string>();
            columnTwo.Add("T");
            columnTwo.Add("J");
            columnTwo.Add("B");
            columnTwo.Add("L");
            columnTwo.Add("C");
            columnTwo.Add("S");
            columnTwo.Add("V");
            columnTwo.Add("H");
            List<string> columnThree = new List<string>();
            columnThree.Add("T");
            columnThree.Add("D");
            columnThree.Add("B");
            columnThree.Add("M");
            columnThree.Add("N");
            columnThree.Add("L");
            List<string> columnFour = new List<string>();
            columnFour.Add("R");
            columnFour.Add("V");
            columnFour.Add("P");
            columnFour.Add("S");
            columnFour.Add("B");
            List<string> columnFive = new List<string>();
            columnFive.Add("G");
            columnFive.Add("C");
            columnFive.Add("Q");
            columnFive.Add("S");
            columnFive.Add("W");
            columnFive.Add("M");
            columnFive.Add("V");
            columnFive.Add("H");
            List<string> columnSix = new List<string>();
            columnSix.Add("W");
            columnSix.Add("Q");
            columnSix.Add("S");
            columnSix.Add("C");
            columnSix.Add("D");
            columnSix.Add("B");
            columnSix.Add("J");
            List<string> columnSeven = new List<string>();
            columnSeven.Add("F");
            columnSeven.Add("Q");
            columnSeven.Add("L");
            List<string> columnEight = new List<string>();
            columnEight.Add("W");
            columnEight.Add("M");
            columnEight.Add("H");
            columnEight.Add("T");
            columnEight.Add("D");
            columnEight.Add("L");
            columnEight.Add("F");
            columnEight.Add("V");
            List<string> columnNine = new List<string>();
            columnNine.Add("L");
            columnNine.Add("P");
            columnNine.Add("B");
            columnNine.Add("V");
            columnNine.Add("M");
            columnNine.Add("J");
            columnNine.Add("F");

            ColumnOne = columnOne;
            ColumnTwo = columnTwo;
            ColumnThree = columnThree;
            ColumnFour = columnFour;
            ColumnFive = columnFive;
            ColumnSix = columnSix;
            ColumnSeven = columnSeven;
            ColumnEight = columnEight;
            ColumnNine = columnNine;
        }

        public List<string> GetCorrectColumn(int number)
        {
            switch (number)
            {
                case 1: return ColumnOne;
                    case 2: return ColumnTwo;
                    case 3: return ColumnThree;
                    case 4: return ColumnFour;
                    case 5: return ColumnFive;
                    case 6: return ColumnSix;
                    case 7: return ColumnSeven;
                    case 8: return ColumnEight;
                    case 9: return ColumnNine;
                default: return null;
            }
        }
    }
}
