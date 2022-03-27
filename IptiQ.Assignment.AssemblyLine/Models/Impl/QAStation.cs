using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using System;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Impl
{
    /// <summary>
    ///     QA station.
    /// </summary>
    public class QAStation : IQAStation
    {

        public Position Position => Position.QualityAssuranceAndBuild;

        public async Task<Car> BuildAndCheckQualityAsync(AssemblyCarEntity assemblyCarEntity)
        {
            Car car =await assemblyCarEntity.Build();
            Random random = new Random();
            int quality = random.Next(1, 100);
            // If the car has not enough quality:
            if (quality < 80)
                throw new LowQualityException($"The quality of the car is: {quality}%");

            // Has quality.
            return car;
        }
    }
}
