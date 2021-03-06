﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Hero
{
    public Thief(float healthPoint, int attackPoint, int defencePoint, int luck, string classText, int heroSprite) : base(healthPoint, attackPoint, defencePoint, luck, classText, heroSprite)
    {
        healthPoint = 100.0f;
        attackPoint = 5;
        base.defencePoint = 5;
        luck = 10;
        classText = "Thief";
    }
}
