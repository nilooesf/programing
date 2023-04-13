using system;
namespace project
{
  class test
    {
        public static void Main()
        {
            
            double X=convert.ToInt32(console.ReadLine());
            if(X%2==0)
           {
            even(X);
           }
           else
           {
            odd(X);
           }

        }

        private static int even(int x)
        {
          int sum=0 , zarb=1;
          for(int i=2;i<=x;i++)
          {
            sum+=i;
            zarb*=i;
            console.WriteLine("majmoe"+sum);
            console.WriteLine("hasele zarb"+zarb);

          }

        }

        private static int odd(int x)
        {
          int sum=0 , zarb=1;
          for(int i=1;i<=x;i++)
          {
            sum+=i;
            zarb*=i;
            console.WriteLine("majmoe"+sum);
            console.WriteLine("hasele zarb"+zarb);

          }

        }


    }
}    