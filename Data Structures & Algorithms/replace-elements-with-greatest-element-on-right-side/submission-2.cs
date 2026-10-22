public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int previousNum = 0;
        int currentNum = 0;
        for (int i = arr.Length-1; i >= 0; i--){
            if(i == arr.Length-1){
                previousNum = arr[i];
                arr[i] = -1;
                continue;
            }

            if(arr[i] < previousNum){
                arr[i] = previousNum;
            }
            else{
                currentNum = arr[i];
                arr[i] = previousNum;
                previousNum = currentNum;
            }
                
        }

        return arr;
    }
}