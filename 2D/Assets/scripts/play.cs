﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public SpriteRenderer door;
    public Sprite doorOpen;
    public Sprite mySprite;
    private SpriteRenderer toogle;
    // Start is called before the first frame update
    void Start()
    {
        toogle = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            toogle.sprite = mySprite;
            door.sprite = doorOpen;
        }

    }
}
