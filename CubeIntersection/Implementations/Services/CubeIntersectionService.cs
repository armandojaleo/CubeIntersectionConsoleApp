using CubeIntersection.Contracts.Services;
using CubeIntersection.Entities;
using System;

namespace CubeIntersection.Implementations.Services
{
    public class CubeIntersectionService : ICubeIntersectionService
    {
        public bool CubeIntersection(Cube cube1, Cube cube2)
        {
            var sideCube1 = Math.Pow(cube1.Volume, 1 / 3);
            var xs1a = sideCube1 / 2 - cube1.X;
            var xs1b = cube1.X + sideCube1 / 2;
            var ys1a = sideCube1 / 2 - cube1.Y;
            var ys1b = cube1.Y + sideCube1 / 2;
            var zs1a = sideCube1 / 2 - cube1.Z;
            var zs1b = cube1.Z + sideCube1 / 2;

            var sideCube2 = Math.Pow(cube2.Volume, 1 / 3);
            var xs2a = sideCube2 / 2 - cube2.X;
            var xs2b = cube2.X + sideCube2 / 2;
            var ys2a = sideCube2 / 2 - cube2.Y;
            var ys2b = cube2.Y + sideCube2 / 2;
            var zs2a = sideCube2 / 2 - cube2.Z;
            var zs2b = cube2.Z + sideCube2 / 2;

            //Todo calculate intersection

            return true;
        }
    }
}
