using System.Linq;

public partial class Solution
{
    public string ReverseString(string s)
    {
        return string.Join("", s.Reverse());
    }
}