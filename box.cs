using system;
namespace project
{
    class test
    {
        public static void Main()
        {
          
           int L=convert.ToInt32(console.ReadLine());
           int H=convert.ToInt32(console.ReadLine());
           int W=convert.ToInt32(console.ReadLine());
           double show=calc(L,H,W);
           console.WriteLine(show);

        }

        private static double calc(int num1,int num2,int num3)
        {
          double  result=num1*num2*num3;
          return result; 

        }

    }
}








