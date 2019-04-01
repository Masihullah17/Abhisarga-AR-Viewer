using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public static int enemiesLeft = 6;
    Text enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        enemies.text = "Enemies Left : " + enemiesLeft;
    }
}
