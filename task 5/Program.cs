int n = Convert.ToInt32(System.Console.ReadLine());
int[] arr = new int[n]; 

for(int i = 0; i < n; i++)
{
 arr[i] = Convert.ToInt32(System.Console.ReadLine());
}

int a = Convert.ToInt32(System.Console.ReadLine());
int cnt=0;

for(int i = 0; i < n; i++)
{
   if( arr[i] == a) cnt++;
}

System.Console.WriteLine(cnt);
