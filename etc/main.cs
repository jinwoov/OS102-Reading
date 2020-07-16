public class DynamicProgramming{

    public static void Main(string[] arg)
    {

    }

    static int FibonacciNumber(int num)
    {
        int[] dp = new int[num+1];
        fibHelper(n, dp);    
    } 
    public void fibHelper(int n, int[] dp)
    {
        if(n <= 0)
            return 0;
        else if(n == 1)
            return 1;
        else if(dp[n] > 0)
            return dp[n];
        
        dp[n] = fibHelper(n - 1, dp) + fibHelper(n -2, dp);
        return dp[n];
    }

    

}