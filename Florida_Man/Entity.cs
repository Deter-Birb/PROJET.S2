using System;

namespace Florida_Man
{
    public enum EntityType
    {
        PLAYER,
        CROCO,
        BERD
    }
    
    public class Entity
    {
        #region Constructor

        public bool isKo;
        public int degats;
        public int hp;
        public EntityType type;

        public int Hp
        {
            get => hp;
            set => hp = value;
        }

        public EntityType Type
        {
            get => type;
            set => type = value;
        }

        public bool IsKo
        {
            get => hp <= 0;
            set
            {
                isKo = value;
                isKo = false;
            }
        }

        public int Degats
        {
            get => degats;
            set => degats = value;
        }

        public Entity(EntityType type, int hp, int degats)
        {
            this.hp = hp;
            this.type = type;
            this.degats = degats;
        }

        #endregion
    }
}