public class SearchAlgo
{
    public int Search(int[] array, int target)
    {
        return BinarySearch(array, target, 0, array.Length - 1);
    }

    private int BinarySearch(int[] array,int target,int left,int right)
    {

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(array[mid] == target)
            {
                return mid;
            }
            else if(array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
}

