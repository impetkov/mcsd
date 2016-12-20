using System.Collections;
using System.Collections.Generic;

namespace IEnumerableExercise
{
    public class TreeNode : IEnumerable<TreeNode>
    {
        public int Depth;
        public readonly string Text;
        private readonly List<TreeNode> Children = new List<TreeNode>();

        public TreeNode(string text)
        {
            Text = text;
        }

        public TreeNode AddChild(string text)
        {
            var child = new TreeNode(text)
            {
                Depth = Depth + 1
            };

            Children.Add(child);

            return child;
        }

        public List<TreeNode> Preorder()
        {
            var nodes = new List<TreeNode>();

            TraversePreorder(nodes);

            return nodes;
        }

        private void TraversePreorder(List<TreeNode> nodes)
        {
            nodes.Add(this);

            foreach (var child in Children)
            {
                child.TraversePreorder(nodes);
            }
        }

        public IEnumerable<TreeNode> GetTraversal()
        {
            var traversal = Preorder();

            foreach (var node in traversal)
            {
                yield return node;
            }
        }

        public IEnumerator<TreeNode> GetEnumerator()
        {
            return new TreeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new TreeEnumerator(this);
        }
    }
}
