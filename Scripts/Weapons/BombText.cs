using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombText : MonoBehaviour
{
    public static int BombCount = 2;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        BombCount = 2;
    }

    private void Update()
    {
        _text.text = BombCount.ToString();
    }
}
