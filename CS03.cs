int a = 4;
int b = 2;
Console.WriteLine(a + b);
Console.WriteLine(a / b);
Console.WriteLine(a * b);
Console.WriteLine(a - b);

Console.WriteLine(a++);
Console.WriteLine(b--);

var max = a > b ? "a > b":"a < b";
Console.WriteLine(max);

if(a > b) {
    Console.WriteLine("a > b");
} else {
    Console.WriteLine("a < b");
}

switch (b)
{
    case 2:
        Console.WriteLine("day la so 2");
        break;
    default:
        Console.WriteLine("day la bien b chua gan gia tri");
        break;
}

for (int c= 0; c <= 20; c++) {
    c+= 2;
    Console.WriteLine(c);
    if(c == 16) {
        break;
    }
}

int bigNumber = 10;
do {
    bigNumber+= 10;
    Console.WriteLine("bignumber: " + bigNumber);
    if (bigNumber == 100)
    {
        break;
    }
} while (bigNumber <= 100);

var colors = new [] {"red", "white", "green", "blue"};
var numbers = new [] {1,2,4,5,9,10};
Console.WriteLine("Phan tu 1 trong colors:" + colors[0]);

Console.WriteLine(colors.Length);
Console.WriteLine( numbers.Sum());
Console.WriteLine( numbers.Max());

foreach (var color in colors)
{
    Console.WriteLine("Mau:" + color);
}

int [,] myOb = new int[2,3] {{1,2,3}, {3,4,5}};
Console.WriteLine(myOb[0, 2]);

for (int i = 0; i <= 1; i++) {
    for (int j = 0; j <= 2; j++)
    {
        Console.WriteLine(myOb[i,j] + " ");
    }
    Console.WriteLine();
}

int[][] myOtherOb = new int[][] {
    new int[] {2,3},
    new int[] {2,3,4},
    new int[] {2,3,6,7}
};

foreach (var ob in myOtherOb)
{
    foreach (var item in ob)
    {
        Console.WriteLine(item + " ");
    }
    Console.WriteLine();
}
