using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameController gameController;

    private void Awake() {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    public void Regar()
    {
        // diminui na metade o ciclo de tempo
        gameController.DecreaseCycleTime(gameController.cycleTime / 2);
    }

    //função para colher uma planta, recebe um objeto do tipo planta
    public void Colher(Planta plant)
    {
        // aumenta a poluição
        gameController.IncreasePollution(plant.pollution);
        // destroi a planta
        Destroy(plant.gameObject);
    }
}
