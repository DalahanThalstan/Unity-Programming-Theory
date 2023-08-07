using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
// Child class of Animal. Carnivores mainly eat meat.
public class Carnivore : Animal
{

    // POLYMORPHISM
    // When called the Carnivore will eat some plants. Since the Carnivore does not like plants this does not restore much hunger.
    public override void EatPlant()
    {
        Eat(10);

    }

    // POLYMORPHISM
    // When called the Carnicore will eat some meat. This restores a lot of hunger since carnivores like meat.
    public override void EatMeat()
    {
        Eat(50);
    }
}
