//Kent Tupas
//10/18/2022
// github mini challenge 7
// update and upload to github
//

string number, revnumber, repeat;


Console.Clear();
Console.WriteLine("____________________________________________________________________");
Console.WriteLine("Welcome to Reverse it");
Console.WriteLine("Want to reverse your numbers type yes or no");
repeat = Console.ReadLine();

while( repeat != "no"){
Console.WriteLine("Enter any numbers");
number = Console.ReadLine();

revnumber = string.Empty;

for(int i = number.Length - 1; i>= 0; i--)
  revnumber += number[i];

Console.WriteLine($"Reverse Number is {revnumber}");
Console.WriteLine("Try again yes or no");
repeat = Console.ReadLine();
Console.WriteLine("____________________________________________________________________");
}



