namespace Baitap10_QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 6, 5, 8, 7, 4 };
            duyetmang("Mang ban dau: ", arr);
            quicksort(arr, 0, arr.Length - 1);
            duyetmang("Mang sau khi quick sort: ", arr);
        }
        static void quicksort(int[] arr, int dau, int cuoi)
        {
            int left = dau;
            int right = cuoi;
            int? point = timpoint(arr, dau, cuoi);
            while (left <= right)
            {
                while (left <= cuoi && arr[left] < point) left++;
                while (right >= dau && arr[right] >= point) right--;
                if (left < right)
                {
                    doicho(arr, left, right);
                    left++;
                    right--;
                }
                if (right > dau) quicksort(arr, dau, right);
                if (left < cuoi) quicksort(arr, left, cuoi);
            }
        }
        static void doicho(int[] arr, int a, int b)
        {
            int luutru = arr[a];
            arr[a] = arr[b];
            arr[b] = luutru;
        }
        static int? timpoint(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                if (arr[i] != arr[left])
                {
                    if (arr[i] > arr[left]) return arr[i];
                    else return arr[left];
                }
            }
            return null;
        }
        static void duyetmang(string noidung, int[] arr)
        {
            if (noidung != null) Console.Write(noidung);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length -1) Console.Write(", ");
            }
            Console.ReadKey();
        }
    }
}
