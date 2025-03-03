using NUnit.Framework;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "Scriptable Objects/WaveData")]
public class WaveData : ScriptableObject
{
    public GameObject enemyPreFab;
    public int enemyCount;
    public float enemySpeed;
    public float enemyHealth;
    public float enemyDamage;
}
