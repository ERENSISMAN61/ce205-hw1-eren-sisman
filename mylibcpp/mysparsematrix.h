#pragma once

#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers

#include "mydata.h"

#pragma region SPARSE MATRIX FUNCTIONS

/// <summary>
/// initiate and sparse matrix with given structure use linked lists
/// </summary>
/// <param name="row"></param>
/// <param name="column"></param>
/// <returns></returns>
MySparseMatrix* initSparseMatrix(int row, int column);

/// <summary>
/// Return Data Structure in given row and column
/// </summary>
/// <param name="matrix"></param>
/// <param name="row"></param>
/// <param name="column"></param>
/// <returns></returns>
Data* getSparseMatrix(MySparseMatrix* matrix, int row, int column);

/// <summary>
/// Insert data structure to given row and column position
/// </summary>
/// <param name="matrix"></param>
/// <param name="row"></param>
/// <param name="column"></param>
/// <param name="data"></param>
/// <returns></returns>
int insertSparseMatrix(MySparseMatrix* matrix,int row, int column, Data *data);

/// <summary>
/// Delete item and reset value in given row and column, also delete node and re-organize matrix
/// </summary>
/// <param name="matrix"></param>
/// <param name="row"></param>
/// <param name="column"></param>
/// <returns></returns>
int deleteSparseMatrix(MySparseMatrix* matrix,int row, int column);

/// <summary>
/// Copy matrix values to another sparse matrix
/// </summary>
/// <param name="source"></param>
/// <param name="destination"></param>
/// <returns></returns>
int copySparseMatrix(MySparseMatrix* source, MySparseMatrix* destination);

/// <summary>
/// Destroy Matrix
/// </summary>
/// <param name="matrix"></param>
/// <returns></returns>
int deleteSparseMatrix(MySparseMatrix* matrix);

/// <summary>
/// Print Matrix to Console
/// </summary>
/// <param name="matrix"></param>
/// <returns></returns>
void printMatrixToConsole(MySparseMatrix* matrix);

#pragma endregion