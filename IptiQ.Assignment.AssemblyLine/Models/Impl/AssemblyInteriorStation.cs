using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Impl
{
    /// <summary>
    ///     Assembly interiors.
    /// </summary>
    public class AssemblyInteriorStation : IStation
    {
        public Position Position => Position.InteriorPartsAssembly;

        public async Task DoTaskAsync(AssemblyCarEntity assemblyCarEntity)
        {
            //Do task.
            assemblyCarEntity.AssemblyInterior();

            await Task.CompletedTask;
        }
    }
}
