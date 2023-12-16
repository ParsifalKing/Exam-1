void EvenNumbers(int a, int b)
{

     if (a <= b)
    {   
       if(a%2==0) System.Console.Write(a + " "); 
              EvenNumbers(a+1,b);
    }
    
}
void OddNumbers(int a, int b)
{
    if (a <= b)
    {  

       if(a %2!=0) System.Console.Write(a + " ");
              OddNumbers(a+1,b);  
    }
    
}


int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());

EvenNumbers(a,b);
System.Console.WriteLine();
OddNumbers(a,b);
