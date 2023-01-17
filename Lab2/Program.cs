
/*  Firts Exercise */

Console.WriteLine("Check if the following string counts repeated words: programmatic python");
string wordString = "programmatic python";
char[] repeatedChar = new char[wordString.Length];
int count = 0;

for (int i = 0; i < wordString.Length; i++)
{
    char currentChar = wordString[i];
    bool letterChecked = false;

    for (int k = 0; k < i; k++)  //This cicle verify if my code check the letter
    {
        if (wordString[k] == currentChar)
        {
            letterChecked = true;
        }
    }

}