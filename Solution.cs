using System;

namespace _00007_ReverseInteger
{
    class Solution
    {
        public int Reverse(int x)
        {
            int answer = 0;
            while (x != 0)
            {
                x = Math.DivRem(x, 10, out int remainder);
                try
                {
                    answer = checked(answer = answer * 10 + remainder);
                }
                catch
                {
                    return 0;
                }
            }
            return answer;
        }
    }
}
