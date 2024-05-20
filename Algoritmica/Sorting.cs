using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] v = { 2, 10, 7, 1, 117 };
        Console.Write($"Il tuo array iniziale è:");
        showArray(v);

        //bubblesort(v);
        //insertionsort(v);
        //recBubbleSort(v);
        //mergeSort(v);
        Console.Write($"\n\nIl tuo array ordinato è:");
        showArray(v);
    }
    public static void showArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($" {a[i]}");
        }
    }
    public static int[] bubblesort(int[] a) //testato e funzionante
    {
        int box;
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    box = a[j + 1];
                    a[j + 1] = a[j];
                    a[j] = box;
                }
            }
        }
        return a;
    }
    public static int[] insertionsort(int[] a) //WiP, vanno sistemate alcune cose //secondo commento aggiunto il 20/05, LO AVEVO FATTO E FINITO NELLE NOTE DEL TELEFONO E FUNZIONAVA MA POI HO CAMBIATO TELEFONO E HO PERSO LE NOTE O*DOCROP
    {
        int box;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (a[i] < a[j])
                {
                    box = a[i];
                    a[i] = a[j];
                    a[j] = box;
                    break;
                }
            }
        }
        return a;
    }
    static void recBubbleSort(int[] arr)
    {
        bubbleSortExecute(arr, arr.Length);
    }
    static void bubbleSortExecute(int[] arr, int n) //fonte geektogeek, bubblesort ricorsivo
    {

        if (n == 1)        // Base case
            return;
        int count = 0;      // One pass of bubblesort. After this pass, the largest element is moved (or bubbled) to end. 
        for (int i = 0; i < n - 1; i++)
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                count++;
            }
        if (count == 0)                        // Check if any recursion happens or not. If any recursion is not happen then return 
            return;
        bubbleSortExecute(arr, n - 1);         // Largest element is fixed, recur for remaining array 
    }
    public static int[] mergeSort(int[] v)
    {
        int[] left, right;
        int[] result = new int[v.Length];
        if (v.Length <= 1)        // È rimasta solo una casella, quindi non può essere diviso oltre
            return v;
        if (v.Length % 2 == 0)
        {
            left = v.Take((v.Length) / 2).ToArray();
            right = v.Skip((v.Length) / 2).ToArray();
        }
        else
        {
            left = v.Take((v.Length + 1) / 2).ToArray();
            right = v.Skip((v.Length + 1) / 2).ToArray();
        }
        mergeSort(left);
        mergeSort(right);
        result = merge(left, right);
        return result;

    }
    public static int[] merge(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
        int indexL = 0, indexR = 0, indexRes = 0;
        if(indexL < left.Length || indexR < right.Length) //se ci sono ancora elementi nell'uno o nell'altro
        {
            if(indexL < left.Length && indexR < right.Length) //se ci sono ancora elementi in ENTRAMBI
            {
                if (left[indexL] > right[indexR])
                {
                    result[indexRes] = right[indexR];
                    indexRes++;
                    indexR++;
                }
                else
                {
                    result[indexRes] = left[indexL];
                    indexRes++;
                    indexL++;
                }
            }
            if(indexL < left.Length)
            {
                result[indexRes] = left[indexL];
                indexRes++;
                indexL++;
            }
            if(indexR < right.Length)
            {
                result[indexRes] = right[indexR];
                indexRes++;
                indexR++;
            }
        }
        return result;
    }

}