using System.Collections.Generic;
using Zenject;

namespace EasyItems.Core
{
    public interface IItemsService
    {
        public ItemData GetItemById(ushort id);
        public ushort GetStackRestrictionByItemType(ItemType itemType);
    }

    public class ScriptableItemsService : IItemsService
    {
        private readonly Dictionary<ushort, ItemData> _allItems;
        private readonly Dictionary<ItemType, ushort> _stackRestrictions;

        [Inject]
        public ScriptableItemsService(ItemsScriptable itemsScriptable)
        {
            _allItems = itemsScriptable.GetAllItems();
            _stackRestrictions = itemsScriptable.GetStackRestrictions();
        }

        public ItemData GetItemById(ushort id)
        {
            return _allItems[id];
        }

        public ushort GetStackRestrictionByItemType(ItemType itemType)
        {
            return _stackRestrictions[itemType];
        }
    }
}