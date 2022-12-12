Console.Write("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int R = N;
int res = 0;

while(R > 0)
{
   int dev = R % 10;

   if(dev == 0 || N % dev == 0 ) 
   {
        res += dev;
   }
   R = R / 10;
}
Console.Write(res);