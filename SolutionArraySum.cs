/* Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums. */ 

public class SolutionArraySum {
     public int[] RunningSum(int[] nums) {
      for(int n=1;n<nums.Length;n++){
          nums[n]+=nums[n-1];
      }  
      return nums;
    }
}
