using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Abstracts
{
    public interface IAssemblyLine
    {
        /// <summary>
        ///     Add new station.
        /// </summary>
        /// <param name="station"></param>
        void AddStation(IStation station);

        /// <summary>
        ///     Produce a new car.
        /// </summary>
        /// <param name="assemblyCarEntity"></param>
        /// <returns></returns>
        Task<Car> ProduceAsync(AssemblyCarEntity assemblyCarEntity);
    }
}
