using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Impl
{
    /// <summary>
    ///     Assembly Mechanic.
    /// </summary>
    public class AssemblyMechanicStation:IStation
    {
        public Position Position => Position.MechanicAssembly;

        public async Task DoTaskAsync(AssemblyCarEntity assemblyCarEntity)
        {
            assemblyCarEntity.AssemblyMechanic();

            await Task.CompletedTask;
        }
    }
}
