using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GetComponent<CircleCollider2D>().enabled = true;
            transform.position = new Vector2(wp.x, wp.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Egg"))
        {
            GameObject TheEgg = collision.gameObject;
            GetComponent<CircleCollider2D>().enabled = false;
            //the minus is *3
            TheEgg.GetComponent<EggsController>().TimeTOcrack -= 1;
        }
    }
}
