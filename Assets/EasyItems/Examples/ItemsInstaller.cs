using EasyItems.Core;
using UnityEngine;
using Zenject;

namespace EasyItems.Examples
{
    public class ItemsInstaller : MonoInstaller
    {
        [SerializeField] private ItemsScriptable _itemsScriptable; 
        
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ScriptableItemsService>()
                .AsSingle()
                .WithArguments(_itemsScriptable)
                .NonLazy();
        }
    }
}