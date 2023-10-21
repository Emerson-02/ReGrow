using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float pollution = 100;
    public float minPollution = 0;
    public int cycleTime = 60;


    // função para diminuir a poluição
    public void DecreasePollution(float amount)
    {
        pollution -= amount;
        if (pollution < minPollution)
        {
            pollution = minPollution;
        }
    }

    // função para aumentar a poluição
    public void IncreasePollution(float amount)
    {
        pollution += amount;
    }

    // função para diminuir o ciclo de tempo
    public void DecreaseCycleTime(int amount)
    {
        cycleTime -= amount;
        if (cycleTime < 0)
        {
            cycleTime = 60;
        }
    
    }

    

    private void FixedUpdate() {
    }





}
