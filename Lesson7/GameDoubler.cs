using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    delegate void Update();

    class GameDoubler
    {
        int finish;
        int current;
        int count;
        int minCount;
        

        public event Update SetUpdate;

        public int Finish => finish;

        public int Current
        {
            get { return current; }
        }

        public int Count => count;

        public int MinCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        Stack<int> stack = new Stack<int>();


        public GameDoubler(int finish)
        {
            this.finish = finish;
            current = 1;
            count = 0;
            if (SetUpdate!=null) SetUpdate();
            //SetUpdate?.Invoke();
            //minCount=?
        }

        public void Plus()
        {
            stack.Push(current);
            current++;
            count++;
            SetUpdate?.Invoke();
        }

        public void Multi()
        {
            stack.Push(current);
            current *= 2;
            count++;
            SetUpdate?.Invoke();
        }

        public void Reset()
        {
            stack.Clear();
            current = 1;
            count = 0;
            SetUpdate?.Invoke();
        }

        public void Back()
        {
            if (stack.Count>0) current = stack.Pop();
            count++;
            SetUpdate?.Invoke();
        }
    }
}
