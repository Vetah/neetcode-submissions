public class Solution {
    public bool hasDuplicate(int[] nums) {
        // Duplicates on key indicates HashSet
        HashSet<int> seen = new HashSet<int>();


        foreach(int num in nums){
            // .Add returns bool of false if key exists
            if (!seen.Add(num))
                return true;
        }

        // Return false if no duplicates
        return false;
    }
}