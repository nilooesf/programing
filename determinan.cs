using system;
namespace project
{
    class test
    {
        public static void Main()
        {
          int[3,3] a;
          int i,j;
          int det=0;
          Console.WriteLine("enter matrix");
          for(i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    a[i][j]= Convert.ToInt32(Console.ReadLine());

                }
            }
        det=a[0][0]*((a[1][1]*a[2][2])
        -(a[2][1])*a[1][2])
        -a[0][1]*((a[1][0]*a[2][2])
        -(a[2][0])*a[1][2])+a[0][2]*((a[1][0])
        *a[2][1]-(a[2][0])*a[1][1]);
        
        Console.WriteLine("the determinan is :"+det);
        


        }
    }
}








