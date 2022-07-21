using System;


//Console.WriteLine("test");
namespace Leetcode
{
   class RomanNumeral
   {
      public int number;
      public char r;
      public RomanNumeral(char rep)
      {
         r = rep;
         number = getValue();
      }
      private int getValue()
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
            default:
               num=0;
               break;
         }
         return num;
      }
   

   }
}
