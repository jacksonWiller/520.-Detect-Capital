public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == null){
            return false;
        }  

       if(word.All(char.IsLower) || word.All(char.IsUpper)){
        return true;
       }

       if(char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower)){
        return true;
       }

       return false;
    }
}
