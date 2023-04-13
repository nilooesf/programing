using system;
namespace project
{
    class test
    {
        public static void Main()
        {
          
           int X=convert.ToInt32(console.ReadLine());
           int Y=convert.ToInt32(console.ReadLine());
           calc(X,y);

        }

        private static double calc(int x,int y)
        {
          double  result=math.sqrt(math.abs(x)+math.pow(y,2));
          console.WriteLine(result); 

        }

    }
}








