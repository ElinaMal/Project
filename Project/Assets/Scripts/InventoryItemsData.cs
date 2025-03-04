using UnityEngine;

[CreateAssetMenu(fileName = "InventoryItemsData", menuName = "Scriptable Objects/InventoryItemsData")]
public class InventoryItemsData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public GameObject itemPrefab;
}
