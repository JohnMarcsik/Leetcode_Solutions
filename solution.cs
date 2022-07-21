using System;

namespace Solution{
    public class Solution {

        private int getValue(char r)
        {
            int num;
            switch(r)
            {
                case 'I':
                num = 1;
                break;
                case 'V':
                num = 5;
                break;
                case 'X':
                num = 10;
                break;
                case 'L':
                num = 50;
                break;
                case 'C':
                num = 100;
                break;
                case 'D':
                num = 500;
                break;
                case 'M':
                num = 1000;
                break;
                default:
                num=0;
                break;
            }
            return num;
        }
         public int romanToInt(string s){
            int romanNumberValue = 0;
            string input = s;
            char[] numerals = input.ToCharArray();
            int[] values = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                values[i] = getValue(numerals[i]);
            }
            if (input.Length > 1)
                {
                    int j = (input.Length - 1);
                    romanNumberValue = values[j];
                    
                    for(int k = (j-1); k >= 0; j--, k--)
                    {
                    if(values[j] <= values[k])
                    {
                        romanNumberValue += values[k];
                    }
                        else 
                        {
                            romanNumberValue -= values[k];
                        }
                    }
                return romanNumberValue;
                }
                
                else
                {
                    return romanNumberValue;
                }
    
        }
           static void Main(string[] args)
            {
                Solution s = new Solution();
                int answer1 = s.romanToInt("III");
                int answer2 = s.romanToInt("XIV");
                int answer3 = s.romanToInt("MDCIX");
                Console.WriteLine(answer1 + "\n" + answer2 + "\n" + answer3);
            }   


    }


}