include <iostream>
using namespace std;
int main()
{
int arr[10][10];
for(int i=0;i<10;i++)
{
    for(int j=0;j<10;j++)
    {
        cin>>arr[i][j];
    }
}
int number,temp=0;
cin>>number;
for(int i=0;i<10;i++)
{
    for(int j=0;j<10;j++)
    {
        if(number==arr[j][i])
        {
            temp++;
        }
    }
}                                                                             
cout<<temp;
return 0;

}