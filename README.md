# 401-DSA
## data structures and algorithms challenges for code 401
- **Challenge 1: Reverse an array**
  - ![whiteboard](01wb.jpg)
- **Challenge 2: Insert number into middle of array**
  - ![whiteboard](InsertShiftArray.png)
- **Challenge 3: Binary Search**
  - ![whiteboard](BinarySearch.png)
  - **Challenge 5: Linked Lists**
    *Approach*: Beyond simple arrays and variables, there are many different data structures to use as ways to store data. 
      The data structure for this challenge is the Linked List. It is chain of nodes with values that each contain a reference to the next 
      node/link in the chain. 

      *Challenge*: The goal day was to creating a linked list class, allowing for the creation of linked list objects. The class includes 
      methods to insert new nodes, search existing nodes for a given value, and to convert the list to a string. With Test Driven Development 
      in mind we also had to create corresponding xunit test to ensure the program is running smoothly;

      *Methods*
       - LinkedLists(): creates a new empty linked list object.
       - Insert(): adds a new node with an inputted value to the beginning of the list.
       - Includes(): searches the list for an inputted value and returns true if found and false if not.
       - ToString(): provides a string interperation of the entire linked list