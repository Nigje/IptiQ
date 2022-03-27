using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Impl
{
    /// <summary>
    ///     Paint the car.
    /// </summary>
    public class PaintingStation : IStation
    {
        public Position Position => Position.Painting; 

        public async Task DoTaskAsync(AssemblyCarEntity assemblyCarEntity)
        {
            assemblyCarEntity.Paint();

            await Task.CompletedTask;
        }
    }
}
