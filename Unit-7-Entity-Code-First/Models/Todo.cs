using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unit_7_Entity_Code_First.Models
{
    public class Todo 
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // auto incrementing our ID
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDone { get; set; }
    }
}
