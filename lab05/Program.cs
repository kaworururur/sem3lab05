//using System;

//public class MyMatrix
//{
//    private double[,] _matrix;
//    public int Rows { get; private set; }
//    public int Columns { get; private set; }

//    // Конструктор для создания матрицы с заданным количеством строк и столбцов
//    public MyMatrix(int rows, int columns, double minValue, double maxValue)
//    {
//        Rows = rows;
//        Columns = columns;
//        _matrix = new double[Rows, Columns];
//        Fill(minValue, maxValue);
//    }

//    // Метод для заполнения матрицы случайными значениями
//    public void Fill(double minValue, double maxValue)
//    {
//        Random rnd = new Random();
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Columns; j++)
//            {
//                _matrix[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
//            }
//        }
//    }

//    // Метод для изменения размера матрицы
//    public void ChangeSize(int newRows, int newColumns)
//    {
//        double[,] newMatrix = new double[newRows, newColumns];

//        // Копируем старые значения в новую матрицу
//        for (int i = 0; i < Math.Min(Rows, newRows); i++)
//        {
//            for (int j = 0; j < Math.Min(Columns, newColumns); j++)
//            {
//                newMatrix[i, j] = _matrix[i, j];
//            }
//        }

//        // Заполняем оставшиеся элементы случайными значениями, если новая матрица больше
//        if (newRows > Rows || newColumns > Columns)
//        {
//            Fill(0, 10); // Дозаполнение случайными числами от 0 до 10 (можно изменить диапазон)
//            for (int i = 0; i < newRows; i++)
//            {
//                for (int j = 0; j < newColumns; j++)
//                {
//                    if (i >= Rows || j >= Columns)
//                    {
//                        newMatrix[i, j] = _matrix[i, j]; // Копируем из предыдущей
//                    }
//                }
//            }
//        }

//        // Обновляем свойства и заменяем старую матрицу
//        Rows = newRows;
//        Columns = newColumns;
//        _matrix = newMatrix;
//    }

//    // Метод для частичного отображения матрицы
//    public void ShowPartialy(int startRow, int endRow, int startCol, int endCol)
//    {
//        for (int i = startRow; i <= endRow && i < Rows; i++)
//        {
//            for (int j = startCol; j <= endCol && j < Columns; j++)
//            {
//                Console.Write($"{_matrix[i, j]:F2} ");
//            }
//            Console.WriteLine();
//        }
//    }

//    // Метод для отображения всей матрицы
//    public void Show()
//    {
//        for (int i = 0; i < Rows; i++)
//        {
//            for (int j = 0; j < Columns; j++)
//            {
//                Console.Write($"{_matrix[i, j]:F2} ");
//            }
//            Console.WriteLine();
//        }
//    }

//    // Индексатор для доступа к элементам матрицы
//    public double this[int index1, int index2]
//    {
//        get
//        {
//            if (index1 < 0 || index1 >= Rows || index2 < 0 || index2 >= Columns)
//            {
//                throw new IndexOutOfRangeException("Индекс вне диапазона.");
//            }
//            return _matrix[index1, index2];
//        }
//        set
//        {
//            if (index1 < 0 || index1 >= Rows || index2 < 0 || index2 >= Columns)
//            {
//                throw new IndexOutOfRangeException("Индекс вне диапазона.");
//            }
//            _matrix[index1, index2] = value;
//        }
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Введите количество строк: ");
//        int rows = int.Parse(Console.ReadLine());

//        Console.Write("Введите количество столбцов: ");
//        int columns = int.Parse(Console.ReadLine());

//        Console.Write("Введите минимальное значение для случайных чисел: ");
//        double minValue = double.Parse(Console.ReadLine());

//        Console.Write("Введите максимальное значение для случайных чисел: ");
//        double maxValue = double.Parse(Console.ReadLine());

//        MyMatrix matrix = new MyMatrix(rows, columns, minValue, maxValue);

//        Console.WriteLine("\nИсходная матрица:");
//        matrix.Show();

//        // Изменение размера матрицы
//        Console.Write("\nВведите новое количество строк: ");
//        int newRows = int.Parse(Console.ReadLine());

//        Console.Write("Введите новое количество столбцов: ");
//        int newColumns = int.Parse(Console.ReadLine());

//        matrix.ChangeSize(newRows, newColumns);
//        Console.WriteLine("\nНовая матрица:");
//        matrix.Show();

//        // Частичное отображение матрицы
//        Console.WriteLine("\nЧастичное отображение матрицы:");
//        matrix.ShowPartialy(0, 1, 0, 1); // Пример: показываем часть с (0, 0) по (1, 1)
//    }
//}

//using System;

//public class MyList<T>
//{
//    private T[] _items;  // Массив для хранения элементов
//    private int _count;   // Текущая длина массива
//    private const int _initialCapacity = 4; // Начальная ёмкость массива

//    // Конструктор с начальной ёмкостью
//    public MyList(int capacity = _initialCapacity)
//    {
//        _items = new T[capacity];
//        _count = 0;
//    }

//    // Свойство для получения общего количества элементов
//    public int Count
//    {
//        get { return _count; }
//    }

//    // Индексатор для доступа к элементам
//    public T this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= _count)
//            {
//                throw new IndexOutOfRangeException("Индекс вне диапазона.");
//            }
//            return _items[index];
//        }
//        set
//        {
//            if (index < 0 || index >= _count)
//            {
//                throw new IndexOutOfRangeException("Индекс вне диапазона.");
//            }
//            _items[index] = value;
//        }
//    }

//    // Метод для добавления элемента
//    public void Add(T item)
//    {
//        // Если массив заполнен, увеличиваем его размер
//        if (_count == _items.Length)
//        {
//            Resize();
//        }

//        _items[_count] = item; // Добавление нового элемента
//        _count++; // Увеличение счётчика элементов
//    }

//    // Метод для изменения размера массива
//    private void Resize()
//    {
//        int newCapacity = _items.Length * 2; // Удваиваем ёмкость
//        T[] newItems = new T[newCapacity]; // Создаём новый массив
//        Array.Copy(_items, newItems, _count); // Копируем старые элементы в новый массив
//        _items = newItems; // Заменяем старый массив новым
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        MyList<int> myList = new MyList<int>();

//        // Добавляем элементы в список
//        for (int i = 0; i < 10; i++)
//        {
//            myList.Add(i * 10);
//        }

//        // Выводим элементы списка
//        Console.WriteLine("Элементы списка:");
//        for (int i = 0; i < myList.Count; i++)
//        {
//            Console.WriteLine(myList[i]);
//        }

//        // Изменяем элемент по индексу
//        myList[2] = 999;
//        Console.WriteLine($"\nПосле изменения элемента по индексу 2:");

//        // Выводим обновлённые элементы списка
//        for (int i = 0; i < myList.Count; i++)
//        {
//            Console.WriteLine(myList[i]);
//        }

//        // Вывод общего количества элементов
//        Console.WriteLine($"\nОбщее количество элементов: {myList.Count}");
//    }
//}

using System.Collections;


class Program
{
    static void Main()
    {
        var myDict = new MyDictionary<string, int>(("apple", 5), ("banana", 3), ("orange", 10), ("arbuz", 8));
        Console.WriteLine($"Размер словаря: {myDict.Size}");
        Console.WriteLine($"Значение для 'banana': {myDict["banana"]}");
        myDict["banana"] = 4;
        Console.WriteLine($"Новое значение для 'banana': {myDict["banana"]}");
        Console.WriteLine("Элементы словаря:");
        myDict.Add("grape", 111);

        foreach (KeyValuePair<string, int> pair in myDict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

class MyDictionary<Tkey, Tvalue> : IEnumerable
{
    private Tkey[] keys;
    private Tvalue[] values;

    public MyDictionary(params (Tkey, Tvalue)[] elems)
    {
        keys = new Tkey[elems.Length];
        values = new Tvalue[elems.Length];
        for (int i = 0; i < elems.Length; i++)
        {
            keys[i] = elems[i].Item1;
            values[i] = elems[i].Item2;
        }
    }
    public void Add(Tkey key, Tvalue value)
    {
        if (keys.Contains(key))
        {
            return;
        }
        keys.Append(key);
        values.Append(value);
    }
    public Tvalue this[Tkey key]
    {
        get
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (key.Equals(keys[i]))
                {
                    return values[i];
                }
            }
            return default;
        }
        set
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (key.Equals(keys[i]))
                {
                    values[i] = value;
                    return;
                }
            }
            Add(key, value);
        }
    }
    public int Size => keys.Length;

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < Size; i++)
        {
            yield return new KeyValuePair<Tkey, Tvalue>(keys[i], values[i]);
        }
    }


}