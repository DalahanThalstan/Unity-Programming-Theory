using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carnivore : Animal
{

    public override void EatPlant()
    {
        Eat(10);
        
    }

    public override void EatMeat() {
        Eat(50);
    }
}
