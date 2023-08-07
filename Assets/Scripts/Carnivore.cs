using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carnivore : Animal
{

    public override void EatPlant()
    {
        Hunger+=10;
        if(Hunger > 100){
            Hunger = 100;
        }
    }

    public override void EatMeat() {
        Hunger+=50;
        if(Hunger > 100){
            Hunger = 100;
        }
    }
}
