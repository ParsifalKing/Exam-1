int n = Convert.ToInt32(System.Console.ReadLine());
int[] arr = new int[n]; 

for(int i = 0; i < n; i++)
{
 arr[i] = Convert.ToInt32(System.Console.ReadLine());
}

int a = Convert.ToInt32(System.Console.ReadLine());

for(int i = 0; i < n; i++)
{
  if( arr[i] != arr[a] ) System.Console.Write(arr[i] + " ");
}

