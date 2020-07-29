using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformNewScene : MonoBehaviour
{
    CollisionNewScene gm;

    public int nextLevel;

    private void OnTriggerEnter2D(Collider2D col)
    {
        gm.LoadNextLevel(nextLevel);
    }

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<CollisionNewScene>();
    }

}
