using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				other.gameObject.GetComponent<Transform>().position = GameObject.FindGameObjectWithTag("SpawnZone").GetComponent<Transform>().position;
               // Application.LoadLevel(Application.loadedLevelName);
            }
        }
    }
}
