// LOngest path code from internet.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <queue>
#include <random>


// C++ program to find the shortest path between 
// a given source cell to a destination cell. 
using namespace std;
#define ROW 11 
#define COL 11

//To store matrix cell cordinates 
struct Point
{
	int x;
	int y;
};

// A Data Structure for queue used in BFS 
struct queueNode
{
	Point pt;  // The cordinates of a cell 
	int dist;  // cell's distance of from the source 
};

bool isValid(int row, int col)
{
	return (row >= 0) && (row < ROW) &&
		(col >= 0) && (col < COL);
}

// These arrays are used to get row and column 
// numbers of 4 neighbours of a given cell 
int rowNum[] = { -1, 0, 0, 1 };
int colNum[] = { 0, -1, 1, 0 };

// function to find the shortest path between 
// a given source cell to a destination cell. 
int BFS(int array2D[][COL], Point src, Point dest)
{
	// check source and destination cell 
	// of the matrix have value 1 
	if (!array2D[src.x][src.y] || !array2D[dest.x][dest.y])
		return -1;

	bool visited[ROW][COL];
	memset(visited, false, sizeof visited);

	// Mark the source cell as visited 
	visited[src.x][src.y] = true;

	// Create a queue for BFS 
	queue<queueNode> q;

	// Distance of source cell is 0 
	queueNode s = { src, 0 };
	q.push(s);  // Enqueue source cell 

	// Do a BFS starting from source cell 
	while (!q.empty())
	{
		queueNode curr = q.front();
		Point pt = curr.pt;

		// If we have reached the destination cell, 
		// we are done 
		if (pt.x == dest.x && pt.y == dest.y)
			return curr.dist;

		// Otherwise dequeue the front cell in the queue 
		// and enqueue its adjacent cells 
		q.pop();

		for (int i = 0; i < 4; i++)
		{
			int row = pt.x + rowNum[i];
			int col = pt.y + colNum[i];

			// if adjacent cell is valid, has path and 
			// not visited yet, enqueue it. 
			if (isValid(row, col) && array2D[row][col] &&
				!visited[row][col])
			{
				// mark cell as visited and enqueue it 
				visited[row][col] = true;
				queueNode Adjcell = { {row, col},
									  curr.dist + 1 };
				q.push(Adjcell);
			}
		}
	}

	// Return -1 if destination cannot be reached 
	return -1;
}

// Driver program to test above function 
int main()
{
	int randMinimum = 0;
	int randMaximum = 2;
	int nrR = 11;
	int nrC = 11;
	//int random = rand();
	std::random_device rd;     // only used once to initialise (seed) engine
	std::mt19937 rng(rd());    // random-number engine used (Mersenne-Twister in this case)
	std::uniform_int_distribution<int> uni(0, 1); // guaranteed unbiased
	int rnmInt = uni(rng);

	int array2D[11][11];

	// populating 2D Array        
	for (int row = 0; row < nrR; row++)
	{
		for (int column = 0; column < nrC; column++)
		{
			array2D[row][column] = rnmInt;
			//array2D[row, column] = new int[];
			//Console.Write(array2D[row, column]);
		}

	Point source = { 0, 0 };
	Point dest = { 3, 4 };

	int dist = BFS(array2D, source, dest);

	if (dist != INT_MAX)
		cout << "Shortest Path is " << dist;
	else
		cout << "Shortest Path doesn't exist";

	return 0;
	
}
