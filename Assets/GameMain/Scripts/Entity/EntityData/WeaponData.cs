﻿using System;
using GameFramework.DataTable;
using UnityEngine;

namespace ShootingStar
{
    [Serializable]
    public class WeaponData:EntityData
    {
        [SerializeField] private int attack;
        [SerializeField] private float attackInterval;
        [SerializeField] private float speed;
        
        public WeaponData(int entityID,EnumEntity id) : base(entityID,(int)id)
        {
            IDataTable<DRWeapon> dtWeapon = GameEntry.DataTable.GetDataTable<DRWeapon>();
            DRWeapon drWeapon = dtWeapon.GetDataRow((int)id);
            speed = drWeapon.Speed;
            attack = drWeapon.Attack;
            attackInterval = drWeapon.AttackInterval;
        }

        public int Attack
        {
            get => attack;
            set => attack = value;
        }

        public float AttackInterval
        {
            get => attackInterval;
            set => attackInterval = value;
        }

        public float Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}