using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //Singleton
    static public InventoryManager Instance;
    
   [SerializeField] private string texto = "Hola";
   [SerializeField] private string[] textos;
   [SerializeField] private List<string> textoLista;
   [SerializeField] private Dictionary<string, int> textoDic = new Dictionary<string, int>();

   [SerializeField] private int maxItemsHeld;
   [SerializeField] private List<Collectible> collectibles;
   
   //así se declara un singleton
   private void Awake()
   {
       Instance = this;
   }


   public bool canTakeItem(Collectible collectible)
   {
       //get count of collectables with the same type
       var itemsHeld = collectibles.Count(t => t.collectibleType == collectible.collectibleType);
       return itemsHeld >= collectible.maxHeld;
   }

   public void AddItemToInventory(Collectible collectible)
   {
       collectibles.Add(collectible);
       Debug.Log("Agregando collectible " + collectible.name);
   }
}
