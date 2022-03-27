using System;

namespace IptiQ.Assignment.AssemblyLine.Models
{
    /// <summary>
    ///     An exception to throw when the quality of a car is not enough.
    /// </summary>
    public class LowQualityException:Exception
    {
        public LowQualityException(string? message) : base(message) { }
    }
}
