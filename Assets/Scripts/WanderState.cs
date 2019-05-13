using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : BaseState
{
    private Drone _drone;
    public WanderState(Drone drone) : base(drone)
    {
        _drone = drone;
    }
}
