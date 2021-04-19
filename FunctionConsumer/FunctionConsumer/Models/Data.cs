
namespace FunctionConsumer.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Data
    {
        [Key]
        public string NameDevice { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EventDate { get; set; }
        [Required]
        public string Event { get; set; }

    }
}