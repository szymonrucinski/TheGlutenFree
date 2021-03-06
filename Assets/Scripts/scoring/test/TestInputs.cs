﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ReSharper disable once CheckNamespace
public class TestInputs : MonoBehaviour
{
    private ScoreAction controller;

    // Start is called before the first frame update
    void Start()
    {
        controller =  ScoreController.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Instance.currentGameState == GameState.InGame)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                var isOnShoppingList = Input.GetKey(KeyCode.LeftShift);
                controller.scoreAction(true, isOnShoppingList,
                    new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 10));
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                controller.scoreAction(false, false, new Vector3(Random.Range(0, 15), Random.Range(0, 15), 10));
            }

            if (Input.GetKeyDown(KeyCode.Minus))
            {
                TimerImpl.Instance.addTime(-1.0f);
            }
        }
    }
}
