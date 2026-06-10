using BindingOfRounds.Assets;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Assertions;

namespace BindingOfRounds.MonoBehaviors
{
    internal class BobsBrainBehavior : MonoBehaviour
    {
        private Player player;
        private GameObject brain;

        private void Start()
        {
            player = GetComponent<Player>();

            //brain = GameObject.Instantiate(
            //    AssetManager.BrainPrefab,
            //    player.transform.position,
            //    Quaternion.identity
            //);
        }

        private void Update()
        {
            if (brain == null) return;

            // Float around player
            float t = Time.time;

            Vector3 offset = new Vector3(
                Mathf.Cos(t * 2f),
                Mathf.Sin(t * 2f),
                0
            ) * 2f;

            brain.transform.position = player.transform.position + offset;
        }

        private void OnDestroy()
        {
            if (brain != null)
                Destroy(brain);
        }
    }
}
