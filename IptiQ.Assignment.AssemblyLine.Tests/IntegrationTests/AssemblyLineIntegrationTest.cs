using IptiQ.Assignment.AssemblyLine.Models;
using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using IptiQ.Assignment.AssemblyLine.Models.Impl;
using System.Threading.Tasks;
using Xunit;

namespace IptiQ.Assignment.AssemblyLine.Tests.IntegrationTests
{
    public class AssemblyLineIntegrationTest
    {
        /// <summary>
        ///     Produce a car without any exception.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_Produce_ANewCar()
        {
            #region Arrange
            //  Build and QA station.
            IQAStation qaStation = new QAStation();

            //  AssemblyLine.
            IAssemblyLine assemblyLine = new Models.Impl.AssemblyLine(qaStation);

            //  Add stations (the sequence of add is not important).
            assemblyLine.AddStation(new AssemblyInteriorStation());
            assemblyLine.AddStation(new PaintingStation());
            assemblyLine.AddStation(new AssemblyMechanicStation());
            #endregion

            #region Act
            //  Produce a car.
            Car car = await assemblyLine.ProduceAsync(new AssemblyCarEntity());
            #endregion

            #region Assert
            Assert.NotNull(car);
            #endregion
        }
    }
}
