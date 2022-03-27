namespace IptiQ.Assignment.AssemblyLine.Models
{
    /// <summary>
    ///     Enums to determine stations' position in the assembly line.
    /// </summary>
    public enum Position
    {
        /// <summary>
        ///     Paiting station.
        /// </summary>
        Painting,

        /// <summary>
        ///     Mechanic assembly station.
        /// </summary>
        MechanicAssembly,

        /// <summary>
        ///    Interior parts assembly station.
        /// </summary>
        InteriorPartsAssembly,

        /// <summary>
        ///     Quality assurance and build station.
        /// </summary>
        QualityAssuranceAndBuild,

    }
}
