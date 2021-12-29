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