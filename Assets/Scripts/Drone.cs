using System;
using System.Collections;
using System.Collections.Generic;
using FirstImplementation;
using TMPro;
using UnityEngine;

public class Drone : MonoBehaviour
{
    [SerializeField] private Team _team;
    [SerializeField] private GameObject _laserVisual;

    public Transform Target { get; private set; }

    public Team Team => _team;
    public StateMachine StateMachine => GetComponent<StateMachine>();

    private void Awake()
    {
        InitializeStateMachine();
    }

    private void InitializeStateMachine()
    {
        var states = new Dictionary<Type, BaseState>()
        {
            {typeof(WanderState), new WanderState(this)},
            {typeof(ChaseState), new ChaseState(this)},
            {typeof(AttackState), new AttackState(this)}
        };

        GetComponent<StateMachine>().SetStates(states);
    }

    public void SetTarget(Transform target)
    {
        Target = target;
    }

    public void FireWeapon()
    {
        _laserVisual.transform.position = (Target.position + transform.position) / 2f;

        float distance = Vector3.Distance(Target.position, transform.position);
        //_laserVisual.transform.localScale = new ...
    }

}
