#pragma once

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers

#include "mydata.h"

#pragma region QUEUE FUNCTIONS

/// <summary>
/// Use Single List and Store Data in Queue
/// </summary>
/// <param name="myQueue">queue object data structure</param>
/// <param name="data">data structure to insert</param>
/// <returns>0 if operation success othercase return -1</returns>
int enqueue(MyQueue* myQueue,Data* data);

/// <summary>
/// Use Single Linked List and Get Data from Queue
/// </summary>
/// <param name="myQueue">queue object data structure</param>
/// <returns>Data structure pointer, if there is no item return NULL</returns>
Data* dequeue(MyQueue* myQueue);


/// <summary>
/// Use Single Linked List and Get Data from Infront of The Queue
/// </summary>
/// <param name="myQueue">queue object data structure</param>
/// <returns>Data structure pointer, if there is no item return NULL</returns>
Data* front(MyQueue* myQueue);


/// <summary>
/// Use Single Linked List and Get Data from Back of The Queue
/// </summary>
/// <param name="myQueue">queue object data structure</param>
/// <returns>Data structure pointer, if there is no item return NULL</returns>
Data* back(MyQueue* myQueue);

/// <summary>
/// Count items in stack and return as integer
/// </summary>
/// <param name="myQueue">queue object data structure</param>
/// <returns>Returns the length of queue</returns>
int queueLength(MyQueue* myQueue);

#pragma endregion