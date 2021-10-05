using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace AppStore.Blazor.Client.Models
{
    public class DetailsViewModel
    {
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } // название блюда
        [JsonPropertyName("description")]
        public string Description { get; set; } // описание блюда
        [JsonPropertyName("calories")]
        public int Calories { get; set; } // кол. калорий на порцию
        [JsonPropertyName("image")]
        public string Image { get; set; }
    }
}
