using System.Collections.Generic;

namespace AppStore.Entities
{
    public class DishGroup
    {
        public int DishGroupId { get; set; }
        public string GroupName { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}