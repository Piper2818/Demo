// C# program to illustrate how to
// remove elements from the stack
using System;
using System.Collections;
using System.Linq; 
using System.Collections.Generic; 
 
class solution{
 
    // Main Method
    static public void Main()
    {
 
        // Create a stack
        // Using Stack class
       
        Stack<int> my_stack = new Stack<int>();
        int[] A = {-3,1,6,4,-2,8};
        Array.Sort(A);
        int[] newA = A.Distinct().ToArray();
        // Adding elements in the Stack
        // Using Push method
        for(int i = 0; i < newA.Length; i++)
        {
             my_stack.Push(newA[i]);
             //Console.WriteLine(newA[i]);
        }
        int LowestNum = 0;
        int current, next; 
        int count = my_stack.Count; 
        
        while(count > 1 || LowestNum == 1 )
        {
            
             current = my_stack.Pop();
             next = my_stack.Peek();
             Console.WriteLine("Pop: {0} ", current);
             Console.WriteLine("Peek: {0} ", next); 
             if(current > (next + 1) && next != 1)
             {
                 LowestNum = next + 1; 
                 
             }
             /*else if (current == next && next != 1)
             {
                 LowestNum = next; 
                 
             }*/
             
             else
             {
                 LowestNum = 2; 
             }
             Console.WriteLine("LowestNum: {0} ", LowestNum); 
             count--;
             
        }
        Console.WriteLine("LowestNum: {0} ", LowestNum); 
        
        
                                                    
    }
}
