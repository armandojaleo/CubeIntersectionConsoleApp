using CubeIntersection.Entities;

namespace CubeIntersection.Contracts.Services
{
    public interface ICubeIntersecionVolumeService
    {
        double CubeIntersectionVolume(Cube cube1, Cube cube2);
    }
}
