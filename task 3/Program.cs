int n = Convert.ToInt32(System.Console.ReadLine());
int[] arr = new int[n]; 

for(int i = 0; i < n; i++)
{
 arr[i] = Convert.ToInt32(System.Console.ReadLine());
}

int min=999999999;
for(int i = 0; i < n; i++)
{
  if( arr[i] < min  ) min =i;
}

int max=-999999999;
for(int i = 0; i < n; i++)
{
  if( arr[i] > max ) max =i;
}


for(int i = 0; i < n; i++)
{
   if(i < min && i>max) continue;
   System.Console.Write(i + " "); 
}




