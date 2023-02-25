bool isWork = true;

while (isWork)
{
    Console.Write("Введите номер задания :");

    int.TryParse(Console.ReadLine(), out int w);
    {
        switch (w)
        {
            case 1:
                {
                    int firstLength = ReadInt("SecondLength");
                    int secondLength = ReadInt("FirstLength");


                    int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
                    PrintArray(array);
                    System.Console.WriteLine();
                    GetIndexesOfMinNumber(array);
                    PrintArray(array);

                    int ReadInt(string arg)
                    {
                        int number = 0;
                        Console.Write($"Введите {arg}: ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Попробуйте ещё раз ");
                        }

                        return number;
                    }

                    int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                    {
                        int[,] array = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < firstLength; i++)
                        {
                            for (int j = 0; j < secondLength; j++)
                            {
                                array[i, j] = random.Next(0, 10);
                            }
                        }
                        return array;
                    }

                    void GetIndexesOfMinNumber(int[,] array)
                    {
                        int temp = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                for (int x = 0; x < array.GetLength(1) - 1; x++)
                                {
                                    if (array[i, x] < array[i, x + 1])
                                    {

                                        temp = array[i, x + 1];
                                        array[i, x + 1] = array[i, x];
                                        array[i, x] = temp;

                                    }
                                }
                            }
                        }
                    }
                    void PrintArray(int[,] array)
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }

                            Console.WriteLine();
                        }
                    }

                    break;
                }
            case 2:
                {

                    int firstLength = ReadInt("SecondLength");
                    int secondLength = ReadInt("FirstLength");
                    int[,] array = CreateTwoDimensionArray(firstLength, secondLength);
                    PrintArray(array);
                    System.Console.WriteLine();
                    СountingTheSumOfElements(array);

                    int ReadInt(string arg)
                    {
                        int number = 0;
                        Console.Write($"Введите {arg}: ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Попробуйте ещё раз ");
                        }

                        return number;
                    }

                    int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
                    {
                        int[,] array = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < firstLength; i++)
                        {
                            for (int j = 0; j < secondLength; j++)
                            {
                                array[i, j] = random.Next(0, 10);
                            }
                        }
                        return array;
                    }

                    void СountingTheSumOfElements(int[,] array)
                    {
                        int[] arrayLine = new int[array.GetLength(0)];
                        int temp = 0;
                        int indMin = 0;
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                int x = 0;
                                while (x < array.GetLength(1))
                                {
                                    temp = array[i, x] + temp;
                                    arrayLine[i] = temp;
                                    x++;
                                }
                                temp = 0;
                            }
                        }
                        System.Console.WriteLine("Сумму элементов в каждой строке!");
                        System.Console.WriteLine(string.Join("  ", arrayLine));
                        for (int i = 0; i < arrayLine.Length; i++)
                        {
                            if (arrayLine[i] < arrayLine[indMin])
                            {
                                indMin = i;
                            }

                        }
                        System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indMin + 1}");
                    }

                    void PrintArray(int[,] array)
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }

                            Console.WriteLine();
                        }
                    }

                    break;
                }
            case 3:
                {
                    int firstLength = 2;
                    int secondLength = 2;
                    int[,] arrayOne = MatrixOne(firstLength, secondLength);
                    int[,] arrayTwo = MatrixTwo(firstLength, secondLength);
                    int[,] arraProduct = ProductMatrix(arrayOne, arrayTwo);
                    System.Console.WriteLine();
                    PrintArray(arrayOne);
                    System.Console.WriteLine();
                    PrintArray(arrayTwo);
                    System.Console.WriteLine();
                    PrintArray(arraProduct);


                    int[,] MatrixOne(int firstLength, int secondLength)
                    {
                        int[,] arrayOne = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < firstLength; i++)
                        {
                            for (int j = 0; j < secondLength; j++)
                            {
                                arrayOne[i, j] = random.Next(1, 10);
                            }
                        }
                        return arrayOne;
                    }

                    int[,] MatrixTwo(int firstLength, int secondLength)
                    {
                        int[,] arrayTwo = new int[firstLength, secondLength];
                        Random random = new Random();

                        for (int i = 0; i < firstLength; i++)
                        {
                            for (int j = 0; j < secondLength; j++)
                            {
                                arrayTwo[i, j] = random.Next(1, 10);
                            }
                        }
                        return arrayTwo;
                    }

                    int[,] ProductMatrix(int[,] arrayOne, int[,] arrayTwo)
                    {
                        int[,] arraProduct = new int[firstLength, secondLength];

                        arraProduct[0, 0] = arrayOne[0, 0] * arrayTwo[0, 0] + arrayOne[0, 1] * arrayTwo[1, 0];
                        arraProduct[1, 0] = arrayOne[1, 0] * arrayTwo[0, 0] + arrayOne[1, 1] * arrayTwo[1, 0];
                        arraProduct[0, 1] = arrayOne[0, 0] * arrayTwo[0, 1] + arrayOne[0, 1] * arrayTwo[1, 1];
                        arraProduct[1, 1] = arrayOne[1, 0] * arrayTwo[0, 1] + arrayOne[1, 1] * arrayTwo[1, 1];

                        return arraProduct;
                    }

                    void PrintArray(int[,] array)
                    {
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }

                            Console.WriteLine();
                        }
                    }

                    break;
                }
            case 4:
                {

                    int firstLength = ReadInt("SecondLength");
                    int secondLength = ReadInt("FirstLength");
                    int thirdLength = ReadInt("Figth");
                    int[,,] array = CreateTwoDimensionArray(firstLength, secondLength, thirdLength);
                    System.Console.WriteLine();

                    int ReadInt(string arg)
                    {
                        int number = 0;
                        Console.Write($"Введите {arg}: ");

                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Попробуйте ещё раз ");
                        }

                        return number;
                    }

                    int[,,] CreateTwoDimensionArray(int firstLength, int secondLength, int thirdLength)
                    {
                        int[,,] array = new int[firstLength, secondLength, thirdLength];

                        int a = 10;
                        for (int i = 0; i < firstLength; i++)
                        {
                            for (int j = 0; j < secondLength; j++)
                            {
                                for (int d = 0; d < thirdLength; d++)
                                {
                                    array[i, j, d] = a++;
                                    Console.WriteLine($"{array[i, j, d]} - ({i},{j},{d}) ");
                                    if (array[i, j, d] > 90)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        return array;
                    }

                    break;
                }

            case -1: isWork = false; break;
        }

    }
}

