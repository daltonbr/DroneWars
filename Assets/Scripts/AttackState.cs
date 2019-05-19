using System;
using UnityEngine;

public class AttackState : BaseState
{
    [SerializeField] private float _attackReadyTimer = 2f;
    private Drone _drone;
    private float _attackTimer;

    public AttackState(Drone drone) : base(drone.gameObject)
    {
        _drone = drone;
        _attackTimer = _attackReadyTimer;
    }

    public override Type Tick()
    {
        if (_drone.Target == null)
        {
            return typeof(WanderState);
        }

        _attackTimer -= Time.deltaTime;

        if (_attackTimer <= 0f)
        {
            Debug.Log("Attack");
            _drone.FireWeapon();
            _attackTimer = _attackReadyTimer;
        }

        return null;
    }
}
