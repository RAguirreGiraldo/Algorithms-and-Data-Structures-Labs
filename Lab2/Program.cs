
/****************************  Firts Exercise ***********************************************/
/*
Console.WriteLine("Check if the following string counts repeated words: programmatic python");
string wordString = "programmatic python";
char[] repeatedLetters = new char[wordString.Length];
int count = 0;

for (int i = 0; i < wordString.Length; i++)
{
    char currentChar = wordString[i];
    bool alreadyChecked = false;

    // Comprobamos si ya hemos revisado la letra
    for (int k = 0; k < i; k++)
    {
        if (wordString[k] == currentChar)
        {
            alreadyChecked = true;
        }
    }

    if (!alreadyChecked)
    {
        for (int j = 0; j < wordString.Length; j++)
        {
            if (wordString[i] == wordString[j] && i != j)
            {
                repeatedLetters[count] = wordString[i];
                count++;
            }
        }
    }
}

Console.WriteLine("Characters that are repeated: " + string.Join(" ", repeatedLetters));
Console.WriteLine();
*/

/****************************  Second Exercise ***********************************************/
/*

char[] SpaceCharacter = { ' ' };                                                                // Space character

string compareString = "To be or not to be";

string[] words = compareString.Split(SpaceCharacter, StringSplitOptions.RemoveEmptyEntries); // Split the string into individual words

string[] individualWords = new string[words.Length];                                              // An array used to store unique words

int i = 0;
foreach (string word in words)                                                                      // Check if the current word exists in the array
{
    if (!individualWords.Contains(word)) // If not - add it to the array
    {
        individualWords[i] = word;
        i++;
    }
}

Console.WriteLine("individual Words");                                                          //Print
foreach (string word in individualWords)
{
    if (word != null)
    {
        Console.WriteLine(word);
        Console.WriteLine();
    }
}
*/

/****************************  Third Exercise ***********************************************/
Console.WriteLine(" Exercise #3 ");
Console.WriteLine("Enter a phrase to be inverted : ");
Console.WriteLine();
string introString = Console.ReadLine();
Console.WriteLine(" Press key to Continue ");

char[] arrIntroString = introString.ToCharArray();
Array.Reverse(arrIntroString);

Console.WriteLine("The inverted phrase is  :");
Console.WriteLine(arrIntroString);
Console.WriteLine();
Console.WriteLine(" Press key to Continue ");
Console.WriteLine();
Console.ReadKey();

/****************************  Exercise Four ***********************************************/

string showLongestWord = "Tiptoe through the tulips";

string[] wordsCompare = showLongestWord.Split(" ");
int size = 0;
string[] max = new string[0];

for (int i = 0; i < wordsCompare.Length; i++)
{
    if (wordsCompare[i].Length >= size)
    {
        size = wordsCompare[i].Length;
        if (max.Length > 0 && max[max.Length - 1].Length == wordsCompare[i].Length)
        {
            string[] tempMax = new string[max.Length + 1];
            for (int j = 0; j < max.Length; j++)
            {
                tempMax[j] = max[j];
            }
            tempMax[tempMax.Length - 1] = wordsCompare[i];
            max = tempMax;
        }
        else
        {
            max = new string[1];
            max[0] = wordsCompare[i];
        }
    }
}

Console.WriteLine(" Exercise #4 ");
Console.WriteLine();
Console.WriteLine("The word most Longer is : " + max[0]);