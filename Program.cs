using System;
using System.Text.RegularExpressions;
namespace exerciseDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] ints = {10 ,2 ,3 };
            
            Console.WriteLine(ProductGreaterThanThird(ints));
            ints[0]=0;
            Console.WriteLine(ProductGreaterThanThird(ints));
            ints[0]=0;
            Console.WriteLine(SumGreaterThanThird(ints));
            ints[0]=10;
            Console.WriteLine(SumGreaterThanThird(ints));

            

            int[] ints = {2 ,3,5, 10 };

            Console.WriteLine(IsSorted(ints));

            
            Console.WriteLine(isLonelyIsland("abXYZas"));

            
            Console.WriteLine(isLonelyIsland("XblckcZ"));
            */


            Console.WriteLine(ContainsThree("123"));
            Console.WriteLine(ContainsThree("abc"));
            
            Console.WriteLine(ContainsThree("abc123"));
            
            Console.WriteLine(ContainsThree("abasældkaæwkeaåwkoeåpaøewk12p3åpi+080u9c"));
        }

        
    static int Absolute(int value){
        return value<0?-value:value;
    }

    static bool DivByTwo(int value){
        return value%2==0;
    }

    static bool DivByThree(int value){
        return value%3==0;
    }

    static bool HasUppercaseLetter(string str){
        Regex rgx = new Regex("[A-Z]");
        return rgx.IsMatch(str);
    }

    static bool SumGreaterThanThird(int[] ints){
        return ints[2]<ints[1]+ints[0];
    }

    
    static bool ProductGreaterThanThird(int[] ints){
        return ints[2]<ints[1]*ints[0];
    }

    static bool IsEven(int value){
        return value%2==0;
    }

    static bool IsSorted(int[] arr){
        if(arr.Length<2)
            return true;
        else{
            int start = 0;
            int isOk = 0;
            while(start<arr.Length-1){
                    if(isOk==0){
                        if(arr[start]>=arr[start+1])
                            isOk=1;
                        else
                            isOk=2;
                        }
                    if (isOk==2&&arr[start]>=arr[start+1]){
                        return false;
                    }
                    else if(isOk==1){
                        return false;
                    }
                    start++;
            }
            return true;
            }
    }

    static bool isLonelyIsland(string str){
        str=str.ToLower();
        if((str.Length-3)%2!=0)
        return false;
        else{
            int interesting = (str.Length/2);
            char[] strr = str.ToCharArray();
            return IsNotClose(strr[interesting],strr[interesting+1])||IsNotClose(strr[interesting],strr[interesting-1]);
        }
    }

    static bool IsNotClose(char a, char b){
        return Absolute(((int)a)-Absolute((int)b))<=1;
    }

    static string PosNegOrZero(double value){
        if(value<0)
        return "Neg";
        else if(value>0)
        return "Pos";
        else
        return "Zero";
    }

    static Boolean IsLeapYear(int year){
        return (year%4==0 && year % 100 != 0) || year % 400 == 0;
    }

    static Boolean ContainsThree(String value){
        Regex rgx = new Regex("[3]");
        return rgx.IsMatch(value);
    }

    }


}

