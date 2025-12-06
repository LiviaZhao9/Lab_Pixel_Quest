using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCupPickup : MonoBehaviour
{
    public GameObject currentCup;
    public GameObject cupPrefab;
    public Transform Player;
    public bool hasCup = false;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Debug.Log("hi");
        if (hasCup == false)
        {
            currentCup = Instantiate(cupPrefab, Player.position, Quaternion.identity);
            currentCup.transform.SetParent(Player);
            hasCup = true;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
