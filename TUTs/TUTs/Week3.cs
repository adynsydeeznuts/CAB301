class Stack
{
    static int CAPACITY = 10;
    private int capacity;
    private int numElements;
    private int[] data;


    /// constructor initializes stack
    public Stack() {
        capacity = CAPACITY;
        numElements = 0;
        data = new int[CAPACITY];
    }

    /// returns number of elements in the stack
    public int size() {
        return numElements;
    }

    /// return true if the stack is empty
    public bool empty() {
        return numElements == 0;
    }

    /// adds an element to the top of the stack
    public void push(int value) {
        if (numElements != capacity) {
            data[numElements] = value;
            numElements=numElements+1;
        }
        else {
            Console.WriteLine("Stack is full - cannot add any more elements to stack");
        }
    }

    /// returns the element from the top of the stack and removes it
    public int pop() {
        int topValue = data[numElements - 1];
        numElements=numElements-1;
        return topValue;
    }

    /// returns the element from the top of the stack
    public int peek() {
        return data[numElements - 1];
    }

}

// Invariants: 0 <= Count <= Capacity
public interface IQueue {
/* Pre: true
* Post: return the capacity of the queue
*/
int Capacity {get;}
/* Pre: true
* Post: return the number of objects stored the queue
*/
int Count {get;}
/* Pre: true
* Post: return true if the queue is empty;
* otherwise, return false.
*/
bool IsEmpty();
/* Pre: true
* Post: return true if the queue is full;
* otherwise, return false.
*/
bool IsFull();
/* Pre: the queue is not full
* Post: Object item is added to the head of the queue
*/
void Enqueue(Object item);
/* Pre: the queue is not empty
* Post: the rear item is removed from the queue
*/
Object Dequeue();
/* Pre: the queue is not empty
* Post: return the head item of the queue
*/
Object Head();
/* Pre: true
* Post: the queue becomes empty
*/
void Clear();
}
