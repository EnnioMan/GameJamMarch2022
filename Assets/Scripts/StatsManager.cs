using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
   
    public float Openness
    {
        get => openness;

        set => openness = Mathf.Clamp01(value);
        //set "aura" et if le joueur lui assigne un accessoire, changer en cons�quence. 
    }
    public float Mobility
    {
        get => mobility;
        set => mobility = Mathf.Clamp01(value);
        //changer en cons�quence si le joueur  lui assigne un accessoire. 
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        //if hat, activate hat, augmenter la mobilit� de 0.25f
        //if back
    }

    private float openness = Random.Range(0f,1f);
    private float mobility = Random.Range(0f,1f);
}
