using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileText : MonoBehaviour
{
    public static int MissileCount = 2;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
        MissileCount = 2;
    }

    private void Update()
    {
        _text.text = MissileCount.ToString();
    }
}
