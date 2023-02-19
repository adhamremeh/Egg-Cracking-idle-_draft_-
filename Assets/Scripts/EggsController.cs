using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsController : MonoBehaviour
{
    public int TimeTOcrack;
    public int Money;

    public GameObject Base;
    public GameObject Top;
    public GameObject Explosion;

    private GameObject PerksPanel;
                           
    // Start is called before the first frame update
    void Start()
    {
        PerksPanel = GameObject.Find("Perks Panel");
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-300, 0));
    }

    // Update is called once per frame
    void Update()
    {

        if (TimeTOcrack <= 0)
        {
            Base.AddComponent<Rigidbody2D>();
            Top.AddComponent<Rigidbody2D>();
            Base.GetComponent<SpriteRenderer>().sortingOrder = 100;
            Top.GetComponent<SpriteRenderer>().sortingOrder = 100;
            Instantiate(Explosion, transform.position, Quaternion.identity);
            if (transform.localEulerAngles.z < 360 && transform.localEulerAngles.z > 180)
            { 
                Base.GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(-50, 300), new Vector2(Base.transform.position.x - 0.237f, Base.transform.position.y - 0.064f));
                Top.GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(50, 300), new Vector2(Top.transform.position.x + 0.209f, Top.transform.position.y + 0.023f));
            }
            else if (transform.localEulerAngles.z > 0 && transform.localEulerAngles.z < 180)
            {
                Base.GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(50, 300), new Vector2(Base.transform.position.x - 0.237f, Base.transform.position.y - 0.064f));
                Top.GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(-50, 300), new Vector2(Top.transform.position.x + 0.209f, Top.transform.position.y + 0.023f));
            }
            Base.transform.parent = null;
            Top.transform.parent = null;
            PerksPanel.GetComponent<PerksPanel>().Coins += Money;
            Destroy(gameObject);
            TimeTOcrack = 100;
        }
    
    }

}
