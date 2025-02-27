using Protagonist;
using Weapons;
using UnityEngine;
using System;


namespace Protagonist
{
    public static class PlayersData
    {
        public static int totalDeathCounter;
        public static int totalKillCounter;

        public static void Death()
        {
            totalDeathCounter++;
        }

        public static void Kill()
        {
            totalKillCounter++;
        }
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

        public void GetHurt(float damage)
        {
            health = health - damage;
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
    public class FierceEdge
    {
        public float addedDamage;
        public float cooldown;
    }

    public class LightningOrb
    {
        public float addedDamage;
        public float cooldown;
    }

    public class Talons
    {
        public float addedDamage;
        public float cooldown;
    }
}

public class Choices : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Silver silver = new Silver();
        Debug.Log("Hi " + silver.name);

        Player golden = new Golden();
        Debug.Log(golden.name + ", welcome");

        golden.GetHurt(34);
        Debug.Log(golden.health);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
