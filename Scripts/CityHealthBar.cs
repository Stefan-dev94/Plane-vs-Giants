using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityHealthBar : MonoBehaviour
{
    [SerializeField] private GameObject CityDeathPanel;
    [SerializeField] private GameObject _plane;
    [SerializeField ]public float MaxHealth = 100f;
   
    public static float Health;
    private Image _healthBar;
  
    
    private void Start()
    {
        _healthBar = GetComponent<Image>();
        Health = MaxHealth;
        CityDeathPanel.SetActive(false);
    }
    private void Update()
    {
        _healthBar.fillAmount = Health / MaxHealth;
        if(Health <= 0)
        {
            CityDeathPanel.SetActive(true);
            _plane.SetActive(false);
        }
    }


}
