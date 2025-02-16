/*
Runtime: 28ms
Memory: 30.45 MB
*/

public class Solution {
    public int Reverse(int x) {
        
    string rev = Rev(x.ToString()); 
    int vysl;
    try{
    return int.Parse(rev);
    
}catch(OverflowException){
    vysl = 0;
}
return vysl;
    }
    
public string Rev(string s){
     bool JeZaporne = s[0] =='-';
    char[] charARR = s.ToCharArray();
    if(JeZaporne){
        charARR = s.Substring(1).ToCharArray();
    }else charARR=s.ToCharArray();
    Array.Reverse(charARR);
    string r = new string(charARR);
    if(JeZaporne)
        r ='-'+r;

    return r;

    }
    }