using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class World
{
    private static readonly World instance = new World();
    private static GameObject[] hidingSpots;

    private World() { }

    public static World Instance
    {
        get { return instance; }
    }

    public GameObject[] GetHidingSpots()
    {
        // Procura sempre todos os objetos com a tag "hide" ativos na cena
        if (hidingSpots == null || hidingSpots.Length == 0)
        {
            hidingSpots = GameObject.FindGameObjectsWithTag("hide");
        }
        return hidingSpots;
    }
}