// https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3292/
using System;
using System.Collections.Generic;

public class MinStack
{
	// Stack + tuple (val, min)
	Stack<(int, int)> stack;
	public MinStack()
	{
		stack = new Stack<(int, int)>();
	}

	public void Push(int x)
	{
		if (stack.Count == 0)
			stack.Push((x, x));
		else
			stack.Push((x, Math.Min(stack.Peek().Item2, x)));
	}

	public void Pop()
	{
		stack.Pop();
	}

	public int Top()
	{
		return stack.Peek().Item1;
	}

	public int GetMin()
	{
		return stack.Peek().Item2;
	}
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
