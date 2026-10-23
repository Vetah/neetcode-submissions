public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary of Value to Index
        Dictionary<int, int> indices = new Dictionary<int, int>();

        // Populate Dictionary
        for (int i = 0; i < nums.Length; i++){
            indices[nums[i]] = i;
        }

        // Second Pass for Calculations
        for (int i = 0; i < nums.Length; i++){
            int difference = target - nums[i];

            // If difference is present as key and the index doesn't match (i != j)
            if (indices.ContainsKey(difference) && i != indices[difference]){
                return new int[2]{i, indices[difference]};
            }
        }

        // Return empty array if no target found
        return new int[0];
    }
}
