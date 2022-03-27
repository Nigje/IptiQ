using IptiQ.Assignment.AssemblyLine.Models;
using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace IptiQ.Assignment.AssemblyLine.Tests.UnitTests
{
    public class AssemblyLineTests
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
            Mock<IQAStation> qaStation = new Mock<IQAStation>();
            qaStation.Setup(s => s.BuildAndCheckQualityAsync(It.IsAny<AssemblyCarEntity>())).ReturnsAsync(new Car());
            qaStation.Setup(s => s.Position).Returns(Position.QualityAssuranceAndBuild);

            //  AssemblyLine.
            IAssemblyLine assemblyLine = new Models.Impl.AssemblyLine(qaStation.Object);

            //  Add stations (the sequence of add is not important).
            Mock<IStation> PaintingStation = new Mock<IStation>();
            PaintingStation.Setup(s => s.DoTaskAsync(It.IsAny<AssemblyCarEntity>()));
            PaintingStation.Setup(s => s.Position).Returns(Position.Painting);

            assemblyLine.AddStation(PaintingStation.Object);
            #endregion

            #region Act
            //  Produce a car.
            Car car = await assemblyLine.ProduceAsync(new AssemblyCarEntity());
            #endregion

            #region Assert
            Assert.NotNull(car);
            #endregion
        }

        /// <summary>
        ///     It will throw an exception because the number of stations is less than two.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task Should_ThrowException_LessThanTwoStation()
        {
            #region Arrange
            //  Build and QA station.
            Mock<IQAStation> qaStation = new Mock<IQAStation>();
            qaStation.Setup(s => s.BuildAndCheckQualityAsync(It.IsAny<AssemblyCarEntity>())).ReturnsAsync(new Car());
            qaStation.Setup(s => s.Position).Returns(Position.QualityAssuranceAndBuild);

            //  AssemblyLine.
            IAssemblyLine assemblyLine = new Models.Impl.AssemblyLine(qaStation.Object);
            #endregion

            #region Act
            //  Produce a car.
            var exception = await Assert.ThrowsAsync<Exception>(async() => await assemblyLine.ProduceAsync(new AssemblyCarEntity()));
            #endregion

            #region Assert
            Assert.Equal("Station counts should be more than 1.", exception.Message);
            #endregion
        }
    }

}
