//Murekkeb or sade 
/*
int n = 10;
int sum = 0;
int i = 1; 
//For version

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        sum += 1;
    }
}

if (sum > 2)
{
    Console.WriteLine("Murekkebdir");
}
else
{
    Console.WriteLine("sadedir");
}
//-------------------------------------------
//While version
while (i <= n)
{
    if (n % i == 0)
    {
        sum += 1;
    }
    i++;
}
if (sum > 2)
{
    Console.WriteLine("Murekkebdir");
}
else
{
    Console.WriteLine("sadedir");
}
*/
//--------------------------------------------
//Factorial hesablama
/*
int n = 25;
int fact = 1;
while (n>=1)
{
    fact *= n;
    n--;

}
Console.WriteLine(fact);
*/
//-------------------------------------------
//Ededin reqemlerinin cemi
int n = 267;
int sum = 0;

while (n != 0)
{
    sum += n % 10; 
    n /= 10; 
}

Console.WriteLine(sum);