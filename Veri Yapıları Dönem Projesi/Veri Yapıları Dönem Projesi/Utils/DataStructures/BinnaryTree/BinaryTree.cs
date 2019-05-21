using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Dönem_Projesi
{
    public class BinaryTree
    {
        public BinaryTreeNode root;
        public BindingList<Hotel> nodes;
        public BinaryTree(BinaryTreeNode _root)
        {
            nodes = new BindingList<Hotel>();
            this.root = _root;
        }
       
        public int NodeCount()
        {
            return NodeCount(root);
        }
        public int NodeCount(BinaryTreeNode node)
        {
            int count = 0;
            if (node != null)
            {
                count = 1;
                count += NodeCount(node.left);
                count += NodeCount(node.right);
            }
            return count;
        }
        public int LeafCount()
        {
            return LeafCount(root);
        }
        public int LeafCount(BinaryTreeNode node)
        {
            int count = 0;
            if (node != null)
            {
                if ((node.left == null) && (node.right == null))
                    count = 1;
                else
                    count = count + LeafCount(node.left) + LeafCount(node.right); 
            }
            return count;
        }
        public BindingList<Hotel> PrintTree()
        {
            foreach (var item in nodes)
            {
                Console.WriteLine(item.Name + '\n');

            }
            Console.WriteLine("-------------------------------\n");
            return nodes;
        }
        //Gezinme İşlemleri
        public void PreOrder()
        {
            nodes = new BindingList<Hotel>();
            PreOrderInt(root);
        }
        private void PreOrderInt(BinaryTreeNode node)
        {
            if (node == null)
                return;
            Visit(node);
            PreOrderInt(node.left);
            PreOrderInt(node.right);
        }
        public void InOrder()
        {
            nodes = new BindingList<Hotel>();
            InOrderInt(root);
        }
        private void InOrderInt(BinaryTreeNode node)
        {
            if (node == null)
                return;
            InOrderInt(node.left);
            Visit(node);
            InOrderInt(node.right);
        }
        private void Visit(BinaryTreeNode node)
        {
            nodes.Add(node.data);
        }
        public void PostOrder()
        {
            nodes = new BindingList<Hotel>();
            PostOrderInt(root);
        }
        private void PostOrderInt(BinaryTreeNode node)
        {
            if (node == null)
                return;
            PostOrderInt(node.left);
            PostOrderInt(node.right);
            Visit(node);
        }
        public void Add(Hotel hotel)
        {
            BinaryTreeNode tempParent = new BinaryTreeNode(null);
           
            BinaryTreeNode tempSearch = root;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
               
                if (hotel.Id == tempSearch.data.Id)
                    return;
                else if (hotel.Id < tempSearch.data.Id)
                    tempSearch = tempSearch.left;
                else
                    tempSearch = tempSearch.right;
            }
            BinaryTreeNode toAdded = new BinaryTreeNode(hotel);
          
            if (root == null)
                root = toAdded;
            else if (hotel.Id < tempParent.data.Id)
                tempParent.left = toAdded;
            else
                tempParent.right = toAdded;
        }
        public BinaryTreeNode Search(int key)
        {
            return SearchInt(root, key);
        }
        private BinaryTreeNode SearchInt(BinaryTreeNode node,int key)
        {
            if (node == null)
                return null;
            else if (node.data.Id == key)
                return node;
            else if (node.data.Id > key)
                return (SearchInt(node.left, key));
            else
                return (SearchInt(node.right, key));
        }

        public BinaryTreeNode MinValue()
        {
            BinaryTreeNode tempLeft = root;
            while (tempLeft.left!= null)
                tempLeft = tempLeft.left;
            return tempLeft;
        }

        public BinaryTreeNode MaksValue()
        {
            BinaryTreeNode tempRight = root;
            while (tempRight.right != null)
                tempRight = tempRight.right;
            return tempRight;
        }

        private BinaryTreeNode Successor(BinaryTreeNode delNode)
        {
            BinaryTreeNode successorParent = delNode;
            BinaryTreeNode successor = delNode;
            BinaryTreeNode current = delNode.right;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.left;
            }
            if (successor != delNode.right)
            {
                successorParent.left = successor.right;
                successor.right = delNode.right;
            }
            return successor;
        }
        public bool Remove(int deger)
        {
            BinaryTreeNode current = root;
            BinaryTreeNode parent = root;
            bool issol = true;
            
            while (current.data.Id != deger)
            {
                parent = current;
                if (deger < current.data.Id)
                {
                    issol = true;
                    current = current.left;
                }
                else
                {
                    issol = false;
                    current = current.right;
                }
                if (current == null)
                    return false;
            }
            
            if (current.left == null && current.right == null)
            {
                if (current == root)
                    root = null;
                else if (issol)
                    parent.left = null;
                else
                    parent.right = null;
            }
            else if (current.right == null)
            {
                if (current == root)
                    root = current.left;
                else if (issol)
                    parent.left = current.left;
                else
                    parent.right = current.right;
            }
            else if (current.left == null)
            {
                if (current == root)
                    root = current.right;
                else if (issol)
                    parent.left = current.right;
                else
                    parent.right = current.right;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                BinaryTreeNode successor = Successor(current);
                if (current == root)
                    root = successor;
                else if (issol)
                    parent.left = successor;
                else
                    parent.right = successor;
                successor.left = current.left;
            }
            return true;
        }

    }

}
