// https://leetcode.com/problems/lemonade-change/
public partial class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        int fives = 0;
        int tens = 0;

        for (int i = 0; i < bills.Length; i++)
        {
            int current = bills[i];

            if (current == 5)
                fives++;
            else if (current == 10)
            {
                if (fives == 0)
                    return false;

                fives--;
                tens++;
            }
            else // 20
            {
                if (tens > 0 && fives > 0)
                {
                    tens--;
                    fives--;
                }
                else if (fives > 2)
                {
                    fives -= 3;
                }
                else
                {
                    return false;
                }
            }
        }

        return true;
    }
}
