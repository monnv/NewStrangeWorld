using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShow : MonoBehaviour
{
    public GameObject choice;
    // Start is called before the first frame update
    void Start()
    {
        choice.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
            if (player.tag == "Player")
            {
                choice.SetActive(true);
            }
        }
    }
    

