using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    // Scroll main texture based on time

    public float scrollSpeedX = 0.5f;
    public float scrollSpeedY = 0.5f;
    MeshRenderer rend;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;
        float offsetY = Time.time * scrollSpeedY;
        rend.material.SetTextureOffset("LasagneKolkMaterial", new Vector2(offsetX, offsetY));
    }
}
