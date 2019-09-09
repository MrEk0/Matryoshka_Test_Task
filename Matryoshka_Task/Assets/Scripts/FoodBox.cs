using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class FoodBox : MonoBehaviour
{
    [SerializeField] GameObject FoodPrefab;
    [SerializeField] List<Transform> FoodPoints;

    private void Awake()//to make the toggle always true at the beginning
    {
        foreach (Transform point in FoodPoints)
        {
            point.GetComponent<FoodPoint>().isEmpty = true;
        }
    }

    private void OnMouseDown()
    {
        //look for a place
        GameObject place= LookForAPlace();
        if (place!=null)
        {
            /*GameObject meat = */Instantiate(FoodPrefab, place.transform.position, place.transform.rotation);
            place.GetComponent<FoodPoint>().isEmpty = false;
            //start cook
        }
    }

    private GameObject LookForAPlace()
    {
        foreach (Transform point in FoodPoints)
        {
            if (point.GetComponent<FoodPoint>().isEmpty==true)
            {
                return point.gameObject;
            }
            //Debug.Log(point.GetComponent<MeatPoint>().isEmpty+"  isempty");
        }

        return null;
    }
}
