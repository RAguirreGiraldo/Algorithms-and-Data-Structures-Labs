/***************  Lab # 4 *******************/

/*************** Exercise 1 ****************/

 
//declaring a list of lists of integers
List<int> dataListBack= new List<int>();

List<List<int>> dataList = new List<List<int>>() {
            new List<int>() { 1, 5, 3 },
            new List<int>() { 9, 7, 3, -2 },
            new List<int>() { 2, 1, 2 }
        };

for (int i = 0; i < 3; i++)
{
    int max = 0;
    for (int j = 0; j < 3; j++)
    {
        if (dataList[i][j] > max)
            max = dataList[i][j];
    }

    dataListBack.Add(max);
}

for (int k = 0; k < 3; k++)
{
    Console.Write($"{dataListBack[k]} ");
}
Console.WriteLine(" ");
Console.WriteLine();

/*************** Exercise 2 ****************/

// Create a list of list containing student grades.

List<List<int>> grades = new List<List<int>>
            {
                new List<int> {85,92, 67, 94, 94},
                new List<int> {50, 60, 57, 95},
                new List<int> {95}
            };

int highestGrade = 0;

for (int i = 0; i < grades.Count; i++)
{
    for (int j = 0; j < grades[i].Count; j++)
    {
        int studentGrade = grades[i][j];
        if (studentGrade > highestGrade)
            highestGrade = studentGrade;
    }
}





/*************** Exercise 3 ****************/

int[] array = { 6, -2, 5, 3 };

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int order = array[j];
            array[j] = array[j + 1];
            array[j + 1] = order;
        }
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
    