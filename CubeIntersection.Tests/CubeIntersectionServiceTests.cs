using CubeIntersection.Entities;
using CubeIntersection.Implementations.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeIntersection.Tests
{
    [TestClass]
    public class CubeIntersectionServiceTests
    {
        private static CubeIntersectionService _cubeIntersectionService;
        private static Cube _cube1;
        private static Cube _cube2;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _cubeIntersectionService = new CubeIntersectionService();
            _cube1 = new Cube()
            {
                X = 0,
                Y = 0,
                Z = 0,
                Volume = 50
            };
            _cube2 = new Cube()
            {
                X = 10,
                Y = 5,
                Z = 7,
                Volume = 150
            };
        }

        [TestMethod]
        public void CubeIntersectionIsTrue()
        {
            var result = _cubeIntersectionService.CubeIntersection(_cube1, _cube2);
            Assert.IsTrue(result);
        }
    }
}
