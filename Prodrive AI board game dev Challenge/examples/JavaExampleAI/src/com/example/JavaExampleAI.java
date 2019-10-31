package com.example;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Random;

public class JavaExampleAI {

    public static void main(String[] args) throws IOException {
        int gridSize = 11;
        Random rng = new Random();

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int player = Integer.parseInt(br.readLine());

        int[][] grid = new int[gridSize][gridSize];


        for (int moveCount = 0; moveCount < (gridSize * gridSize); ++moveCount) {
            if ((moveCount % 2) == player) {
                while (true) {
                    int x = rng.nextInt(gridSize);
                    int y = rng.nextInt(gridSize);

                    if (grid[y][x] != 0)
                        continue;

                    grid[y][x] = 1;
                    System.out.println(x + " " + y);
                    break;
                }
            } else {
                int[] c = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
                grid[c[1]][c[0]] = 2;
            }
        }
    }
}
