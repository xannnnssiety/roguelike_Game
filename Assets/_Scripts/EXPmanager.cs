using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXPmanager : MonoBehaviour
{

    public static int EXPcount = 1;
    public static int maxEXP = 10;
    public static int lvl = 1;

    /*public AudioSource pickup;*/
    /*public AudioClip pickUP;*/



    public void Start()
    {

 /*       maxEXP = 10;
        EXPcount = 1;*/ /*количество полученого опыта*/
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            /*pickup.Play();*/
            Player.EXP += EXPcount;
            Destroy(gameObject); /*ƒолжен удал€тьс€ */
        }
    }




    

}
