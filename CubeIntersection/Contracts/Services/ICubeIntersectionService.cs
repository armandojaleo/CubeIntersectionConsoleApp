using CubeIntersection.Entities;

namespace CubeIntersection.Contracts.Services
{
    public interface ICubeIntersectionService
    {
        bool CubeIntersection(Cube cube1, Cube cube2);
    }
}
