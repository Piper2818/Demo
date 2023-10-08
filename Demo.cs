using System;
using System.Linq; 

namespace Method {

  class Program {   

    // method declaration
    static int SmallestNum() {
      int[] A = {-1,-3};
      Array.Sort(A);
      //A.Distinct().ToArray();
      int[] newA = A.Distinct().ToArray();
      
      int LowestNum = 0;
      string Done = "false";
      int i = 1; 
      //for(int i = 1; i < newA.Length; i++)
      while(Done == "false")
        {   
            //int status = newA[i-1].CompareTo(i);
            bool num = A.Contains(i);
            
            if(num == true)
            {
                
                LowestNum = LowestNum + 1; 
            }
            else
            {
                LowestNum = i;
                Done = "true";
            }
            i++;
            //Console.WriteLine(status);
            //Console.WriteLine(i);
            //Console.WriteLine(newA[i]);
        }
      return LowestNum;
      
    }

    static void Main(string[] args) {

      // call method 
      int LowestNum = SmallestNum();

      Console.WriteLine(LowestNum);
      Console.ReadLine();
     
    }
  }
}
