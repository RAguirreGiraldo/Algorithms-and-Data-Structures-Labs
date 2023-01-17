/*************  Lab 3  **********/

/****** Excersice 1 *************/

int[] listOfNumber = { 1, 2, 3, 4, 7, 9, 2, 4 };
int counter;

Console.Write("Numbers that appear twice in the list: ");

for (int i = 0; i < listOfNumber.Length; i++)
{
    bool repeatNumber = false;
    counter = 0;
    for (int j = 0; j < listOfNumber.Length; j++)
    {
        if (listOfNumber[i] == listOfNumber[j])
        {
            counter++;
        }
    }
    if (counter == 2 && repeatNumber == false)
    {
        Console.Write(listOfNumber[i] + " ");
        repeatNumber = true;
    }
}



