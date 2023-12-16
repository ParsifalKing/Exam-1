 int pr=1, sum=0;
void  Fibonachi(int n)
{
 if( sum < n )
 {
  sum += pr;
  System.Console.Write(sum + " ");
  Fibonachi(pr+sum);
 }

}

int n = Convert.ToInt32(System.Console.ReadLine());
Fibonachi(n);