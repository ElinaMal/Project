using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    public float health;
    public float velocity;
    public float damage;
    public float defense;
    public GameObject prefab;
}
