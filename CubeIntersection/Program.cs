using CubeIntersection.Implementations.Services;
using System;

namespace CubeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Console App Cube Intersection");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Cube 1 coordinates");
                Console.WriteLine("X,Y,Z,Volume:");
                var xyzv1 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("Cube 2 coordinates");
                Console.WriteLine("X,Y,Z,Volume:");
                var xyzv2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                try
                {
                    var cube1 = new MapStringToCubeService().MapStringToCube(xyzv1);
                    var cube2 = new MapStringToCubeService().MapStringToCube(xyzv2);
                    var cubeIntersection = new CubeIntersectionService().CubeIntersection(cube1, cube2);
                    var cubeIntersectionVolume = new CubeIntersectionVolumeService().CubeIntersectionVolume(cube1, cube2);
                    Console.WriteLine($"The cubes intersect: {cubeIntersection}");
                    Console.WriteLine($"The volume of intersection is: {cubeIntersectionVolume}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Pless any key to input more cubes");
                    Console.ReadLine();
                }
                Console.Clear();
            } while (true);
        }
    }
}
