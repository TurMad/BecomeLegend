using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
     float scrollSpeed = 0.1f;
    [SerializeField] float speed = 0.1f;
    Material material;
    Vector2 offset;
    [SerializeField] Material[] materials;
    Vector2 currentOffset;
    private void Start()
    {
        gameObject.GetComponent<MeshRenderer>().material = materials[0];
        material = GetComponent<MeshRenderer>().material;
       
    }
    void Update()
    {
        offset = new Vector2(scrollSpeed, 0);
        currentOffset = material.mainTextureOffset += offset * Time.deltaTime;

    }

    public void UpdateMaterial(int matIndex)
    {
        gameObject.GetComponent<MeshRenderer>().material = materials[matIndex];
        material = GetComponent<MeshRenderer>().material;
        material.mainTextureOffset = currentOffset;
        FindObjectOfType<Music>().UpdateAudio(matIndex);
    }

    public void StopScrolling()
    {
        scrollSpeed = 0;
    }

    public void ContScrolling()
    {
        scrollSpeed = speed;
    }
}
