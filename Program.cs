using System;

public class SearchAlgorithms
{
    // Método de búsqueda de manera binaria
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Verificamiento si el elemento medio es el objetivo
            if (arr[mid] == target)
                return mid;

            // Si el objetivo está en la mitad derecha del array
            if (arr[mid] < target)
                left = mid + 1;
            // Si el objetivo está en la mitad izquierda del array
            else
                right = mid - 1;
        }

        // Si en dado caso no se encuentra el objetivo en el array
        return -1;
    }

    // Método de búsqueda de manera secuencial
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // Retornar el índice del elemento si es encontrado
        }

        // Retornar -1 si el elemento no es encontrado
        return -1;
    }

    // Método para imprimir el resultado de la búsqueda
    public static void PrintSearchResult(int index, int target, string algorithm)
    {
        if (index != -1)
            Console.WriteLine($"El elemento {target} fue encontrado en el índice {index} mediante el algoritmo de búsqueda {algorithm}.");
        else
            Console.WriteLine($"El elemento {target} no fue encontrado utilizando el algoritmo de búsqueda {algorithm}.");
    }

    // Método principal (main)
    public static void Main(string[] args)
    {
        int[] array = { 3, 4, 7, 11, 13, 18, 22, 31, 49, 58 };
        int target = 22;

        // Realizar búsqueda de manera binaria
        int binarySearchIndex = BinarySearch(array, target);
        PrintSearchResult(binarySearchIndex, target, "binaria");

        // Realizar búsqueda de manera secuencial
        int linearSearchIndex = LinearSearch(array, target);
        PrintSearchResult(linearSearchIndex, target, "secuencial");
    }
}

