class Node:
    def __init__(self,d):
        self.data=d
        self.next= None

class LinkedList:
    def __init__(self):
        self.head = None

    def printList(self):
        temp = self.head
        while(temp):
            print(temp.data)
            temp=temp.next
    def reverseList(self):
        next_node = None
        prev_node= None
        current = self.head
        while(current):
            next_node = current.next
            current.next = prev_node
            pre_node = current
            current = current.next
        head = prev_node    
            
            
            
                