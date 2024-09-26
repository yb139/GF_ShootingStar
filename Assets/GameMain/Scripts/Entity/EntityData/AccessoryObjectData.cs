﻿namespace ShootingStar
{
    public abstract class AccessoryObjectData:EntityData
    {
        private int ownerId;

        public int OwnerId
        {
            get => ownerId;
        }

        protected AccessoryObjectData(int id,int ownerId) : base(id)
        {
            this.ownerId = ownerId;
        }
    }
}