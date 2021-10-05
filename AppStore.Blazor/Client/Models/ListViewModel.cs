using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace AppStore.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; } // id блюда
        [JsonPropertyName("dishName")]
        public string DishName { get; set; }
    }
}
