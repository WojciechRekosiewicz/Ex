using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }

        T Data { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
  
    }
}
