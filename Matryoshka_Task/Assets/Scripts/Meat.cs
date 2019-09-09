using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    private bool isReady = true;

    private void OnMouseDown()
    {
        if(isReady)
        {
            FindObjectOfType<BurgerDesk>().GetMeat();
            Destroy(gameObject);
        }

        //if it is ready we can remove on the bun
        //if there is an empty bun take it
        //if there is not do nothing;
    }
}
