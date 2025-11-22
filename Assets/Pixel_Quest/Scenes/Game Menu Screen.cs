using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class ShakingText : MonoBehaviour
{
    public TMP_Text textMesh;
    public float shakeAmount = 5f;
    public float shakeSpeed = 5f;
    public TMP_FontAsset newfont; 

    private Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        if (textMesh == null)
            textMesh = GetComponent<TMP_Text>();
        originalPos = transform.localPosition;

        if (newfont != null)
            textMesh.font = newfont; 
        
    }

    // Update is called once per frame
    void Update()
    {
        float shake = Mathf.Sin(Time.time * shakeSpeed) * shakeAmount;
        transform.localPosition = originalPos + new Vector3(0, shake, 0); 
        
    }
}
