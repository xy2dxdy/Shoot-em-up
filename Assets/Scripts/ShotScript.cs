using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public int damage = 1;
    public bool isEnemyShot = false;
    [SerializeField] private int timeDamage = 10;
    private void Start()
    {
        Destroy(gameObject, timeDamage);
    }
}
