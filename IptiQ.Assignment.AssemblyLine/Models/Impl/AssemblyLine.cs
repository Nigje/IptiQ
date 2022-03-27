using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine.Models.Impl
{
    /// <summary>
    ///     Assembly Line.
    /// </summary>
    public class AssemblyLine : IAssemblyLine
    {
        /// <summary>
        ///     QA station.
        /// </summary>
        private readonly IQAStation _qaStation;

        /// <summary>
        ///     Stations.
        /// </summary>
        private IList<IStation> _stations = new List<IStation>();
        
        public AssemblyLine(IQAStation qaStation)
        {
            _qaStation = qaStation;
        }

        /// <summary>
        ///     Add a new station.
        /// </summary>
        /// <param name="station"></param>
        public void AddStation(IStation station)
        {
            _stations.Add(station);
        }

        /// <summary>
        ///     Produce a car.
        /// </summary>
        /// <param name="assemblyCarEntity"></param>
        /// <returns></returns>
        public async Task<Car> ProduceAsync(AssemblyCarEntity assemblyCarEntity)
        {
            do
            {
                try
                {
                    ValidateStations(_stations);
                    foreach (IStation station in _stations.OrderBy(x => (int)x.Position))
                    {
                        await station.DoTaskAsync(assemblyCarEntity);
                    }
                    Car car = await _qaStation.BuildAndCheckQualityAsync(assemblyCarEntity);
                    return car;
                }
                catch (LowQualityException ex)
                {
                    //Log and try again.
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } while (true);
        }

        /// <summary>
        ///     Validate stations.
        /// </summary>
        /// <param name="stations"></param>
        /// <exception cref="Exception"></exception>
        private void ValidateStations(IList<IStation> stations)
        {
            if (!stations.Any() || stations.Count < 1)
                throw new Exception("Station counts should be more than 1.");
        }
    }
}
