using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    // speed of the background moving 
    [SerializeField] private float scrollSpeed = 1.0f;

    // the matrial on the canvas
    private Material myMaterial;
    private Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        // the renderer is in charge, which has the offset
        myMaterial = GetComponent<Renderer>().material;   
        // using the x component 
        offset = new Vector2(scrollSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Time.DeltaTime - makes for uniform movement
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
