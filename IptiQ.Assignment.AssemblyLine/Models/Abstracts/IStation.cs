using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Abstracts
{
    /// <summary>
    ///     Stations in the AssebmlyLine.
    /// </summary>
    public interface IStation
    {
        /// <summary>
        ///     Position in the line.
        /// </summary>
        Position Position { get; }

        /// <summary>
        ///     Do task.
        /// </summary>
        /// <param name="assemblyCarEntity"></param>
        /// <returns></returns>
        Task DoTaskAsync(AssemblyCarEntity assemblyCarEntity);
    }
}
