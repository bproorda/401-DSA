# Stack Data Structure

- The stack is a data structure that follows the principles of Last In First Out(LIFO)
and First In Last Out(FILO). The best metaphor is a literal stack such as stack of books.
You can easily grab the one of on top, but not ones beneath it. Just so, this data structure
only allows access to the Top node. The most common example in programming is the call stack
Like a linked list, each node has a reference to the next one.

- **Methods**:
    - Push(): Creates a new node and places it onto the top of stack, this becomes the 
    new Top.
    - Pop(): This method removes the Top node of the stack and returns its value. The
    next node down then becomes the new Top. Pop() will throw an exception if the stack
    is empty.
    - Peek(): This method allows the user to see the value of Top node. It will throw
    and exception if the stack is empty.
    - isEmpty(): The purpose of this method is determine whether or not the stack is empty
    and returns a boolean signifying the result.