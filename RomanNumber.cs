using System;
using Leetcode;

class RomanNumber
{
   public RomanNumeral[] romnum;
   public int romnumvalue;
        public RomanNumber(RomanNumeral[] rn)
        {
            romnum = rn;
            romnumvalue = calc(rn);    
        }
    private int calc(RomanNumeral[] rn)
    {
            int length = rn.Length;
            int valStore = 0;
            if (length > 1)
            {
                int i = (length - 1);
                valStore = rn[i].number;
                
                for(int j = (i-1); j >= 0; j--, i--)
                {
                   if(rn[i].number <= rn[j].number)
                   {
                    valStore += rn[j].number;
                   }
                    else 
                    {
                        valStore -= rn[j].number;
                    }
                }
             return valStore;
            }
            
            else
            {
                valStore = rn[0].number;
                return valStore;
            }
            
    }

    static void Main(string[] args)
    {
        int romanNumberValue;
        string input = "XIV";
        char[] numerals = input.ToCharArray();
        RomanNumeral[] rnArray= new RomanNumeral[input.Length];

        for(int i = 0; i < input.Length; i++)
        {
            RomanNumeral r = new RomanNumeral(numerals[i]);
            rnArray[i] = r;
        }

        RomanNumber rn = new RomanNumber(rnArray);
        romanNumberValue = rn.romnumvalue;
        Console.WriteLine(romanNumberValue);
    }

}