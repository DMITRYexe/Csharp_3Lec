//Задача на упорядовачивание массива
// Будем использоват алгоритм сортировки мин и макс'а
int [] array1 = { 1, 5 ,4, 3, 2, 6 ,7, 3 ,1};

void PrintArray (int [] array) // методля вывода массива
{
  int count = array.Length;
  for ( int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void ArrayOrdering ( int [] array)
{

  for ( int i = 0; i < array.Length - 1; i++) // проходим весь массив, каждый раз проверяя минимальное значение, благодаря второму циклу for
  {
    int minPosition = i;

    for (int j=i+1; j < array.Length; j++) // этот блок кода ищет минимальный элемент. Чтобы для j присваивалось общее кол-во элементов (а не +1), мы в первом FOR отняли от общей длины массива единицу
    {
      if (array[j]< array[minPosition]) minPosition=j;
    }
    int temprorary = array[i]; // начинаем производить перестановку i-го элемента с элементом с минимальным значением
    array[i] = array[minPosition]; // присваиваем i-ому элементу позицию мин. элемента
    array[minPosition]= temprorary; // а минимальному элементу присваиваем позицию i-го элемента
  }
}

PrintArray(array1); // вызов первого метода
ArrayOrdering(array1); // вызов второго метода

PrintArray(array1);

