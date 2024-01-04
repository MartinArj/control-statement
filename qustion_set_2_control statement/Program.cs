using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace qustion_set_2_control_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine(ispositive(3));
            
            //int a = 1;
            //int c = 4;
            //int d = 9;
            //float f = 4.1f, e = 3.3f;
          //  int b =-5;
           // char ch='d';
           // root_qe(a, b, c);
            //Console.WriteLine("enter stone or paper or scissor");
            //string game = Console.ReadLine();
            //Console.WriteLine(positive_negative( a));
            //Console.WriteLine(intequal_not( a,  b));
            //Console.WriteLine(floatequal_not(e,f));
            //Console.WriteLine(odd_even(a));
           //Console.WriteLine(closer3( a,b,c));
           // Console.WriteLine(root_ans( -2, 2, 1));
            //Console.WriteLine(leep(a));
            //Console.WriteLine(vote(a));
            //Console.WriteLine(idendify_height_cm(a));
            //Console.WriteLine(large3( a,  b,  c));
            //Console.WriteLine( small3(a,  b,  c));
            //Console.WriteLine(large4( a,  b,  c,  d));
       //   rock_paper();
          // root_qe(-2,5,1);
            //Console.WriteLine(chess_color(a, ch) );
            //Console.WriteLine(quadrand(a, b));
           //sort(a,b,c);
            //simple_colculation();
            //positive_negative(a);
            average_of_rolled();
            Console.ReadLine();
            
        }
        public static void average_of_rolled()
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            string[] s = new string[N];
            for (int i = 0; i < N; i++)
            {
                s[i] = Console.ReadLine();
            }
            for (int i = 0; i < N; i++)
            {
                int[] given_num = s[i].Split().Select(int.Parse).ToArray();
                int reverce_num = reverce(given_num);
                sum += reverce_num;
                float avg =(float) sum/ (i + 1);
                Console.WriteLine(reverce_num + " " +Math.Round(avg,1));
            }

        }
        public static int reverce(int[] a)
        {
            int reverce_num = 0;
            for (int i = a.Length-1 ; i >=0; i--)
            {
                reverce_num = (reverce_num * 10) + a[i];
            }
            return reverce_num;
        }
        public static int sum2(int a,int b)
        {
            return a+b;
        }
        public static int sub2(int a,int b)
        {
            return a-b;
        }
        public static int mul2(int a,int b)
        {
            return a*b;
        }
        public static float div2(int a,int b)
        {
            return (float)a/b;
        }
        public static int modu(int a,int b)
        {
            return a%b;
        }
        public static bool ispositive(int n)
        {
            return 0 < n;
        }
        public static bool isnegative(int n) {
            return 0 > n;
        }
        public static bool isequal(int a,int b)
        {
            return a == b;
        }
        public static bool is_floatequal(float a, float b)
        {
            return (a == b);
        }
        public static bool iseven(int a) 
       {
            return a % 2 == 0;
        }
        public static bool isodd(int a)
        {
             return a % 2 == 1;
        }
        public static bool isvote(int a)
        { return (18 <= a) && (a < 120); }
        public static char simbleofnum(int a)
        {
            if (a == 0)
                return '+';
            else if (a < 0)
                return '-';
            else if (a > 0)
                return '+';
            else
                return 'o';
        }
        public static string quadrand( int x, int y )
        {
            
            if (simbleofnum(x) == '+' && simbleofnum(y) == '+')
            {
                return "1st quadrand";
            }
            else if (simbleofnum(x) == '-' && simbleofnum(y) == '+')
            {
                return "2nd quadrand";
            }
            else if (simbleofnum(x) == '-' && simbleofnum(y) == '-')
            {
                return "3ed quadrand";
            }
            else if (simbleofnum(x) == '+' && simbleofnum(y) == '-')
                return "4th quadrand";
            else
                return "invalied";

        }
        
        public static int large3(int a, int b, int c)//set2-8 
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
        public static int small3(int a, int b, int c)//set2-9
        {
            if (a < b && a < c)
                return a;
            else if (b < a && b < c)
                return b;
            else
                return c;
        }
        public static string person_heightcm(int h)
        {
            if (170 < h)
                return "tall";
            else if ((170 >= h) && (h < 145))
                return "medium";
            else if (145 >= h)
                return "short";
            else
                return "not given data";
        }
        public static int large4(int a, int b, int c, int d)//set2-10
        {
            int big= a;
            if (big < b)
                swap(ref big, ref b);
            if (big < c)
                swap(ref big,ref c);
            if (big < d)
            {
                swap(ref big, ref d);
                return big;
            }
            else
                return 0;





            //if (a > b && a > c && a > d)
            //    return a;
            //else if (b > a && b > c && b > d)
            //    return b;
            //else if (c > a && c > b && c > d)
            //    return c;
            //else
            //    return d;
            
          }
        public static string  closer3(int a, int b, int c)
        
        {
            int d1 = Math.Abs(a - b);
            int d2 = Math.Abs(b - c);
            int d3 = Math.Abs(c-a);
            if (d1 < d2 && d1 < d3)
                return "close" + a + ":" + b;
            else if (d2 < d3 && d2 < d1)
                return "close" + b + ":" + c;
            else if (d3 < d1 && d3 < d2)
                return "close" + c + ":" + a;
            else
                return "invaliedd";
        }
        public static string triangle(int a, int b, int c)//set2-14
       {
           if (180 == (a + b + c))
               return "triangle";
           else
               return "con\'t triangle";
        }
        //public static void 
        public static string vowel(char ch)//set2-16
         {
             if ('a' == ch || 'e' == ch || 'i' == ch || 'o' == ch || 'u' == ch||'A' == ch || 'E' == ch || 'I' == ch || 'O' == ch || 'U' == ch)
             {
                 return "vowel";
             }
             else
            {
                 return "con\'t vowel is a consonant or spasial char ";}
         }
        public static string month_day(string month)//set2-18
        {
            if(month=="jonuary"||month=="march"||month=="may"||month=="july"||month=="september"||month=="november")
            {
               return "31days";
            }
            else if(month=="april"||month=="june"||month=="august"||month=="october"||month=="december")
            {
                return "30days";
            }
            else if(month=="february")
            {
                return "28days";
            }
            else
            {
                return "invalied data";
            }
        }
        public static string shape(int a)//set2-17
        {
            if (a == 3)
                return "triangle";
            else if (a == 4)
                return "quadrilateral";
            else if (a == 5)
                return "pentagon";
            else if (a == 6)
                return "hexagon";
            else if (a == 7)
                return "heptagon";
            else if (a == 8)
                return "octagon";
            else if (a == 9)
                return "nonagon";
            else if (a == 10)
                return "decagon";
            else
                return "con\'t identify";
        }
        public static string day(int a)//19
        {
            if (a < 32)
            {
                if (a % 7 == 1)
                    return "monday";
                else if (a % 7 == 2)
                    return "tuesday";
                else if (a % 7 == 3)
                    return "wednesday";
                else if (a % 7 == 4)
                    return "thursday";
                else if (a % 7 == 5)
                    return "friday";
                else if (a % 7 == 6)
                    return "saturday";
                else if (a % 7 == 0)
                    return "sunday";
                else
                    return "invalied data";
            }
            else
                return "invalied data";
        }
        public static void swap(ref int  a,ref int  b)
        {
         int temp=a;
        a=b;
        b=a;
        
        }
        public static string type_triangle(int a, int b, int c)//20
        {
            if (a == b && b != c)
                return "isosceles triangle";
            else if (a == b && a == c)
                return "equailteral";
            else if (a != b && b != c && a != c)
                return "scalene";
            else
                return "invalied data";
        }
        public static string grade_point(int mark)//21
        {
            if (mark <= 100)
            {
                if (mark >= 90)
                    return "\'A\'grade";
                else if (mark >= 80)
                    return "\'B\'grade";
                else if (mark >= 60)
                    return "\'C\'grade";
                else if (mark >= 50)
                    return "\'D\'grade";
                else if (mark < 50)
                    return "\'F\'grade";
                else
                    return null;
            }
            else
                return "invalied";
        }
        public static string chess_color(int a, char ch)//22 
        {
            int c = a + ch;
            if (a < 9)//&& 67 <= ch&&ch >= 95 && 97 <= ch &&ch>= 125
            {
                if (iseven(c))
                    return "black";
                else if (isodd(c))
                    return "white";
                else
                    return "invalied data";
            }
            else
                return "invalied data";
            
            //if ((ch =='a'|| ch =='c' || ch == 'e'|| ch == 'g') && iseven(a))
            //{
            //return "white";
            //}
            //else if ((ch =='a'|| ch =='c' || ch == 'e'|| ch == 'g') && isodd(a))
            //{
            //return "block";
            //}
            // else     if ((ch =='b'|| ch =='d' || ch == 'f'|| ch == 'h') && isodd(a))
            //{
            //return "white";
            //}
            //else if ((ch =='b'|| ch =='d' || ch == 'f'|| ch == 'h') && iseven(a))
            //{
            //return "block";
            //}
            
           //else 
           //     return "invalied data";
            
        }
        public static string profit_loss(int buy, int sal)//24
        {
            int profit = sal - buy;
            if (ispositive(profit))
                return "profit"+profit;
            else if (isnegative(profit))
                return "loss"+profit;
            else
                return "no profit no loss";
        }
        public static void  simple_colculation()//program set2-25
        {
            Console.WriteLine("enter two number:");
            int a= int.Parse (Console .ReadLine());
            int b= int.Parse (Console .ReadLine());
            Console.WriteLine("if sum of two number enter 1");
            Console.WriteLine("if subraction of two nember enter 2");
            Console.WriteLine("if muldification of two number enter 3");
            Console.WriteLine("if division of two number enter 4");
            Console.WriteLine("if madulo division of two number enter 5");
           int num= int.Parse (Console .ReadLine());
           if (num == 1)
               Console.WriteLine(" sum is" + sum2(a, b));
           else if (num == 2)
               Console.WriteLine(" sub is" + sub2(a, b));
           else if (num == 3)
               Console.WriteLine("  muldification is" + mul2(a, b));
           else if (num == 5)
               Console.WriteLine("modulodivision is" + modu(a, b));
           else if (num == 4)
               Console.WriteLine("division is" + div2(a, b));
        }
        public static string positive_negative(int a)//set2-1
        {
            if (ispositive(a))
                return "positive";
            else if (isnegative(a))
                return "negative";
            else
                return "0 or consonant or invalied data";
        }
        public static string intequal_not(int a, int b)//set2-2
        {
            if (isequal(a, b))
                return "equal";
            else
                return "con\'t equal";
        }
        public static string floatequal_not(float a, float b)//set2-3
        {
            float ep = 1.0f;
            if (Math.Abs(a - b) < ep)
            {
                return "equal";
            }
            else
                return "con\'t equal";
        }
        public static string odd_even(int a)//set2-4
        {
            if (isodd(a))
                return "given number is odd";
            else if (iseven(a))
                return "given number is even";
            else
                return "invalied data";
        }
        public static string leep(int y)//set2-5
        {
            if (y % 4 == 0)
            {
                if (y % 100 == 0)
                {
                    if (y % 400 == 0)
                    {
                        return "leep year";
                    }
                    else
                        return "common year";
                }
                else
                    return "leep year";
            }
            else
                return "common year";

        }
        public static string vote(int v)//set3-6
        {
            if (isvote(v))
            {
                return "eligibie for vote";
            }
            else if ((18 > v && v > 0) && 120 > v)
                return "not eligible";
            else
                return "invalied data";
        }
        public static string idendify_height_cm(int cm)//7
        {
            if (cm < 130)
                return "short";
            else if (130 <= cm &&cm< 150)
                return "medium";
            else if (150 <= cm &&cm< 300)
                return "tall";
            else
                return "invalied data";
        }
        public static void root_qe(int a, int b, int c)
        {
            int temp = (int)(Math .Pow (b,2))-(4 * (a * c));
            if (temp > 0)
            {
                Console.WriteLine ( "real many solution");
                Console.WriteLine(root_ans(a, b, temp));
            }
            else if(temp<0)
            {
                Console.WriteLine ( "complex root");
            }
            else if (temp == 0)
            {
                Console.WriteLine ( "real & unic solution");
               float ans=(float)-b/(2*a) ;
               Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine ( "invalied data");
            }
        }
        public static string root_ans(int a,int b,int temp)
        {
            double sq = Math.Sqrt(temp);
            double ans1 =(-b + sq)/(2*a);
            double ans2 =(-b - sq)/(2*a);
            return "ans" + ans1 + ":" + ans2;

        }
        public static int string_to_numgame(string st)
        { 
        if(st=="stone")
        {
            return 1;
        }
        else if(st=="paper")
        {
        return 2;
        }
        else if(st=="scissor")
        {
        return 3;
        }
        else
        {
        return 0;
        }
        }
        public static int random()
        {
            Thread.Sleep(20);
            Random num = new Random();
            int computer = num.Next(1, 4);
            return computer;
        }
        public static string compare_game(int inp, int a)
        {
            if (inp == a)
            {
                return " Draw";
            }
            else if ((inp == 1) && (a == 2))
            {
                return "Lost";
            }
            else if ((inp == 1) && (a == 3))
            {
                return "Won";
            }
            else if ((inp == 2) && (a == 1))
            {
                return "Win";
            }
            else if ((inp == 2) && (a == 3))
                return "Lost";
            else if ((inp == 3) && (a == 1))
                return "lost";
            else if ((inp == 3) && (a == 2))
                return "Won";
            else if (inp == 0)
                return "invalied";
            else
                return "invalied data";
        }
        public static void rock_paper()
        {Console.WriteLine("you    reselt     coputer");
        int c1 = 0;
  
        for (int i = 0; i < 5; i++)
        {
              string st = Console.ReadLine();
            int inp = string_to_numgame(st);
            Thread.Sleep(100);
            int a = random();
            string com_str = num_to_stringgame(a);
            Console.Write(st+"        "+compare_game(inp, a)+"         " + com_str);

            Console.WriteLine();
            if (compare_game(inp, a) == "Won")
            {
                c1++;
            }
            else if (compare_game(inp, a) == "Lost")
            {
                c1--;
            }
            
        }
            if(c1>0)
                Console.WriteLine("Finaly Won"+c1);
            else if(c1==0)
                Console.WriteLine("Draw");
            else
                Console.WriteLine("Finaly out");
          
           
            
        }
        public static string  num_to_stringgame(int num)
        {
            if (num == 1)
            {
                return "stone";
            }
            else if (num ==2)
            {
                return "paper";
            }
            else if (num == 3)
            {
                return "scissor";
            }
            else
            {
                return " ";
            }
        }
        public static void sort(int a, int b, int c)
        {
            if (a > b)
                swap(ref a, ref b);
             if (a > c)
                swap(ref a, ref c);
             if (b > c)
                 swap(ref b, ref c);
            Console.WriteLine (a+"     "+b+"      "+c);

        }
    }

}
