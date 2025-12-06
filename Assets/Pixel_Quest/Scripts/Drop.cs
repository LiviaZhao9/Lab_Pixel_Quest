using UnityEngine;
using UnityEngine.EventSystems;

public class FPDrop : MonoBehaviour
{
    public bool isInDropZone = false;
    public GameObject Player;


    public void OnMouseEnter()
    {
        isInDropZone = true;

    }

    public void OnMouseExit()
    {
        isInDropZone = false;
    }

    private void OnMouseDown()
    {
        if(isInDropZone && Player.transform.childCount > 0)
        {
            Player.transform.GetChild(0).SetParent(transform);
            transform.GetChild(transform.childCount - 1).localPosition = Vector3.zero;
        }
        else if (isInDropZone && transform.childCount > 0)
        {
            Debug.Log("boo");
            transform.GetChild(0).SetParent(Player.transform);
        }

    }

}

