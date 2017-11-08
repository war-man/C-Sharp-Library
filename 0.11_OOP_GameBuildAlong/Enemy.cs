﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_GameBuildAlong
{
    class Enemy : Character
    {
        public Enemy(string name, int level)
        {
            this.Name = name;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 16;
            this.CritChance = 0.50;
        }
    }
}
