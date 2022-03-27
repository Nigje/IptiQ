using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Abstracts
{
    public interface IQAStation
    {
        /// <summary>
        ///     Poistion in line.
        /// </summary>
        Position Position { get; }

        /// <summary>
        ///     Build a new car and check its quality.
        /// </summary>
        /// <param name="assemblyCarEntity"></param>
        /// <returns></returns>
        Task<Car> BuildAndCheckQualityAsync(AssemblyCarEntity assemblyCarEntity);
    }
}
