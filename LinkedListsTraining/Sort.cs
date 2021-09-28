using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            for(var i = 0; i < arr.Length - 1; i++)
            {
                for (var k = 0; k < arr.Length - 1 - i; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        var temp = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp;
                    }
                }
            }
        }


        public static void Selection(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

        }


        public static void Insertion(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var temp = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }


        public static void MergeSort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
