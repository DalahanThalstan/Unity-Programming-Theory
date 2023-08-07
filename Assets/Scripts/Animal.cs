using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// INHERITANCE
// Class represents an Animal. In it's base form represents more an Omnivore as it equally likes meat and plants.
public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    private int Hunger { get; set; }
    private int HungerTickRate { get; set; }

    [SerializeField] private TextMeshProUGUI HungerText;

    // Start is called before the first frame update
    void Start()
    {
        Hunger = 100;
        HungerTickRate = 1;
        StartCoroutine(HungerTick());
    }

    // POLYMORPHISM
    // When called the Animal will eat some plants. This method can be overridden.
    public virtual void EatPlant()
    {
        Eat(25);
    }

    // POLYMORPHISM
    // When called the Animal will eat some meat. This method can be overridden.
    public virtual void EatMeat()
    {
        Eat(25);
    }

    // Helper function to determine if the Animal is alive. An Animal is alive as long as their Hunger is greater than 0.
    public bool IsAlive()
    {
        return Hunger > 0;
    }

    // ABSTRACTION
    // Method that will update the GUI to show the current Hunger. This method should be called when there is a change to the Hunger value.
    protected void UpdateHungerText()
    {
        HungerText.text = "Hunger: " + Hunger;
    }

    // ABSTRACTION
    // Generic method that handles restoring an Animals Hunger. Hunger will increase by the value entered but will cap at 100. It will do nothing if the Animal is dead (has 0 Hunger).
    protected void Eat(int value)
    {
        if (IsAlive())
        {
            Hunger += value;
            if (Hunger > 100)
            {
                Hunger = 100;
            }
            UpdateHungerText();
        }
    }

    // Logic that handles decreasing hunger over time.
    private IEnumerator HungerTick()
    {
        while (IsAlive())
        {
            yield return new WaitForSeconds(HungerTickRate);
            Hunger--;

            if (!IsAlive())
            {
                Destroy(gameObject);
            }
            UpdateHungerText();
        }
    }
}
