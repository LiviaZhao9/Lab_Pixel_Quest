using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPPouringArea : MonoBehaviour
{
    public FPCupPickup cupPickup;
    private Transform pouringPoint;

    private void Start()
    {
       pouringPoint = transform.Find("PouringPoint");
    }
    private void OnMouseDown()
    {
        
        if (cupPickup.hasCup)
        {
            cupPickup.currentCup.transform.position = pouringPoint.position;
            cupPickup.hasCup = false;
        }
    }
}
