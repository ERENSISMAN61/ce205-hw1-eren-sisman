#pragma once
#include <cstddef>
#pragma region DATA VARIABLES

/// <summary>
/// Data Value Stored on Stack, Queue and Linked List Implementations
/// </summary>
struct data {
    int key; //decimal key
    char* value; //null ended string
};
typedef struct data Data;

#pragma endregion


#pragma region DATA STRUCTURES

struct mySparseMatrix {
    //TODO: Define sparse matrix variables
    int row;
    int col;
    int data;
    mySparseMatrix* next;
};
typedef struct mySparseMatrix MySparseMatrix;


struct myQueue {
    //TODO: Define variables
    int data;
    myQueue* next;
};
typedef struct myQueue MyQueue;


struct myStack {
    //TODO: Define variables
    int data;
    myStack* link;
};
typedef struct myStack MyStack;

#pragma endregion