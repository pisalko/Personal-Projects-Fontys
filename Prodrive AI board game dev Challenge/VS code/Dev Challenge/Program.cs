using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Dev_Challenge
{

    struct Point
    {
        public int x;
        public int y;
    };

    struct QueueNode
    {
        Point pt;  // The cordinates of a cell
        int dist;  // cell's distance of from the source
    };


    class Program
    {

        // C++ program to find the shortest path between
        // a given source cell to a destination cell.
        int ROW = 11;
        int COL = 11;

        //To store matrix cell cordinates


        // A Data Structure for queue used in BFS


        bool isValid(int row, int col)
        {
            return (row >= 0) && (row < ROW) &&
                (col >= 0) && (col < COL);
        }

        // These arrays are used to get row and column
        // numbers of 4 neighbours of a given cell
        int[] rowNum = { -1, 0, 0, 1 };
        int[] colNum = { 0, -1, 1, 0 };

        // function to find the shortest path between
        // a given source cell to a destination cell.

        // PASTE CODE HERE 

        public int BFS(int[,] array2D, Point src, Point dest)
        {


            // check source and destination cell
            // of the matrix have value 1
            if (!bool.Parse(array2D[src.x, src.y].ToString()) || !bool.Parse(array2D[dest.x, dest.y].ToString()))
                return -1;

            bool[,] visited = new bool[ROW, COL];
            for (int g = 0; g < visited.Length; g++)
            {
                for (int h = 0; h < visited.Length; h++)
                {
                    visited[g, h] = false;
                }
            }
            //memset(visited, false, sizeof visited);

            // Mark the source cell as visited
            visited[src.x, src.y] = true;

            // Create a queue for BFS
            Queue<QueueNode> q;

            // Distance of source cell is 0
            QueueNode s = {src, 0};
            q.push(s);  // Enqueue source cell

            // Do a BFS starting from source cell
            while (!q.empty())
            {
                QueueNode curr = q.front();
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
                        QueueNode Adjcell = { {row, col},
                                      curr.dist + 1 };
                        q.push(Adjcell);
                    }
                }
            }
            // Return -1 if destination cannot be reached
            return -1;
        }
        static void Main(string[] args)
        {
            int randMinimum = 0;
            int randMaximum = 2;
            int nrR = 11;
            int nrC = 11;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int[,] array2D = new int[nrR, nrC];

            // populating 2D Array        
            for (int row = 0; row < nrR; row++)
            {
                for (int column = 0; column < nrC; column++)
                {
                    array2D[row, column] = random.Next(randMinimum, randMaximum);
                    Console.Write(array2D[row, column]);
                }
                Console.WriteLine();
                //Thread.Sleep(1000);

            }

            Console.ReadKey();

        }
    }
}

