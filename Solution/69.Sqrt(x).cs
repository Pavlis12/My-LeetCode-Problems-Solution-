/*
----------------------------------------
Runtime: 42ms
Memory: 29.64 MB
----------------------------------------
*/
public class Solution {
    public int MySqrt(int x) {
        int mocnina = 0;
           while (((long)mocnina + 1) * (mocnina + 1) <= x) { 
            mocnina++; 
        }
        return mocnina;
    }
}