using System;

public class BinaryTreeArray
{
    private object[] arr;

    public BinaryTreeArray(int capacity = 15)
    {
        arr = new object[capacity];
    }
    public object Root
    {
        get { return arr[0]; }
        set { arr[0] = value; }
    }

    public void SetLeft(int parentIndex, object data)
    {
        int leftIndex = parentIndex * 2 + 1;

        if (arr[parentIndex] == null || arr.Length <= leftIndex)
            throw new ApplicationException("Error");

        arr[leftIndex] = data;
    }

    public void SetRight(int parentIndex, object data)
    {
        int rightIndex = parentIndex * 2 + 2;

        if (arr[parentIndex] == null || arr.Length <= rightIndex)
            throw new ApplicationException("Error");

        arr[rightIndex] = data;
    }

    public object GetParent(int childIndex)
    {
        if (childIndex == 0)
            throw new ApplicationException("Error");

        if (arr[childIndex] == null || arr[0] == null)
            throw new ApplicationException("Error");

        int parentIndex = (childIndex - 1) / 2;
        return arr[parentIndex];
    }

    public object GetLeft(int parentIndex)
    {
        if (arr[parentIndex] == null)
            throw new ApplicationException("Error");

        int leftIndex = parentIndex * 2 + 1;
        return arr[leftIndex];
    }

    public object GetRight(int parentIndex)
    {
        if (arr[parentIndex] == null)
            throw new ApplicationException("Error");

        int rightIndex = parentIndex * 2 + 2;
        return arr[rightIndex];
    }

    public void PrintTree()
    {
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write("{0}", arr[i] ?? "-");
        }
        Console.WriteLine();
    }
}

/*
배열을 이용한 이진트리의 구현은 링크드 리스트에 비해 다소 복잡하지만 Heap과 같은
응용 분야에서는 배열을 이용하여 구현하는 것이 더 편리하다.

배열에 이진 트리를 저장하는 방식은 기본적으로 트리 레벨 순으로 왼쪽에서 오른쪽으로 저장하면 된다.
이진 트리의 노드들을 체계적으로 배열에 저장하기 때문에, 임의의 노드 즉 임의의 배열 요소
인덱스 i 에서 좌/우 자식 노드의 위치는
"왼쪽 노드" = 2 * i + 1
"오른쪽 노드" = 2 * i + 2 
"부모 노드" = (i - 1) / 2 
 */
