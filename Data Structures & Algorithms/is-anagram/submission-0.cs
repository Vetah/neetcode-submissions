public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> count1 = new Dictionary<char, int>();
        Dictionary<char, int> count2 = new Dictionary<char, int>();

        for (int c = 0; c < s.Length; c++){
            if(!count1.TryAdd(s[c], 1)){
                count1[s[c]] += 1;
            }

            if(!count2.TryAdd(t[c], 1)){
                count2[t[c]] += 1;
            }
        }

        if(count1.Count == count2.Count){
            foreach(var val in count1){
                if(count2.ContainsKey(val.Key)){
                    if(val.Value != count2[val.Key])
                        return false;
                }
                else
                    return false;
            }
        }
        else
            return false;
        
        return true;
    }
}
