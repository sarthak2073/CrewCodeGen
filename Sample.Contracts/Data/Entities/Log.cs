using System;

namespace Sample.Contracts.Data.Entities
{
    /// <summary>
    /// Represents the Log entity with properties such as Log and CreatedAt.
    /// </summary>
    public class Log : BaseEntity
    {
        /// <summary>
        /// Gets or sets the Log message.
        /// </summary>
        public string Log { get; set; }
        
        /// <summary>
        /// Gets or sets the DateTime when the Log was created.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}