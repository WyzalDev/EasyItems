using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace EasyItems.Core
{
    [CreateAssetMenu(fileName = "ItemsDB", menuName = "InventorySystem/ItemsDB", order = 0)]
    public class ItemsScriptable : ScriptableObject
    {
        [SerializeField] private List<ItemData> _allItems;
        [SerializeField] private List<StackRestrictionsKV> _stackRestrictions;

        public Dictionary<ushort, ItemData> GetAllItems()
        {
            return _allItems.ToDictionary(kvp => kvp.ID, kvp => new ItemData(kvp));
        }

        public Dictionary<ItemType, ushort> GetStackRestrictions()
        {
            return _stackRestrictions.ToDictionary(kvp => kvp.KType, kvp => kvp.VStackRestriction);
        }
    }

    [Serializable]
    public class StackRestrictionsKV
    {
        public ItemType KType;
        public ushort VStackRestriction;
    }
}