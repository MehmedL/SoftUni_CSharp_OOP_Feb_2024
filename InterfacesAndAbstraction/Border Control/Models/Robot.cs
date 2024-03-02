using Border_Control.Models.Interfaces;

namespace Border_Control.Models
{
    public class Robot : BaseEntity
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        
        public string Model { get; init; }
    }
}
