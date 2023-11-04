# Algorithms & Data Structures
~ From Introduction to Algorithms, CLRS, 3rd Ed.

## 1. Insertion Sort
![Insertion Sort](./Assets/InsertionSort.png)
Insertion Sort handles sorting in a very easy way, Scanning from left to right, one element at a time. It picks an element, checks it to its left side, if found smaller to the left element it shifts the left elements by one towards right and places picked element on left of them until there is no element on left side greater than it.

## 2. Linear Search
Linear Search is just returning the index of an element if it is found among the array of elements, if not found Null is returned.

## 3. N-Bit Addition
Two N-bit arrays are added and results are stored in N+1 bit array where left most digit shows the carry.

## 4. Selection Sort
![Selection Sort](./Assets/SelectionSort.png)
Selection Sort is like Insertion Sort but in this, an element is picked from the pile starting from left side, and compared against the right sided elements to find any other element smallest than it, if found the element is swapped with it.

Note: Whenever we use swap like in Selection Sort or Bubble Sort, anything involving swapping, point to remember is we don't need to run loop till the last value, since with whom we want to swap the last element, it is already swapped at some point earlier, hence save yourself a loop condition and make sure to run the loop just about the Length - 1.

## 5. Merge Sort

## 6. Bubble Sort
