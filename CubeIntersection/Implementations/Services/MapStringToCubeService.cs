using CubeIntersection.Contracts.Services;
using CubeIntersection.Entities;
using CubeIntersection.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace CubeIntersection.Implementations.Services
{
    public class MapStringToCubeService : IMapStringToCubeService
    {
        public Cube MapStringToCube(string cube)
        {
            if (cube == null)
            {
                throw new ArgumentNullException(nameof(cube));
            };
            if (cube.Length == 0)
            {
                throw new IncorrectDataFormatException("Please input the correct format 'X,Y,Z,Volume'. Decimal point number are accepted");
            };
            Regex rgx = new Regex(@"^([\d\.])+,([\d\.])+,([\d\.])+,([\d\.])+$");
            if (rgx.IsMatch(cube))
            {
                var cubeArrayData = cube.Split(",");
                return new Cube()
                {
                    X = Convert.ToInt32(cubeArrayData[0]),
                    Y = Convert.ToInt32(cubeArrayData[1]),
                    Z = Convert.ToInt32(cubeArrayData[2]),
                    Volume = Convert.ToDouble(cubeArrayData[3])
                };
            }
            throw new IncorrectDataFormatException("Please input the correct format 'X,Y,Z,Volume'. Decimal point number are accepted");
        }
    }
}
