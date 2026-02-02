var arrs = new int[][]
{
    new int[] { 1, 2,3 },
    new int[] { 1, 2 ,3,5},
    new int[] { 1, 2 ,6,7,8,9},
};


for (int i = 0; i < arrs.Length; i++)
{
    Console.WriteLine("Guruh element soni: " + arrs[i].Length);

    for(int j = 0; j < arrs[i].Length; j++)
    {
        Console.WriteLine(arrs[i][j].ToString());
    }
}