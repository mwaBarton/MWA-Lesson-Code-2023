using System;
using System.Collections.Generic;

namespace L164___Interfaces
{
    interface IDog
    {
        bool Eat(double volumeOfFood);
        string Lick();
    }

    interface IPet
    {
        string Lick();
        void Wash();
        double TakeToVet();
    }

    public class PetDog : IDog, IPet
    {
        public bool Eat(double volumeOfFood)
        {
            return (volumeOfFood > 10);
        }

        public string Lick()
        {
            return "sound of licking";
        }

        public double TakeToVet()
        {
            return double.MaxValue;
        }

        public void Wash()
        {
            Console.WriteLine("sound of washing");
        }
    }



    interface IConsumable
    {
        int Consume();
        bool IsConsumed();
    }

    interface IBreakable
    {
        void Repair(int amountToRepair);
        void Degrade(int amountToDegrade);
        bool IsBroken();
    }

    public abstract class Item { }

    public class Food : Item, IConsumable
    {
        private int hpWhenConsumed;
        protected bool consumed = false;
        public Food(int hpWhenConsumed)
        {
            this.hpWhenConsumed = hpWhenConsumed;
        }
        public virtual int Consume()
        {
            if (consumed) return 0;
            else return hpWhenConsumed;
        }
        public bool IsConsumed()
        {
            return consumed;
        }
    }

    public class ExpiringFood : Food, IBreakable
    {
        private int daysUntilExpiry;
        public ExpiringFood(int hpWhenConsumed, int initialDaysUntilExpiry) : base(hpWhenConsumed)
        {
            daysUntilExpiry = initialDaysUntilExpiry;
        }
        public void Degrade(int amountToDegrade)
        {
            daysUntilExpiry -= amountToDegrade;
            if (daysUntilExpiry <= 0)
            {
                daysUntilExpiry = 0;
                Consume();
            }
        }
        public bool IsBroken()
        {
            return daysUntilExpiry == 0;
        }
        public void Repair(int amountToRepair)
        {
            daysUntilExpiry += amountToRepair;
        }
    }

    public class Shovel : Item, IBreakable
    {
        private int durability;
        public Shovel(int initialDurability)
        {
            this.durability = initialDurability;
        }
        public void Degrade(int amountToDegrade)
        {
            durability -= amountToDegrade;
            if (durability < 0) durability = 0;
        }
        public bool IsBroken()
        {
            return (durability == 0);
        }
        public void Repair(int amountToRepair)
        {
            durability += amountToRepair;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> inventory = new List<Item>();

            inventory.Add(new Shovel(3));
            inventory.Add(new ExpiringFood(100, 2));
            inventory.Add(new Food(50));

            while (true)
            {
                foreach (Item item in inventory)
                {
                    Console.WriteLine("What would you like to do?");
                    // ...
                }
            }
        }
    }
}
