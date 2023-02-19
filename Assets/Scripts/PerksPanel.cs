using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerksPanel : MonoBehaviour
{
    private Animator anim;
    public Text Coins_panel;

    public GameObject Egg0;
    public GameObject Egg1;
    public GameObject Egg2;
    public GameObject Egg3;
    public GameObject Egg4;

    private bool isdown = true;

    public int EggLvL_Perk;
    public int Money_doubling;
    public int Coins;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        EggLvL_Perk = PlayerPrefs.GetInt("EggLvL_Perk");
        Money_doubling = PlayerPrefs.GetInt("Money_doubling");
        Coins = PlayerPrefs.GetInt("mCoins");
    }

    // Update is called once per frame
    void Update()
    {
        Coins_panel.text = Coins.ToString();
    }

    public void EggLvl_button()
    {
        if (Coins == 2500 && EggLvL_Perk == 0)
        {
            EggLvL_Perk++;
            Coins -= 2500;
        }
        else if (Coins == 5000 && EggLvL_Perk == 1)
        {
            EggLvL_Perk++;
            Coins -= 5000;
        }
        else if (Coins == 10000 && EggLvL_Perk == 2)
        {
            EggLvL_Perk++;
            Coins -= 10000;
        }
        else if (Coins == 15000 && EggLvL_Perk == 3)
        {
            EggLvL_Perk++;
            Coins -= 15000;
        }
        else if (Coins == 22500 && EggLvL_Perk == 4)
        {
            EggLvL_Perk++;
            Coins -= 22500;
        }
        else if (Coins == 30000 && EggLvL_Perk == 5)
        {
            EggLvL_Perk++;
            Coins -= 30000;
        }
        else if (Coins == 40000 && EggLvL_Perk == 6)
        {
            EggLvL_Perk++;
            Coins -= 40000;
        }
        else if (Coins == 50000 && EggLvL_Perk == 7)
        {
            EggLvL_Perk++;
            Coins -= 50000;
        }
        else if (Coins == 65000 && EggLvL_Perk == 8)
        {
            EggLvL_Perk++;
            Coins -= 65000;
        }
        else if (Coins == 80000 && EggLvL_Perk == 9)
        {
            EggLvL_Perk++;
            Coins -= 80000;
        }
    }
    public void Money_per_egg_button()
    {
        if (Coins == 500 && Money_doubling == 0)
        {
            Money_doubling++;
            //Money X2
            Egg0.GetComponent<EggsController>().Money = Egg0.GetComponent<EggsController>().Money * 2;
            Egg1.GetComponent<EggsController>().Money = Egg1.GetComponent<EggsController>().Money * 2;
            Egg2.GetComponent<EggsController>().Money = Egg2.GetComponent<EggsController>().Money * 2;
            Egg3.GetComponent<EggsController>().Money = Egg3.GetComponent<EggsController>().Money * 2;
            Egg4.GetComponent<EggsController>().Money = Egg4.GetComponent<EggsController>().Money * 2;
            Coins -= 500;
        }
        else if (Coins == 1500 && Money_doubling == 1)
        {
            Money_doubling++;
            //Money X4
            Egg0.GetComponent<EggsController>().Money = Egg0.GetComponent<EggsController>().Money * 2;
            Egg1.GetComponent<EggsController>().Money = Egg1.GetComponent<EggsController>().Money * 2;
            Egg2.GetComponent<EggsController>().Money = Egg2.GetComponent<EggsController>().Money * 2;
            Egg3.GetComponent<EggsController>().Money = Egg3.GetComponent<EggsController>().Money * 2;
            Egg4.GetComponent<EggsController>().Money = Egg4.GetComponent<EggsController>().Money * 2;
            Coins -= 1500;
        }
        else if (Coins == 4500 && Money_doubling == 2)
        {
            Money_doubling++;
            //Money X6
            Egg0.GetComponent<EggsController>().Money = Egg0.GetComponent<EggsController>().Money * 3/2;
            Egg1.GetComponent<EggsController>().Money = Egg1.GetComponent<EggsController>().Money * 3/2;
            Egg2.GetComponent<EggsController>().Money = Egg2.GetComponent<EggsController>().Money * 3/2;
            Egg3.GetComponent<EggsController>().Money = Egg3.GetComponent<EggsController>().Money * 3/2;
            Egg4.GetComponent<EggsController>().Money = Egg4.GetComponent<EggsController>().Money * 3/2;
            Coins -= 4500;
        }
        else if (Coins == 12500 && Money_doubling == 3)
        {
            Money_doubling++;
            //Money X8
            Egg0.GetComponent<EggsController>().Money = Egg0.GetComponent<EggsController>().Money * 3 / 2;
            Egg1.GetComponent<EggsController>().Money = Egg1.GetComponent<EggsController>().Money * 3 / 2;
            Egg2.GetComponent<EggsController>().Money = Egg2.GetComponent<EggsController>().Money * 3 / 2;
            Egg3.GetComponent<EggsController>().Money = Egg3.GetComponent<EggsController>().Money * 3 / 2;
            Egg4.GetComponent<EggsController>().Money = Egg4.GetComponent<EggsController>().Money * 3 / 2;
            Coins -= 12500;
        }
        else if (Coins == 25000 && Money_doubling == 4)
        {
            Money_doubling++;
            //Money X10
            Egg0.GetComponent<EggsController>().Money = Egg0.GetComponent<EggsController>().Money * 5/4;
            Egg1.GetComponent<EggsController>().Money = Egg1.GetComponent<EggsController>().Money * 5/4;
            Egg2.GetComponent<EggsController>().Money = Egg2.GetComponent<EggsController>().Money * 5/4;
            Egg3.GetComponent<EggsController>().Money = Egg3.GetComponent<EggsController>().Money * 5/4;
            Egg4.GetComponent<EggsController>().Money = Egg4.GetComponent<EggsController>().Money * 5/4;
            Coins -= 25000;
        }
    }
    public void GoUPandDOWN()
    {
        if(isdown)
        {
            anim.SetTrigger("up");
            isdown = false;
        }
        else
        {
            anim.SetTrigger("down");
            isdown = true;
        }
    }

    public void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("mCoins", Coins);
        PlayerPrefs.SetInt("EggLvL_Perk", EggLvL_Perk);
        PlayerPrefs.SetInt("Money_doubling", Money_doubling);
    }

}