namespace SearchLibrary
{
    public class LinearSearch
    {
        public int Search(int key, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                    return i;
            }
            return -1;
        }
    }
}