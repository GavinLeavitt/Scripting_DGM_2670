﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PositionData : ScriptableObject
{
    public Vector3 positionVector = new Vector3(0,0,0);

    public void UpdateYPosition(float newY)
    {
        positionVector.y += newY;
    }

    public void SetYPosition(float setY)
    {
        positionVector.y = setY;
    }

    public void SetPositionToObj(Transform transformObj)
    {
        positionVector = transformObj.position;
    }
}