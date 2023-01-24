/*
  Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
*/
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        foreach (int num in nums){
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        PriorityQueue<int, int> heap = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => x - y)
        );
        foreach (var freqEntry in freqMap){
            heap.Enqueue(freqEntry.Key, freqEntry.Value);
            if (heap.Count > k)
                heap.Dequeue();
        }

        int[] result = new int[k];
        for (int i = k - 1; i >= 0; i--){
            result[i] = heap.Dequeue();
        }

        return result;
    }

}
