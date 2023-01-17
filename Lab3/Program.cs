﻿/*************  Lab 3  **********/

/****** Excersice 1 *************/

int[] listOfNumber = { 1, 2, 3, 4, 7, 9, 2, 4 };
int counter;

Console.Write("Numbers that appear twice in the list : ");

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

Console.WriteLine(" ");

while (counter1 < listOfNumber1.Length && counter2 < listOfNumber2.Length)
{
    if (listOfNumber1[counter1] < listOfNumber2[counter2])
    {
        listOfResult[counter3] = listOfNumber1[counter1];
        counter1++;
    }
    else
    {
        listOfResult[counter3] = listOfNumber2[counter2];
        counter2++;
    }

    counter3++;
}

while (counter1 < listOfNumber1.Length)
{
    listOfResult[counter3] = listOfNumber1[counter1];
    counter1++;
    counter3++;
}

while (counter2 < listOfNumber2.Length)
{
    listOfResult[counter3] = listOfNumber2[counter2];
    counter2++;
    counter3++;
}

Console.WriteLine(" ");
Console.Write("New Matrix { ");
for (int i = 0; i < listOfResult.Length; i++)
{
    Console.Write(listOfResult[i] + " ");
}
Console.Write(" }");
Console.WriteLine();

/****** Excersice 3 *************/


int[] InputReversible = { 3415 };
