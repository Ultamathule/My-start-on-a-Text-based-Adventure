using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WierdGameTry
{

    public class MapHandler
    {
       // mapHandler = new MapHandler();
      /*  public MapHandler mapHandler;
        Random rand = new Random();

                public int[,] Map;

                public int MapWidth { get; set; }
                public int MapHeight { get; set; }
                public int PercentAreWalls { get; set; }

                public MapHandler()
                {
                    MapWidth = 40;
                    MapHeight = 21;
                    PercentAreWalls = 40;

                    RandomFillMap();
                }

                public void MakeCaverns()
                {
                    // by initilizing column in the outer loop, its only created once
                    for (int column = 0, row = 0; row <= MapHeight - 1; row++)
                    {
                        for (column = 0; column <= MapWidth - 1; column++)
                        {
                            Map[column, row] = PlaceWallLogic(column, row);
                        }
                    }
                }
                public int PlaceWallLogic(int x, int y)
                {
                    int numWalls = GetAdjacentWalls(x, y, 1, 1);

                    if (Map[x, y] == 1)
                    {
                        if (numWalls >= 4)
                        {
                            return 1;
                        }
                        if (numWalls < 2)
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        if (numWalls >= 5)
                        {
                            return 1;
                        }

                    }
                    return 0;
                }
                public int GetAdjacentWalls(int x, int y, int scopeX, int scopeY)
                {
                    int startX = x - scopeX;
                    int startY = y - scopeY;
                    int endX = x + scopeX;
                    int endY = y + scopeY;

                    int iX = startX;
                    int iY = startY;

                    int wallCounter = 0;

                    for (iY = startY; iY <= endY; iY++)
                    {
                        for (iX = startX; iX <= endX; iX++)
                        {
                            if (!(iX == x && iY == y))
                            {
                                if (IsWall(iX, iY))
                                {
                                    wallCounter += 1;

                                }
                            }
                        }
                    }
                    return wallCounter;
                }
                bool IsWall(int x, int y)
                {   // Consider out-of-bound a wall
                    if (IsOutOfBounds(x, y))
                    {
                        return true;
                    }
                    if (Map[x, y] == 1)
                    {
                        return true;
                    }
                    if (Map[x, y] == 0)
                    {
                        return false;
                    }
                    return false;
                }


                bool IsOutOfBounds(int x, int y)
                {
                    if (x < 0 || y < 0)
                    {
                        return true;
                    }
                    else if (x > MapWidth - 1 || y > MapHeight - 1)
                    {
                        return true;
                    }
                    return false;
                }

                public void PrintMap()
                {
                    Console.Clear();
                    Console.Write(MapToString());
                }

                string MapToString()
                {
                    string returnString = string.Join(" ", // Seperator between each element
                                                        "Width:",
                                                        MapWidth.ToString(),
                                                        "\tHeight:",
                                                        MapHeight.ToString(),
                                                        "\t% Walls:",
                                                        PercentAreWalls.ToString(),
                                                        Environment.NewLine);

                    List<string> mapSymbols = new List<string>();
                    mapSymbols.Add(".");
                    mapSymbols.Add("#");
                    mapSymbols.Add("+");

                    for (int column = 0, row = 0; row < MapHeight; row++)
                    {
                        for (column = 0; column < MapWidth; column++)
                        {
                            returnString += mapSymbols[Map[column, row]];
                        }
                        returnString += Environment.NewLine;
                    }
                    return returnString;

                }

                public void BlankMap()
                {
                    for (int column = 0, row = 0; row < MapHeight; row++)
                    {
                        for (column = 0; column < MapWidth; column++)
                        {
                            Map[column, row] = 0;
                        }
                    }
                }
                public void RandomFillMap()
                {
                    // New, empty map
                    Map = new int[MapWidth, MapHeight];

                    int mapMiddle = 0; // Temp Variable
                    for (int column = 0, row = 0; row < MapHeight; row++)
                    {
                        for (column = 0; column < MapWidth; column++)
                        {
                            // if coordinants lie on the edge of the map ( creates[cut off page???])
                            if (column == 0)
                            {
                                Map[column, row] = 1;
                            }
                            else if (row == 0)
                            {
                                Map[column, row] = 1;
                            }
                            else if (column == MapWidth - 1)
                            {
                                Map[column, row] = 1;
                            }
                            else if (row == MapHeight - 1)
                            {
                                Map[column, row] = 1;
                            }
                            // else, fill with a wall a random percent of the time
                            else
                            {
                                mapMiddle = (MapHeight / 2);

                                if (row == mapMiddle)
                                {
                                    Map[column, row] = 0;
                                }
                                else
                                {
                                    Map[column, row] = RandomPercent(PercentAreWalls);
                                }
                            }

                        }
                    }
                }
                int RandomPercent(int percent)
                {
                    if (percent >= rand.Next(1, 101))
                    {
                        return 1;
                    }
                    return 0;
                }
                public MapHandler(int mapWidth, int mapHeight, int[,] map, int percentWalls = 40)
                {
                    this.MapWidth = mapWidth;
                    this.MapHeight = mapHeight;
                    this.PercentAreWalls = percentWalls;
                    this.Map = new int[this.MapWidth, this.MapHeight];
                    this.Map = map;
                }
            
        
    }*/
}
        
