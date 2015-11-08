
namespace Algorithms.ReorderArrayForIndex
{
    public class ReorderArrForIndex
    {
        public void Reorder(ref int[] array, int[] index, int n)
        {
            for (var i = 0; i < n; i++)
            {
                if (index[i] != i)
                {
                    Swap(ref array, ref index, array[i], index[i]);
                }
            }
        }

        private void Swap(ref int[] array, ref int[] index, int val, int idx)
        {
            if(index[idx] == idx)
                return;

            var oldVal = array[idx];
            var oldIdx = index[idx];
            array[idx] = val;
            index[idx] = idx;
            Swap(ref array, ref index, oldVal, oldIdx);
        }
    }
}
