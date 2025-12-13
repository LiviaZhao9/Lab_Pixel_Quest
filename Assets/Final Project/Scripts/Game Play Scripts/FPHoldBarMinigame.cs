using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPHoldBarMinigame : MonoBehaviour
{

    private float[] checkpointValues = { 0f, 0.25f, 0.5f, 0.75f, 1f };
    public int ingredientStat;

    public Slider barSlider;
    public float moveSpeed = 0.2f;
    private int i = 0;

    public bool gameActive = false;
    private bool audioPlaying = false;

    public Transform Player;
    private FPAudioManager audioManager;

    private void Start()
    {
        gameObject.SetActive(false);
        audioManager = GameObject.Find("SFXManager").GetComponent<FPAudioManager>();
    }
    private void OnEnable()
    {
        barSlider.value = 0f;
        gameActive = false;
 
    }

    private void Update()
    {

        if (!gameActive && Input.GetKeyDown(KeyCode.Space))
        {
            ingredientStat = 0;
            gameActive = true;
            gameObject.SetActive(true);

            if (!audioPlaying)
            {
                audioManager.PlayAudio("drink");
                audioPlaying = true;
            }
        }


        if (i < checkpointValues.Length - 1 && barSlider.value + 0.075 >= checkpointValues[i + 1])
        {
            i++;
            ingredientStat = i; 
        }


        if (gameActive && Input.GetKeyUp(KeyCode.Space) || Player.transform.childCount >= 1)
        {
            StopMinigame();
            return;
        }

        // Minigame only runs while holding SPACE
        if (gameActive && Input.GetKey(KeyCode.Space))
        {
            barSlider.value += moveSpeed * Time.deltaTime;

            if (barSlider.value >= 1f)
            {
                StopMinigame();
                
            }
        }

    }
    private void StopMinigame()
    {
        i = 0;
        gameObject.SetActive(false);

        if(audioPlaying)
        {
            audioManager.Stop();
            audioPlaying = false;
        }
    }
}
