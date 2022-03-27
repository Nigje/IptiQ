using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models
{
    /// <summary>
    ///     AssemblyCarEntity
    /// </summary>
    public class AssemblyCarEntity
    {
        /// <summary>
        ///     Paint the entity.
        /// </summary>
        /// <returns></returns>
        public async Task Paint() { await Task.CompletedTask; }

        /// <summary>
        ///     Mechanic of the entity.
        /// </summary>
        /// <returns></returns>
        public async Task AssemblyMechanic() { await Task.CompletedTask; }

        /// <summary>
        ///     Interior of the entity.
        /// </summary>
        /// <returns></returns>
        public async Task AssemblyInterior() { await Task.CompletedTask; }

        /// <summary>
        ///     Build the entity.
        /// </summary>
        /// <returns></returns>
        public async Task<Car> Build() { return new Car(); }
    }
}
