
using System;
public class Stack{
    int MAX_SIZE=1000;
    int[] stack=new int[MAX_SIZE];
    int top;
    
    bool IsEmpty(){
        if(top==-1)
        return true;
        else 
        return false;
    }
    bool push(int data){
        if(top> MAX_SIZE-1){
            COnsole.Writeline("Stack overflow cannot be pushed");
            return false;
        }
        else{
            stack[++top]=data;
            return true;
        }
    }
    int pop(){
        if(top==-1){
            Console.Writeline("Stack is empty cannot be popped");
            return -1;
        }
        else{
            return (stack[top--]);
        }
    }
    int peek(){
        if(top==-1){
            return -1;
        }
        else{
            return stack[top];
        }
    }
    void printStack(){
        for(int i=top;i =>0; i--){
            Console.Write(stack[i]+" ");
        }
    }
}