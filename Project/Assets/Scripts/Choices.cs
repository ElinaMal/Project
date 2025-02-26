using Protagonist;
using Weapons;
using UnityEngine;
using System;


namespace Protagonist
{
    public static class PlayerData
    {
        public static int deathCounter;
    }

    public class Player
    {
        public string name;
        public float health;
        public float velocity;
        public float damage;

        public int number;

        public Player(string name, float health, float velocity, float damage)
        {
            this.name = name;
            this.health = health;
            this.velocity = velocity;
            this.damage = damage;
        }

        public void GetHurt()
        {
            health = health - 10;
        }
    }

    public class Golden : Player
    {
        public Golden() : base("Golden", 100, 8, 10)
        {
            number = 0;
        }
    }

    public class Amber : Player
    {
        public Amber() : base("Amber", 60, 12, 8)
        {
            number = 1;
        }
    }

    public class Silver : Player
    {
        public Silver() : base("Silver", 80, 10, 9)
        {
            number = 2;
        }
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
        Silver silver = new Silver();
        Debug.Log("Hi " + silver.name);

        Player myPlayer = new Golden();
        Debug.Log(myPlayer.name + ", welcome");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
