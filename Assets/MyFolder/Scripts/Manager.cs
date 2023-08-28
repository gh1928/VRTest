using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject oiled;
    public GameObject origin;
    
    public MeshRenderer planeRenderer;

    public Material oiledMaterial;
    public Material originMaterial;

    public Transform playerTransform;

    public Transform groundPivot;
    public Transform skyPivot;
    bool atGround = true;

    bool oiledPlain = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            oiled.SetActive(!oiled.activeSelf);
            origin.SetActive(!origin.activeSelf);

            oiledPlain = !oiledPlain;
            planeRenderer.material = oiledPlain ? oiledMaterial : originMaterial;

        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            atGround = !atGround;
            playerTransform.position = atGround ? groundPivot.position : skyPivot.position;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
