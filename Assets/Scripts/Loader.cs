using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject gameManager;

    // Start is called before the first frame update
    void Awake()
    {
        if (GameManager.instance == null)
        {
            Debug.Log("Loader: GameManager.instance is null");

            Instantiate(gameManager);
        }
    }
}
