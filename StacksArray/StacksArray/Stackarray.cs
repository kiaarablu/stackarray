using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksArray
{
     class Stackarray
    {
        public int[] stc;
        public int top;
        public int kol;
        public  Stackarray (int sizearray)
        {
            this.stc = new int[sizearray];
            top = -1;
            kol = sizearray;
        }

        public void push(int a)
        {
            if (top == kol)
            {
                Console.WriteLine("stack overflow");
                return;
            }
            else
            {
                top++;
                stc[top] = a;
            }
        }
        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack underlow");
                return;
            }
            else
            {
                Console.WriteLine(stc[top]);
                top--;
                return;
                
            }
        }
         

    }
    
       
    


        
       
        
    
    
        
    
    
       
    

}
