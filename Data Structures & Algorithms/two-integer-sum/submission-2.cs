public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Brute Force Method - Loop left to right doing sum operations
        // Since we know EXACTLY 1 set MUST exist, return when operation matches target
        for (int i = 0; i < nums.Length; i++) {
            // Add 1 to starting index since i cannot share an index with j
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target)
                    return new int[2] { i, j };
            }
        }
        return new int[0];
    }
}
