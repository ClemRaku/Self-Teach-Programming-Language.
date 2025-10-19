//printing a string variable
string Jesus_Christ = "Praise the Great leader... Jesus Christ";
Console.WriteLine(Jesus_Christ);

//printing an integer variable
int num_of_jesus = 1;
Console.WriteLine(num_of_jesus);

//'var' data type can detect any sort of data type
var number_or_name = "Jesus or 1";
Console.WriteLine(number_or_name);

string characterName = "John";
int characterAge;
characterAge = 35;
Console.WriteLine("There was once a man named "+ characterName +"\nHe was "+characterAge+" years old");
characterName = "Mike" + " Wallbarg";
Console.WriteLine("He really liked the name " + characterName + "\nBut didn't like being "+characterAge);

string name = "Raka";
//'.Length' basically prints the length of the name
Console.WriteLine(name.Length);
//'ToUpper' is a method that makes all the characters in a string Capital & 'ToLower' does the opposite
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());
//Basically says 'true' or 'false' and checks whether the parameter is present in the variable or not.
Console.WriteLine(characterName.Contains("Wallbarg"));
//the square brackets are used to index
Console.WriteLine(name[0]);
//'IndexOf()' basically states the position of the parameter inside the variable
Console.WriteLine(name.IndexOf('a'));
//Substring basically captures a part of the string. The first parameter is used the starting point, second parameter suggest the length.
Console.WriteLine(characterName.Substring(5));
Console.WriteLine(characterName.Substring(0, 4));