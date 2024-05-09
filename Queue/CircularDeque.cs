namespace Application;
public partial class QueueSolution
{
    public class MyCircularDeque
    {
        private Node _front;
        private Node _rear;
        private int _k;
        private int _size;
        public MyCircularDeque(int k)
        {
            _k = k;
            _size = 0;
        }
        public bool InsertFront(int value)
        {
            if (_size == _k) return false;
            var node = new Node(value);
            if (_front == null)
            {
                _front = node;
            }
            else
            {
                _front.Next = node;
                node.Back = _front;
                _front = _front.Next;
            }
            if (_rear == null)
            {
                _rear = node;
            }
            _size++;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (_size == _k) return false;
            var node = new Node(value);
            if (_front == null)
            {
                _front = node;
            }
            if (_rear == null)
            {
                _rear = node;
            }
            else
            {
                _rear.Back = node;
                node.Next = _rear;
                _rear = _rear.Back;
            }
            _size++;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty()) return false;
            _front = _front.Back;
            if (_front != null)
            {
                _front.Next = null;
            }
            _size--;
            if (IsEmpty())
            {
                _rear = null;
            }
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty()) return false;
            _rear = _rear.Next;
            if (_rear != null)
            {
                _rear.Back = null;
            }
            _size--;
            if (IsEmpty())
            {
                _front = null;
            }
            return true;
        }

        public int GetFront()
        {
            return IsEmpty() ? -1 : _front.Value;
        }

        public int GetRear()
        {
            return IsEmpty() ? -1 : _rear.Value;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public bool IsFull()
        {
            return _size == _k;
        }
        private class Node
        {
            public int Value;
            public Node Next;
            public Node Back;
            public Node(int value)
            {
                Value = value;
            }
        }
    }

    /**
     * Your MyCircularDeque object will be instantiated and called as such:
     * MyCircularDeque obj = new MyCircularDeque(k);
     * bool param_1 = obj.InsertFront(value);
     * bool param_2 = obj.InsertLast(value);
     * bool param_3 = obj.DeleteFront();
     * bool param_4 = obj.DeleteLast();
     * int param_5 = obj.GetFront();
     * int param_6 = obj.GetRear();
     * bool param_7 = obj.IsEmpty();
     * bool param_8 = obj.IsFull();
     */
}