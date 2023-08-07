using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// Child class of Animal. Herbivores mainly eat plants.
public class Herbivore : Animal
{

    // POLYMORPHISM
    // When called the Herbivore will eat some plants. This restores a lot of hunger since the herbivore likes plants.
    public override void EatPlant()
    {
        Eat(50);
    }

    // POLYMORPHISM
    // When called the Herbivore will eat some meat. Since the Herbivore does not like meat this does not restore much hunger.
    public override void EatMeat()
    {
        Eat(10);
    }
}
