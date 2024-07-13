namespace Domain.Helpers
{
    /// <summary>
    /// Represents the result of a trend rate.
    /// </summary>
    /// <typeparam name="T">Value of a rate can be anything from an
    /// intiger to whole array of more complex types.</typeparam>
    public class Result
    {
        public List<double> Value { get; set; } = [];
        public string? Unit { get; set; } = null;
    }
}