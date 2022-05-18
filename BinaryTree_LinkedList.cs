using System;

public class BinaryTreeLinkedListNode<T>
{
    public T Data;
    public BinaryTreeLinkedListNode<T> leftNode;
    public BinaryTreeLinkedListNode<T> rightNode;

    public BinaryTreeLinkedListNode(T data)
    {
        this.Data = data;
    }
}

public class BinaryTree<T>
{
    public BinaryTreeLinkedListNode<T> Root { get; private set; }

    public BinaryTree(T root)
    {
        this.Root = new BinaryTreeLinkedListNode<T>(root);
    }
    //트리 데이타 출력
    public void PreorderTraversal()
    {
        PreorderTraversal(Root);
    }
    private void PreorderTraversal(BinaryTreeLinkedListNode<T> node)
    {
        if (node == null) return;

        Console.Write(" {0} ", node.Data);
        PreorderTraversal(node.leftNode);
        PreorderTraversal(node.rightNode);
    }
}