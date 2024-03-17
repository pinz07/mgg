using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    public List<PlayerProgressLevel> levels;

    public RectTransform experienceValueRectTransform;
    public TextMeshProUGUI lelevelValueTMP;

    private int _levelValue = 1;

    private float _experienceCurrentValue = 0;
    private float _experienceTargetValue = 100;

    public void AddExperience(float value)
    {
        _experienceCurrentValue += value;
        if( _experienceCurrentValue >= _experienceTargetValue )
        {
            SetLevel(_levelValue += 1);
            _experienceCurrentValue = 0;
        }
        DrawUI();
    }

    private void SetLevel(int value)
    {
        _levelValue = value;

        var currentLevel = levels[_levelValue - 1];
        _experienceTargetValue = currentLevel.experienceForTheNextLevel;
        GetComponent<FiribalCas>().damage = currentLevel.fireballDamege;

        var greanadeCaster = GetComponent<GrenadeCaster>();
        greanadeCaster.damage = currentLevel.grenadeDamege;

        if(currentLevel.grenadeDamege < 0)
        {
            greanadeCaster.enabled = false;
        }
        else
        {
            greanadeCaster.enabled = true;
        }
    }

    private void DrawUI()
    {
        experienceValueRectTransform.anchorMax = new Vector2(_experienceCurrentValue / _experienceTargetValue, 1);
        lelevelValueTMP.text = _levelValue.ToString();
    }
    private void Start()
    {
        SetLevel(_levelValue);
        DrawUI();
    }




}
