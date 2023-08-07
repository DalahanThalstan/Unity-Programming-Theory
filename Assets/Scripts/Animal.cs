using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int Hunger { get; protected set; }
    private int HungerTickRate { get; set; }

    [SerializeField] private TextMeshProUGUI HungerText;

    // Start is called before the first frame update
    void Start()
    {
        Hunger = 100;
        HungerTickRate = 1;
        StartCoroutine(HungerTick());
    }

    public virtual void EatPlant()
    {
        Eat(25);
    }

    public virtual void EatMeat()
    {
        Eat(25);
    }

    public bool IsAlive()
    {
        return Hunger > 0;
    }

    protected void UpdateHungerText()
    {
        HungerText.text = "Hunger: " + Hunger;
    }

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
