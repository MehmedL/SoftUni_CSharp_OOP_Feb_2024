using System.Collections.Generic;

namespace Border_Control.Models
{
    public class BorderControl
    {
        private List<BaseEntity> entities;
        
        public List<BaseEntity> EntityToBeChecked 
        {
            get => entities;
        }
        public BorderControl()
        {
            entities = new List<BaseEntity>();
        }

        

        public void AddEntityBorderCheck(BaseEntity entity)
        {
            entities.Add(entity); 
        }


    }
}
