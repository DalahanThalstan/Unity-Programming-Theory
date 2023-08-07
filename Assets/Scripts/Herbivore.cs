using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herbivore : Animal
{

    public override void EatPlant()
    {
        Hunger+=50;
        if(Hunger > 100){
            Hunger = 100;
        }
    }

    public override void EatMeat() {
        Hunger+=10;
        if(Hunger > 100){
            Hunger = 100;
        }
    }
}
