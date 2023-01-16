Console.WriteLine(" ");
Console.WriteLine("     In this program you can create a list of the word, ");
Console.WriteLine("         count some character and get his percentaje");
Console.WriteLine("             Press any key to start");
Console.WriteLine(" ");
Console.ReadKey();

/* Count Words */
string[] arrayNewWord;                                            //Creation of my array

Console.WriteLine(" Number of words you wish to enter ");
int sizeOfarraywords = Int32.Parse(Console.ReadLine());          // Create variable type Int to number of the length of my array.

arrayNewWord = new string[sizeOfarraywords];                    //initializate a array with size of declarate by user.


for (int i = 0; i < arrayNewWord.Length; i++)                  //Input the worlds 
{
    Console.WriteLine(" Enter a Word {0}: ", i + 1);           //World
    arrayNewWord[i] = Console.ReadLine();
}

Console.WriteLine();                                            // Print word
Console.WriteLine(" Press any key to show the words ");
Console.ReadKey();

for (int i = 0; i < sizeOfarraywords; i++)
{
    Console.WriteLine("{0}. {1}", i + 1, arrayNewWord[i]);
}

Console.WriteLine("\n Press any Letter Do you want Count ");    // Select caracter to count
char input = Console.ReadKey().KeyChar;

Console.WriteLine("\n The letter Do you Want Count is : " + input);

int count = 0;
for (int i = 0; i < arrayNewWord.Length; i++)                   // count caracter in array
{
    for (int j = 0; j < arrayNewWord[i].Length; j++)
    {
        if (arrayNewWord[i][j] == input)
            count++;
    }
}

Console.WriteLine("\n Total number of \"" + input + "\" is = " + count);

int totalLetters = 0;
for (int i = 0; i < arrayNewWord.Length; i++)                   // Calculate percentage
{
    totalLetters += arrayNewWord[i].Length;
}

double percentage = (count * 100.0) / totalLetters;
Console.WriteLine("\n Percentage of \"" + input + "\" is = " + percentage);
Console.ReadKey();
