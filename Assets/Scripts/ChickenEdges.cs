using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenEdges : MonoBehaviour
{

    public GameObject Eggpos;

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Egg"))
        {
            Eggpos.GetComponent<Spawner>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Egg"))
        {
            Eggpos.GetComponent<Spawner>().enabled = true;
        }
    }
}
