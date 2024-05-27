namespace Application
{
    public partial class IsSameTreeTravel
    {
        public class NNode
        {
            public int val;
            public IList<NNode> children;
            public NNode() { }
            public NNode(int _val)
            {
                val = _val;
            }
            public NNode(int _val, IList<NNode> _children)
            {
                val = _val;
                children = _children;
            }
        }
        public int MaxDepth(NNode root)
        {
            int max = 0;
            TravelNNode(root, 0, ref max);
            return max;
        }
        public void TravelNNode(NNode node, int dept, ref int max)
        {
            dept++;
            if (dept > max) max = dept;
            foreach (var i in node.children)
            {
                TravelNNode(i, dept, ref max);
            }
        }
    }

}