using BindingOfRounds.Assets;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions;

namespace BindingOfRounds.MonoBehaviors
{
    internal class GuppysCollarBehavior : MonoBehaviour
    {
        private Player player;
        private HealthHandler health;

        private void Start()
        {
            player = GetComponent<Player>();
            health = GetComponent<HealthHandler>();
        }

        private void Update()
        {
        }

        private void OnDestroy()
        {
            
        }
    }
}
