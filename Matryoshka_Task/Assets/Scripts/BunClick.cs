using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunClick : MonoBehaviour
{
    [SerializeField] GameObject bun = null;
    [SerializeField] GameObject meat = null;
    [SerializeField] Transform burgerpoint;

    GameObject buns;

    private void OnMouseDown()
    {
        //look for an empty desk
        //if there is an emty desk we need to take it
        //instantiate
        //if there is not do nothing
        buns=Instantiate(bun, burgerpoint.position, burgerpoint.rotation);
        Debug.Log("Click");
    }

    public void Delete()
    {
        Destroy(buns);
    }

}
