using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EasyItems.Core
{
    [Serializable]
    public struct ItemData
    {
        [JsonProperty("id")] public ushort ID;
        [JsonProperty("name")] public string Name;
        [JsonProperty("icon_path")] public string IconPath;
        [JsonProperty("item_type")] public ItemType ItemType;
        [JsonProperty("price")] public int Price;

        public ItemData(ItemData data)
        {
            ID = data.ID;
            Name = data.Name;
            IconPath = data.IconPath;
            ItemType = data.ItemType;
            Price = data.Price;
        }

        public override string ToString()
        {
            return $"{ID}: {Name}";
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemType
    {
        Equipment,
        Consumable,
        Loot
    }
}