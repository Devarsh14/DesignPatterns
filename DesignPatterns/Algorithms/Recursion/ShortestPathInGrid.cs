using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Algorithms.Recursion
{
    // Recursive function to get all shortest routes in a rectangular grid
    // that start at the cell(i,j) and end at the last cell(M-1,N-1).

    class ShortestPathInGrid
    {

    }
}



































































//#include <iostream>
//#include <vector>
//using namespace std;

//#define M 3
//#define N 3

//// Recursive function to get all shortest routes in a rectangular grid
//// that start at the cell(i,j) and end at the last cell(M-1,N-1).
//void printPaths(int mat[][N], vector<int> &route, int i, int j)
//{
//    // if last cell is reached
//    if (i == M - 1 && j == N - 1)
//    {
//        // print the current route
//        for (int i: route)
//        {
//            cout << i << " - ";
//        }

//        cout << mat[i][j] << endl;
//        return;
//    }

//    // include current cell in route
//    route.push_back(mat[i][j]);

//    // move down
//    if (i + 1 < M)
//        printPaths(mat, route, i + 1, j);

//    // move right
//    if (j + 1 < N)
//        printPaths(mat, route, i, j + 1);

//    // move diagonally
//    if (i + 1 < M && j + 1 < N)
//        printPaths(mat, route, i + 1, j + 1);

//    // backtrack
//    route.pop_back();
//}

//// Print all shortest routes in a rectangular grid
//void printPaths(int mat[][N])
//{
//    // vector to store current route
//    vector<int> route;

//    // start from the first cell (0, 0)
//    printPaths(mat, route, 0, 0);
//}

//// main function
//int main()
//{
//    int mat[][N] =
//	{
//		{ 1, 2, 3 },
//		{ 4, 5, 6 },
//		{ 7, 8, 9 }
//	};

//	printPaths(mat);

//	return 0;
//}