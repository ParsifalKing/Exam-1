int sum=0;
int SumDigits(int n)
{
for (int i = n; i > 0; i /= 10)
{
  sum += (i%10);
}
 return sum;
}

int n = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine( "The sum of the digits of the number " + n + " is : " + SumDigits(n) );
