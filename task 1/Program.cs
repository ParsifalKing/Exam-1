int n = Convert.ToInt32(System.Console.ReadLine());
int cnt=1;
int[] arr = new int[n]; 

for(int i = 0; i < n; i++)
{
 arr[i] = Convert.ToInt32(System.Console.ReadLine());
}

Array.Sort(arr);
int a = arr[0];
for( int i = 0; i < n; i++ )
{
  if(arr[i] != a)
  {
   cnt++;
   a = arr[i];

  }
}

System.Console.WriteLine(cnt);
