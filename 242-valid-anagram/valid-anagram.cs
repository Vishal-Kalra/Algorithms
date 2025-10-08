public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] arr1= s.ToCharArray();
       char[] arr2= t.ToCharArray();
       Array.Sort(arr1);
       Array.Sort(arr2);
        string s1= new string (arr1);
        string t1= new string (arr2);
       return s1==t1;
    }
}