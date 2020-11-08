using CubeIntersection.Entities;
using CubeIntersection.Exceptions;
using CubeIntersection.Implementations.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CubeIntersection.Tests
{
    [TestClass]
    public class MapStringToCubeServiceTests
    {
        private static MapStringToCubeService _mapStringToCubeService;
        private static string _cubeCorrect;
        private static string _cubeIncorrect0;
        private static string _cubeIncorrect1;
        private static string _cubeIncorrect2;
        private static Cube _cube1;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _mapStringToCubeService = new MapStringToCubeService();
            _cubeCorrect = "0,0,0,50";
            _cubeIncorrect0 = null;
            _cubeIncorrect1 = "";
            _cubeIncorrect2 = "abcdefg";
            _cube1 = new Cube()
            {
                X = 0,
                Y = 0,
                Z = 0,
                Volume = 50
            };
        }

        [TestMethod]
        public void MapStringToCubeCorrectString()
        {
            Cube result = _mapStringToCubeService.MapStringToCube(_cubeCorrect);
            Assert.AreEqual(_cube1.X, result.X);
            Assert.AreEqual(_cube1.Y, result.Y);
            Assert.AreEqual(_cube1.Z, result.Z);
            Assert.AreEqual(_cube1.Volume, result.Volume);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void MapStringToCubeIncorrectStringNull()
        {
            _mapStringToCubeService.MapStringToCube(_cubeIncorrect0);
        }

        [ExpectedException(typeof(IncorrectDataFormatException))]
        [TestMethod]
        public void MapStringToCubeIncorrectStringLength0()
        {
            _mapStringToCubeService.MapStringToCube(_cubeIncorrect1);
        }

        [ExpectedException(typeof(IncorrectDataFormatException))]
        [TestMethod]
        public void MapStringToCubeIncorrectStringText()
        {
            _mapStringToCubeService.MapStringToCube(_cubeIncorrect2);
        }
    }
}
