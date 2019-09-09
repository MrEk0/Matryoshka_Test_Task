using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatBox : MonoBehaviour
{
    [SerializeField] GameObject rawMeatPrefab;
    [SerializeField] Transform[] rawMeatPoints;

    //private bool isPlaceEmpty = true;
    //private int pointsCount = 3;

    private void OnMouseDown()
    {
        //look for a place
        GameObject place= LookForAPlace();
        //Debug.Log(place);
        if (place!=null)
        {
            GameObject meat= Instantiate(rawMeatPrefab, place.transform.position, place.transform.rotation);
            place.GetComponent<MeatPoint>().isEmpty=false;
            //start cook
        }
    }

    private GameObject LookForAPlace()
    {
        foreach (Transform point in rawMeatPoints)
        {
            if(point.gameObject.GetComponent<MeatPoint>().isEmpty==true)
            {
                return point.gameObject;
            }
        }

        return null;
    }
}
