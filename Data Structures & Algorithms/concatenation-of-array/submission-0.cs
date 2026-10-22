public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> ans = new List<int>(nums);
        foreach(int i in nums)
            ans.Add(i);
        return ans.ToArray();
    }
}