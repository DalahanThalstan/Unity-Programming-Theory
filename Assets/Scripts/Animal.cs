using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public string Name { get; protected set; }
    public int Hunger { get; protected set; }
    private int HungerTickRate { get;  set; }

    // Start is called before the first frame update
    void Start()
    {
        Hunger = 100;
        HungerTickRate = 10;
        StartCoroutine(HungerTick());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator HungerTick()
    {
        while (IsAlive())
        {
            yield return new WaitForSeconds(HungerTickRate);
            Hunger--;

            if(!IsAlive()){
                Destroy(gameObject);
            }
        }
    }

    public bool IsAlive()
    {
        return Hunger > 0;
    }

    public virtual void EatPlant()
    {
        Hunger+=25;
        if(Hunger > 100){
            Hunger = 100;
        }
    }

    public virtual void EatMeat() {
        Hunger+=25;
        if(Hunger > 100){
            Hunger = 100;
        }
    }
}
