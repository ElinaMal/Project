using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class EnemySpawner : MonoBehaviour
{
    public List<LevelSetups> levelSetups;
    [SerializeField] public int levelSetupNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < levelSetups[levelSetupNumber].enemyNumber; i++)
        {
            Instantiate(levelSetups[levelSetupNumber].enemyType, transform.position, Quaternion.identity);
        }
    }
}
