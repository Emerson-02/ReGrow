using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float pollution = 100;
    public float minPollution = 0;
    public float cycleTime = 0;
    public float timer = 0;
    public bool isTimerRunning = false;


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
    public void IncreaseCycleTime()
    {
        //cycleTime -= amount;

        cycleTime += Time.deltaTime;

        if (cycleTime > 60)
        {
            // troca o ciclo


            cycleTime = 0;
        }
    
    }

    void TimerGeral()
    {
        if(isRunning)
        {
            timer += Time.deltaTime;
        }
    }

    void ChangeTimer()
    {
        if(isTimerRunning == true)
        {
            isTimerRunning = false;
        }
        else if(isTimerRunning == false)
        {
            isTimerRunning = true;
        }
    }

    

    private void Update() 
    {
        IncreaseCycleTime();
        TimerGeral();
    }





}
