using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] Eggs;
        private GameObject PerksPanel;

    private int EggLvL;

    private int MaxRandom_choosing;

    public float end_time;
    public float spawn_time;

    // Start is called before the first frame update
    void Start()
    {
        PerksPanel = GameObject.Find("Perks Panel");

        float randspawn = Random.Range(0, 3);
        spawn_time = randspawn;
    }

    // Update is called once per frame
    void Update()
    {

        EggLvL = PerksPanel.GetComponent<PerksPanel>().EggLvL_Perk;

        #region EgglVls
        if (EggLvL == 0)
        {
            MaxRandom_choosing = 0;
        }
        else if (EggLvL == 1)
        {
            MaxRandom_choosing = 4;
        }
        else if (EggLvL == 2)
        {
            MaxRandom_choosing = 16;
        }
        else if (EggLvL == 3)
        {
            MaxRandom_choosing = 10;
        }
        else if (EggLvL == 4)
        {
            MaxRandom_choosing = 10;
        }
        else if (EggLvL == 5)
        {
            MaxRandom_choosing = 10;
        }
        else if (EggLvL == 6)
        {
            MaxRandom_choosing = 10;
        }
        else if (EggLvL == 7)
        {
            MaxRandom_choosing = 10;
        }
        else if (EggLvL == 8)
        {
            MaxRandom_choosing = 10;
        }
        else if (EggLvL == 9)
        {
            MaxRandom_choosing = 10;
        }
        #endregion

        #region Spawning Logic

        spawn_time += Time.deltaTime;

        if (spawn_time > end_time)
        {
            int EggType_possible = Random.Range(0, MaxRandom_choosing);
            if (EggLvL == 0)
            {
                Instantiate(Eggs[0], transform.position, transform.rotation);
                float randspawn = Random.Range(2, 3);
                spawn_time = randspawn;
            }
            else if (EggLvL == 1)
            {
                if (EggType_possible <= 2)
                {
                    Instantiate(Eggs[0], transform.position, transform.rotation);
                    float randspawn = Random.Range(2, 3);
                    spawn_time = randspawn;
                }
                else if (EggType_possible == 3)
                {
                    Instantiate(Eggs[1], transform.position, transform.rotation);
                    float randspawn = Random.Range(2, 3);
                    spawn_time = randspawn;
                }
            }
            else if (EggLvL == 2)
            {
                if (EggType_possible <= 9)
                {
                    Instantiate(Eggs[0], transform.position, transform.rotation);
                    float randspawn = Random.Range(2, 3);
                    spawn_time = randspawn;
                }
                else if (EggType_possible > 9 && EggType_possible <= 13)
                {
                    Instantiate(Eggs[1], transform.position, transform.rotation);
                    float randspawn = Random.Range(2, 3);
                    spawn_time = randspawn;
                }
                else if (EggType_possible > 13 && EggType_possible <= 15)
                {
                    Instantiate(Eggs[2], transform.position, transform.rotation);
                    float randspawn = Random.Range(2, 3);
                    spawn_time = randspawn;
                }
            }
        }
        #endregion

    }

}
