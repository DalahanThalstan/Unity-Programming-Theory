using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herbivore : Animal
{

    public override void EatPlant()
    {
        Eat(50);
    }

    public override void EatMeat() {
        Eat(10);
    }
}
