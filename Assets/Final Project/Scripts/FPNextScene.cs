using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPNextScene : MonoBehaviour
{
    public List<string> sceneList;
    public static int currentSceneIndex = 0;

    private FPAudioManager audioManager;
    // Start is called before the first frame update
    private void Start()
    {
        audioManager = GameObject.Find("SFXManager").GetComponent<FPAudioManager>();
    }
    private void OnMouseDown()
    {
        audioManager.PlayAudio("serve");
        GameObject orderObj = GameObject.FindGameObjectWithTag("OrderData");
        if (orderObj != null)
        {
            FPOrderData orderData = orderObj.GetComponent<FPOrderData>();
            if (orderData != null)
            {

                orderData.CheckScore();
 
            }
        }

        SceneManager.LoadScene(sceneList[currentSceneIndex]);

        currentSceneIndex++;
        if (currentSceneIndex >= sceneList.Count)
            currentSceneIndex = 0; 

    }
}
