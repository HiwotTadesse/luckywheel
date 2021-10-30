using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {

    private bool endGame = false;

    public Rotater rotater;

    public Spawner hole;

    public void EndGame()
    {
        if (endGame)
           
        rotater.enabled = false;
        hole.enabled = false;
        endGame = true;
    }
	
}
