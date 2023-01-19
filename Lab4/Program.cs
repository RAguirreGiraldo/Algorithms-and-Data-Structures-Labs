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
