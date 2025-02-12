namespace Sample.Contracts.Responses
{
    /// <summary>
    /// Base Response DTO
    /// </summary>
    public class BaseResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}