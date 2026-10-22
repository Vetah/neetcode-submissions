public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int c = 0;
        int t = 0; //tracker
        for (int i = 0; i < nums.Length; i++){
            if(nums[i] == 1  && t == c){
                c++;
                t++;
            }
            else if (nums[i] != 1)
                t = 0;
            else
                t++;
        }

        return c;
    }
}