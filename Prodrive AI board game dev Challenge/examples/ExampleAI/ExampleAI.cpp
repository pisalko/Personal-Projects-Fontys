// ExampleAI.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <random>

int main()
{
  const int gridSize = 11;
  std::random_device rd;  //Will be used to obtain a seed for the random number engine
  std::mt19937 gen(rd()); //Standard mersenne_twister_engine seeded with rd()
  std::uniform_int_distribution<> dis(0, gridSize - 1);

  int player;
  std::cin >> player;

  int grid[gridSize][gridSize] = {};

  for (int moveCount = 0; moveCount < (gridSize * gridSize); ++moveCount)
  {
    if ((moveCount % 2) == player)
    {
      while (true)
      {
        int x = dis(gen);
        int y = dis(gen);
        
        if (grid[y][x] != 0)
          continue;

        grid[y][x] = 1;
        std::cout << x << " " << y << std::endl;

        break;
      }
    }
    else 
    {
      int x;
      int y;
      std::cin >> x >> y;
      grid[y][x] = 2;
    }
  }
}