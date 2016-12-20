using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableExercise
{
    public class TreeEnumerator : IEnumerator<TreeNode>
    {
        private readonly List<TreeNode> TreeNodes;
        private int CurrentIndex;

        public TreeNode Current => GetCurrent();

        object IEnumerator.Current => GetCurrent();

        public TreeEnumerator(TreeNode treeNode)
        {
            TreeNodes = treeNode.Preorder();
            Reset();
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return CurrentIndex < TreeNodes.Count;
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }

        private TreeNode GetCurrent()
        {
            if (CurrentIndex < 0)
            {
                throw new InvalidOperationException();
            }
            if (CurrentIndex >= TreeNodes.Count)
            {
                throw new InvalidOperationException();
            }

            return TreeNodes[CurrentIndex];
        }

        public void Dispose()
        {
        }
    }
}