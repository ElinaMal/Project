using Protagonists;
using Weapons;
using UnityEngine;


namespace Protagonists
{
    public class Golden
    {
        public string nameG = "Golden";
        [SerializeField] public float health;
        [SerializeField] public float velocity;
        [SerializeField] public float damage;
    }

    public class Amber
    {
        public string nameA = "Amber";
        [SerializeField] public float health;
        [SerializeField] public float velocity;
        [SerializeField] public float damage;
    }

    public class Silver
    {
        public string nameS = "Silver";
        [SerializeField] public float health;
        [SerializeField] public float velocity;
        [SerializeField] public float damage;
    }
}

namespace Weapons
{
    public static class FierceEdge
    {
        [SerializeField] public static float addedDamage;
        [SerializeField] public static float cooldown;
    }

    public static class LightningOrb
    {
        [SerializeField] public static float addedDamage;
        [SerializeField] public static float cooldown;
    }

    public static class Talons
    {
        [SerializeField] public static float addedDamage;
        [SerializeField] public static float cooldown;
    }
}

public class Choices : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
