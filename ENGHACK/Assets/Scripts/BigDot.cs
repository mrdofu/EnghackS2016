﻿using UnityEngine;
using System.Collections;

public class BigDot : MonoBehaviour
{
    /**
     * If pacman eats a big dot, the ghosts become vulnerable, points are awarded, check for remaining dots, and the dot is destroyed
     * @param other - the other object that collided with this
     */
    void OnTriggerEnter(Collider other)
    {
        GameObject pacmanGameObj = GameObject.FindGameObjectWithTag("Pacman");
        if (other.gameObject == pacmanGameObj)
        {
            // TODO: ghosts vulnerable
            // TODO: award points
            // TODO: check for remaining dots
            Destroy(this.gameObject);
        }
    }

}
