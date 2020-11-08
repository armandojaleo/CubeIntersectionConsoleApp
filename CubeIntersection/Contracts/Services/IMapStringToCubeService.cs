using CubeIntersection.Entities;

namespace CubeIntersection.Contracts.Services
{
    public interface IMapStringToCubeService
    {
        Cube MapStringToCube(string cube);
    }
}
