using system;
namespace project
{
  class test
    {
      public static void Main()
        {
          
           double X=convert.ToInt32(console.ReadLine());
           double Y=convert.ToInt32(console.ReadLine());
           double result=calc(X,y);
           if(result>=10)
           {
            console.WriteLine("pass");
           }
           else
           {
            console.WriteLine("field");
           }

        }

        private static double calc(double x,double y)
        {
          double  result=(x*0.35)+(y*0.65);
          return result; 

        }

    }
}








