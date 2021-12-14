using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int Score = 0;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = Score.ToString();
    }

}
