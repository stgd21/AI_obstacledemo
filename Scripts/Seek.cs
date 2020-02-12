﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek
{
    public Kinematic character;
    public Kinematic target;

    private float maxAcceleration = 40f;

    public virtual SteeringOutput GetSteering()
    {
        SteeringOutput result = new SteeringOutput();

        //Get direction to target
        result.linear = target.kPosition - character.kPosition;
        result.linear = result.linear.normalized;
        result.linear *= maxAcceleration;

        result.angular = 0;
        return result;
    }
}
