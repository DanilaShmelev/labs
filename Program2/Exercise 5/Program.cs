﻿using General;
using Local_Class;

const int n = 10; 
const int minValue = -1000;
const int maxValue = 1000;

int[] array = GlobalClass.GetRandomArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.OutputArray(array);

Console.Write("\nПоложительный массив: ");
array = LocalClass.DeleteMinusElements(array);
GlobalClass.OutputArray(array);

Console.ReadKey();