namespace Application
{
    public partial class GraphSolution
    {
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var dic = new Dictionary<int, TreeNode>();
            var dicRoot = new Dictionary<int, bool>();
            foreach (var i in descriptions)
            {
                AddParentNode(dic, dicRoot, i);
            }
            var root = dicRoot.Where(x => x.Value == true).Select(x => x.Key).SingleOrDefault();
            return dic[root];
        }
        void AddParentNode(Dictionary<int, TreeNode> dic, Dictionary<int, bool> dicRoot, int[] nodeDesc)
        {
            if (!dic.ContainsKey(nodeDesc[0]))
            {
                var newNode = new TreeNode(nodeDesc[0]);
                if (nodeDesc[2] == 1)
                {
                    if (!dic.ContainsKey(nodeDesc[1]))
                    {
                        var childNode = new TreeNode(nodeDesc[1]);
                        newNode.left = childNode;
                        dicRoot.Add(nodeDesc[1], false);
                        dic.Add(nodeDesc[1], childNode);
                    }
                    else
                    {
                        newNode.left = dic[nodeDesc[1]];
                        dicRoot[nodeDesc[1]] = false;
                    }
                }
                else
                {
                    if (!dic.ContainsKey(nodeDesc[1]))
                    {
                        var childNode = new TreeNode(nodeDesc[1]);
                        newNode.right = childNode;
                        dicRoot.Add(nodeDesc[1], false);
                        dic.Add(nodeDesc[1], childNode);
                    }
                    else
                    {
                        newNode.right = dic[nodeDesc[1]];
                        dicRoot[nodeDesc[1]] = false;
                    }
                }
                dic.Add(nodeDesc[0], newNode);
                dicRoot.Add(nodeDesc[0], true);
                return;
            }
            var existingNode = dic[nodeDesc[0]];
            if (nodeDesc[2] == 1)
            {
                if (!dic.ContainsKey(nodeDesc[1]))
                {
                    var childNode = new TreeNode(nodeDesc[1]);
                    existingNode.left = childNode;
                    dicRoot.Add(nodeDesc[1], false);
                    dic.Add(nodeDesc[1], childNode);
                }
                else
                {
                    existingNode.left = dic[nodeDesc[1]];
                    dicRoot[nodeDesc[1]] = false;
                }
            }
            else
            {
                if (!dic.ContainsKey(nodeDesc[1]))
                {
                    var childNode = new TreeNode(nodeDesc[1]);
                    existingNode.right = childNode;
                    dicRoot.Add(nodeDesc[1], false);
                    dic.Add(nodeDesc[1], childNode);
                }
                else
                {
                    existingNode.right = dic[nodeDesc[1]];
                    dicRoot[nodeDesc[1]] = false;
                }
            }
        }
        void AddRightChild(TreeNode existingNode, int[] nodeDesc, Dictionary<int, TreeNode> dic, Dictionary<int, bool> dicRoot)
        {
            if (nodeDesc[2] == 1)
            {
                if (!dic.ContainsKey(nodeDesc[1]))
                {
                    var childNode = new TreeNode(nodeDesc[1]);
                    existingNode.left = childNode;
                    dicRoot.Add(nodeDesc[1], false);
                    dic.Add(nodeDesc[1], childNode);
                }
                else
                {
                    existingNode.left = dic[nodeDesc[1]];
                    dicRoot[nodeDesc[1]] = false;
                }
            }
            else
            {
                if (!dic.ContainsKey(nodeDesc[1]))
                {
                    var childNode = new TreeNode(nodeDesc[1]);
                    existingNode.right = childNode;
                    dicRoot.Add(nodeDesc[1], false);
                    dic.Add(nodeDesc[1], childNode);
                }
                else
                {
                    existingNode.right = dic[nodeDesc[1]];
                    dicRoot[nodeDesc[1]] = false;
                }
            }
        }
        void AddLeftChild(TreeNode newNode, int[] nodeDesc, Dictionary<int, TreeNode> dic, Dictionary<int, bool> dicRoot)
        {
            if (nodeDesc[2] == 1)
            {
                if (!dic.ContainsKey(nodeDesc[1]))
                {
                    var childNode = new TreeNode(nodeDesc[1]);
                    newNode.left = childNode;
                    dicRoot.Add(nodeDesc[1], false);
                    dic.Add(nodeDesc[1], childNode);
                }
                else
                {
                    newNode.left = dic[nodeDesc[1]];
                    dicRoot[nodeDesc[1]] = false;
                }
            }
            else
            {
                if (!dic.ContainsKey(nodeDesc[1]))
                {
                    var childNode = new TreeNode(nodeDesc[1]);
                    newNode.right = childNode;
                    dicRoot.Add(nodeDesc[1], false);
                    dic.Add(nodeDesc[1], childNode);
                }
                else
                {
                    newNode.right = dic[nodeDesc[1]];
                    dicRoot[nodeDesc[1]] = false;
                }
            }
        }
    }
}