# Algorithms & Data Structures
~ From Introduction to Algorithms, CLRS, 3rd Ed.

## 1. Insertion Sort
![Insertion Sort](./Assets/InsertionSort.png)
```c#
int[] IncreasingSort(int[] Sequence)
{
    for (int j = 1; j < Sequence.Length; j++)
    {
        int key = Sequence[j];
        int i = j - 1;
        while (i >= 0 && Sequence[i] > key)
        {
            Sequence[i + 1] = Sequence[i];
            i--;
        }
        Sequence[i + 1] = key;
    }

    return Sequence;
}
```
Insertion Sort handles sorting in a very easy way, Scanning from left to right, one element at a time. It picks an element, checks it to its left side, if found smaller to the left element it shifts the left elements by one towards right and places picked element on left of them until there is no element on left side greater than it.

## 2. Linear Search
```c#
int? Search(int[] Sequence, int SearchValue)
{
    int? index = null;
    for (int i = 0; i < Sequence.Length; i++)
    {
        if (Sequence[i] == SearchValue)
        {
            index = i;
            break;
        }   
    }

    return index;
}
```
Linear Search is just returning the index of an element if it is found among the array of elements, if not found Null is returned.

## 3. N-Bit Addition
```c#
int[] A = new int[8];
int[] B = new int[8];
int[] C = new int[9];

public int[] Sum()
{
    int carry = 0;
    for (int i = A.Length - 1; i >= 0; i--)
    {
        C[i + 1] = (A[i] + B[i] + carry) % 2;
        if ((A[i] + B[i] + carry) >= 2)
            carry = 1;
        else
            carry = 0;
    }

    C[0] = carry;

    return C;
}
```
Two N-bit arrays are added and results are stored in N+1 bit array where left most digit shows the carry.

## 4. Selection Sort
![Selection Sort](./Assets/SelectionSort.png)
```c#
int[] Sort(int[] Sequence)
{
    for (int i = 0; i < Sequence.Length - 1; i++)
    {
        int min = i;
                
        for (int j = i + 1; j < Sequence.Length; j++)
        {
            if (Sequence[j] < Sequence[min])
            {
                min = j;
            }
        }

        (Sequence[min], Sequence[i]) = (Sequence[i], Sequence[min]);
    }

    return Sequence;
}
```
Selection Sort is like Insertion Sort but in this, an element is picked from the pile starting from left side, and compared against the right sided elements to find any other element smallest than it, if found the element is swapped with it.

Note: Whenever we use swap like in Selection Sort or Bubble Sort, anything involving swapping, point to remember is we don't need to run loop till the last value, since with whom we want to swap the last element, it is already swapped at some point earlier, hence save yourself a loop condition and make sure to run the loop just about the Length - 1.

## 5. Merge Sort
```c#
void Merge(int[] A, int P, int Q, int R)
{
    int n1 = Q - P + 1;
    int n2 = R - Q;

    int[] left = new int[n1];
    int[] right = new int[n2];

    int i, j, k = P;
    for (i = 0; i < n1; i++) left[i] = A[P + i];
    for (j = 0; j < n2; j++) right[j] = A[Q + j + 1];

    i = j = 0;
            
    while (i < n1 && j < n2)
    {
        if (left[i] <= right[j]) 
            A[k++] = left[i++];
                
        else
            A[k++] = right[j++];
    }

    while (i < n1)
    {
        A[k++] = left[i++];
    }
    while (j < n2)
    {
        A[k++] = right[j++];
    }
}

public int[] Sort(int[] A, int P, int R)
{
    if (P < R)
    {
        int Q = (P + R)/2;

        Sort(A, P, Q);
        Sort(A, Q + 1, R);

        Merge(A, P, Q, R);
    }

    return A;
}
```

## 6. Bubble Sort
```c#
int[] Sort(int[] sequence)
{
    for (int i = 0; i < sequence.Length - 1; i++)
    {
        for (int j = sequence.Length - 1; j > i; j--)
        {
            if (sequence[j] < sequence[j - 1])
            {
                (sequence[j], sequence[j - 1]) = (sequence[j - 1], sequence[j]);
            }
        }
    }

    return sequence;
}
```
