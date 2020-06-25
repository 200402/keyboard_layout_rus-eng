using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasklKlavi
{
    class createDB
    {
        public static void Eng() 
        {
            int size = 26;
            string[] first = new string[size];
            string[] second = new string[size];
            string[] third = new string[size];
            string[,,] ansver = new string[size, size, size];
            first[0] = "a";
            first[1] = "b";
            first[2] = "c";
            first[3] = "d";
            first[4] = "e";
            first[5] = "f";
            first[6] = "g";
            first[7] = "h";
            first[8] = "i";
            first[9] = "j";
            first[10] = "k";
            first[11] = "l";
            first[12] = "m";
            first[13] = "n";
            first[14] = "o";
            first[15] = "p";
            first[16] = "q";
            first[17] = "r";
            first[18] = "s";
            first[19] = "t";
            first[20] = "u";
            first[21] = "v";
            first[22] = "w";
            first[23] = "x";
            first[24] = "y";
            first[25] = "z";
            second = first;
            third = first;

            string writePath = @"D:\Load\ProjectsVS\RasklKlavi\RasklKlavi\EngSQL.txt";

            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {

                for (int ifi = 0; ifi < size; ifi++)
                {
                    for (int isec = 0; isec < size; isec++)
                    {
                        for (int ithi = 0; ithi < size; ithi++)
                        {
                            ansver[ifi, isec, ithi] = "CREATE TABLE _" + first[ifi] + second[isec] + third[ithi] + "(word CHAR (40));";
                            sw.WriteLine(ansver[ifi, isec, ithi]);
                        }
                    }
                } 
            }
        }


        private void Rus()
        {
            int size = 33;
            string[] first = new string[size];
            string[] second = new string[size];
            string[] third = new string[size];
            string[,,] ansver = new string[size, size, size];
            first[0] = "а";
            first[1] = "б";
            first[2] = "в";
            first[3] = "г";
            first[4] = "д";
            first[5] = "е";
            first[6] = "ё";
            first[7] = "ж";
            first[8] = "з";
            first[9] = "и";
            first[10] = "й";
            first[11] = "к";
            first[12] = "л";
            first[13] = "м";
            first[14] = "н";
            first[15] = "о";
            first[16] = "п";
            first[17] = "р";
            first[18] = "с";
            first[19] = "т";
            first[20] = "у";
            first[21] = "ф";
            first[22] = "х";
            first[23] = "ц";
            first[24] = "ч";
            first[25] = "ш";
            first[26] = "щ";
            first[27] = "ъ";
            first[28] = "ы";
            first[29] = "ь";
            first[30] = "э";
            first[31] = "ю";
            first[32] = "я";
            second = first;
            third = first;

            for (int ifi = 0; ifi < size; ifi++)
            {
                for (int isec = 0; isec < size; isec++)
                {
                    for (int ithi = 0; ithi < size; ithi++)
                    {
                        ansver[ifi, isec, ithi] = "CREATE TABLE " + first[ifi] + second[isec] + third[ithi] + "(word CHAR (40));";
                        Console.WriteLine(ansver[ifi, isec, ithi]);
                    }
                }
            }
        }
    }
}
