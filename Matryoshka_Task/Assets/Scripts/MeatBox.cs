using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MeatBox : MonoBehaviour
{
    [SerializeField] GameObject rawMeatPrefab;
    [SerializeField] List<Transform> rawMeatPoints;

    private void Awake()//to make the toggle always true at the beginning
    {
        foreach (Transform point in rawMeatPoints)
        {
            point.GetComponent<MeatPoint>().isEmpty = true;
        }
    }

    private void OnMouseDown()
    {
        //look for a place
        GameObject place= LookForAPlace();
        if (place!=null)
        {
            GameObject meat = Instantiate(rawMeatPrefab, place.transform.position, place.transform.rotation);
            place.GetComponent<MeatPoint>().isEmpty = false;
            //start cook
        }
    }

    private GameObject LookForAPlace()
    {
        foreach (Transform point in rawMeatPoints)
        {
            if (point.GetComponent<MeatPoint>().isEmpty==true)
            {
                return point.gameObject;
            }
            Debug.Log(point.GetComponent<MeatPoint>().isEmpty+"  isempty");
        }

        return null;
    }
}
