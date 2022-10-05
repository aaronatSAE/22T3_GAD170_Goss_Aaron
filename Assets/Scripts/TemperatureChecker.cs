﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureChecker : MonoBehaviour
{
    [SerializeField] private float currentPorridgeTemperature = 85f;

    private float hotLimitTemperature = 70f;
    private float coldLimitTemperature = 40f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        // These two lines perform the same operations:
        currentPorridgeTemperature -= Time.deltaTime * 5f;
        currentPorridgeTemperature = currentPorridgeTemperature - Time.deltaTime * 5f;
    }

    private void TemperatureTest()
    {
        // if statement syntax:

        // if(CONDITION)
        // {
        //     CODE HERE WILL RUN IF CONDITION IS TRUE
        // }

        if(currentPorridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot! 🥵" + (int)currentPorridgeTemperature);
        }
        else if(currentPorridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porridge is too cold! 🥶");
        }
        else if(currentPorridgeTemperature == 55f)
        {
            Debug.Log("The porridge is exactly 55°C! 💖");
        }
        else
        {
            Debug.Log("The porridge is just right! 😊");
        }
    }
}
