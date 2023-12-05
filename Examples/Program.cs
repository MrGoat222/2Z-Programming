// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Datatypes: Int, float, string, bool
int are whole numbers(1,2,3,4,5 -5,-4,-3,-2,-1 and so on)
float are decimal numbers(1.1, 1.2, 1.3, 1.4, 1.5 -1,1 -1,2 -1,3 -1,4 -1,5 and so on)
string are words ("Once there Once was an old lady who swallowed a fly" and so on)
bool are true or false (is Anton Winther Jensen 2 meters tall? True) (Does he have a dog false))  

*/
int x; //Declaring a variable
x = 4; //Instantiating a variable

int y = 5, z = 6; //Declaring and instantiating a variable

Console.WriteLine("x is " + x); //Printing a variable
Console.WriteLine("y is " + y); //Printing a variable
Console.WriteLine("z is " + z); //Printing a variable

float d = 5.2f; //Declaring and instantiating a float variable

Console.WriteLine(d+x+y*z); //Doing math with variables

int e = Convert.ToInt16(d); //Converting a float to an int

Console.WriteLine("Float to int" + e); //Printing the converted variable

string str = "I am a string " + "\nI am a string too"; //Declaring and instantiating a strings

Console.WriteLine(str); //Printing strings