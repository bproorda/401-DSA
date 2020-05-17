# Queue

- Queue is a data structure that is much for what is named, think of people standing 
in a line. Queues use First In First Out(FIFO)/Last In Last Out (LILO). The first person
in the line is also the first one to get through the line. Each node in the queue has a
Next reference to the next node. The Queue it self tracks the node at the Front and
at the Rear.

- **Methods**
    - enQueue(): adds a new node with the inputted value to the Rear of the Queue
    - deQueue(): removes a node from the Front of the Queue and returns its value. This
    method will throw an error if the queue is empty.
    - peek(): returns the value of the Front node. This method will throw an error
    if the queue is empty
    -isEmpty(): checks to see if the Queue is empty, returns true if it is.