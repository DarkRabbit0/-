﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodEffect : MonoBehaviour
{
    public float timeToDestory;//持续时间后消失
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeToDestory);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}