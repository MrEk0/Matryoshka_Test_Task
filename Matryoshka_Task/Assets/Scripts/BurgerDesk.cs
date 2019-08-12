using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerDesk : MonoBehaviour
{
    [SerializeField] Transform burgerpoint;
    [SerializeField] GameObject burger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetMeat()
    {
        FindObjectOfType<BunClick>().Delete();//Gama manager has to do that
        Instantiate(burger, burgerpoint.position, burgerpoint.rotation);
        Debug.Log("meat");
    }
}
