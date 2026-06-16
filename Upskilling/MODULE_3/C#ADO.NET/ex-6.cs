int[] numbers = { 10, 20, 30, 40, 50 };

for(int i=0;i<numbers.Length;i++)
    Console.WriteLine(numbers[i]);

foreach(int n in numbers)
    Console.WriteLine(n);

int j=0;
while(j<numbers.Length)
{
    Console.WriteLine(numbers[j]);
    j++;
}

j=0;
do
{
    Console.WriteLine(numbers[j]);
    j++;
}
while(j<numbers.Length);