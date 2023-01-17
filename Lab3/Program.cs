/*************  Lab 3  **********/

/****** Excersice 1 *************/

int[] listOfNumber = { 1, 2, 3, 4, 7, 9, 2, 4 };
int counter;

Console.WriteLine("Numbers that appear twice in the list: ");

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

/****** Excersice 2 *************/


int[] listOfNumber1 = { 1, 2, 3, 4, 5 };
int[] listOfNumber2 = { 2, 5, 7, 9, 13 };
int[] listOfResult = new int[listOfNumber1.Length + listOfNumber2.Length];

int counter1 = 0;
int counter2 = 0;
int counter3 = 0;

