using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoMissileText : MonoBehaviour
{
    public static int AutoMissileCount = 2;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        AutoMissileCount = 2;
    }

    private void Update()
    {
        _text.text = AutoMissileCount.ToString();
    }
}
