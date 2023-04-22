Console.WriteLine("Enter Array Length");
string value  = Console.ReadLine();
int arrayLength = Convert.ToInt32(value);
int[] arrayName01= new int[arrayLength];

int counter = 0;

//while(counter <= arrayName01.Length)
//{
//    Console.WriteLine(counter);
//    counter++;
//}
//Console.WriteLine("Press any key to continue.");
//Console.ReadKey();

int offSet = new Random().Next(1000);

for (; counter < arrayName01.Length; counter++)
{
    arrayName01[counter] = offSet + counter;
    //Console.WriteLine(arrayName01[counter]);
}


void binarySearch(int numberToFind)
{
    int min = 0;
    int max = arrayLength - 1;
    int midPoint = (arrayLength - 1) / 2;

    while(arrayName01[midPoint] != numberToFind)
    {
        if(arrayName01[midPoint] < numberToFind)
        {
            min = midPoint + 1;
        }
        if(arrayName01[midPoint] > numberToFind)
        {
            max = midPoint - 1;
        }
        midPoint = (max + min) / 2;
    }
    Console.WriteLine("Number found at location: " + midPoint);
}

binarySearch(new Random().Next(offSet, arrayLength + offSet));

Console.WriteLine("Press any key to continue.");
Console.ReadKey();