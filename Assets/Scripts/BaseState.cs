using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public abstract class BaseState
{
    public BaseState(GameObject gameObject)
    {
        this.GameObject = gameObject;
        this.Transform = gameObject.transform;
    }

    protected GameObject GameObject;
    protected Transform Transform;
    public abstract Type Tick();


}
