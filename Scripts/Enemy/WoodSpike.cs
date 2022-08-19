using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpike : MonoBehaviour
{
    [SerializeField] private AudioSource _spikeAudio;
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _anim.SetBool("isActive", true);
            _spikeAudio.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _anim.SetBool("isActive", false);
        }
    }
}
