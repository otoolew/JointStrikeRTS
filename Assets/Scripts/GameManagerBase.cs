using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base game manager
/// </summary>
public abstract class GameManagerBase<TGameManager>
{
    /// <summary>
    /// Load data
    /// </summary>
    protected void Awake()
    {
           
    }

    /// <summary>
    /// Initialize volumes. We cannot change mixer params on awake
    /// </summary>
    protected virtual void Start()
    {
        
    }
}