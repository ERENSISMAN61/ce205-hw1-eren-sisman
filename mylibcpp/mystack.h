#pragma once

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers

#include "mydata.h"

#pragma region STACK FUNCTIONS

/// <summary>
/// Use Single Linked List and Push Data In a Stack
/// </summary>
/// <param name="myStack">stack object data structure</param>
/// <param name="data">Data structure to store on Stack</param>
/// <returns>0 if operation success othercase return -1</returns>
int push(MyStack* myStack, Data* data);

/// <summary>
/// Use Singled Linked List and Pop Data from Stack, Remove Item from Stack
/// </summary>
/// <param name="myStack">stack object data structure</param>
/// <returns>Data structure pointer, if there is no item return NULL</returns>
Data* pop(MyStack* myStack);

/// <summary>
/// Use Singled Linked List and Show Item at The Top of Stack, Doesn't Remove Item
/// </summary>
/// <param name="myStack">stack object data structure</param>
/// <returns>Data structure pointer, if there is no item return NULL</returns>
Data* top(MyStack* myStack);

/// <summary>
/// Use Singled Linked List and Show Item at The Bottom of Stack, Doesn't Remove Item
/// </summary>
/// <param name="myStack">stack object data structure</param>
/// <returns>Data structure pointer, if there is no item return NULL</returns>
Data* bottom(MyStack* myStack);

/// <summary>
/// Count items in stack and return as integer
/// </summary>
/// <param name="myStack">stack object data structure</param>
/// <returns>Returns the length of stack</returns>
int stackLength(MyStack* myStack);

#pragma endregion