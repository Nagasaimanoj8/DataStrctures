namespace Datastructure
{
    public class Node
    {
        public int data;//to store integer vaslue
        public Node next; //holding the address of the next node
        //for initializing crerating a constructor
        public Node(int data)
        {
            this.data = data;
            this.next=null;

        }
    }
}