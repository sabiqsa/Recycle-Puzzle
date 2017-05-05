﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    float speed = 0.6f;
    public Sprite[] img;

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = img[Random.Range(0, img.Length)];
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, speed * Time.deltaTime * -1f, 0);
        if (transform.position.y < -5f)
        {
            GameObject.Destroy(gameObject);
        }
    }
}