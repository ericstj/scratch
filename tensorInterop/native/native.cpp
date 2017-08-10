// native.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

typedef double* (__stdcall *AllocateDoubleArray)(int);

extern "C"  __declspec(dllexport) double* __stdcall GetMultTable(AllocateDoubleArray allocator, int number)
{
	int size = number * number;
	double* result = allocator(size);

	for (int i = 0; i < number; i++)
	{
		int rowOffset = i * number;
		for (int j = 0; j < number; j++)
		{
			result[rowOffset + j] = (i + 1.0) * (j + 1.0);
		}
	}

	return result;
}


extern "C"  __declspec(dllexport) double __stdcall GetRowSum(double* data, int* dimensions, int rank, int row)
{
	int rowStride = 0;
	for (int i = 1; i < rank; i++)
	{
		rowStride += dimensions[i];
	}

	double* rowStart = data + row * rowStride;
	double sum = 0;
	for (int i = 0; i < rowStride; i++)
	{
		sum += rowStart[i];
	}

	return sum;
}
