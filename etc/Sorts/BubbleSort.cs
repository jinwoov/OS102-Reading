namespace BubbleS{
    public class BSort{
        public static void Main(string[] args)
        {
            int[] arr = {5,3,4,2,6};
            BubbleSort(arr);
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

        }

        public static void BubbleSort(int[] arr)
        {
            for(int bubblePart = arr.Length -1; bubblePart > 0; bubblePart-- )
            {
                for(int j = 0; j < bubblePart; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        Swap(arr, j, j+1);
                    }
                }
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            if( i == j )
                return;
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}