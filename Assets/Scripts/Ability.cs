

using System;
using UnityEngine;
using UnityEngine.UI;

public class Ability: MonoBehaviour
{
    public int cooldownRounds { get; } = 0;
    public String abilityName { get; } = "";
    public String abilityExtraInfo { get; } = "";
    public Image hero { get; }
    
    public Text abilityNameText;

    public Text abilityExtraInfoText;

    public Text abilityCounter;
    
    public Image heroIcon;

    public Ability(int cooldownRounds, string abilityName, Image hero, string abilityExtraInfo)
    {
        this.cooldownRounds = cooldownRounds;
        this.abilityName = abilityName;
        this.hero = hero;
        this.abilityExtraInfo = abilityExtraInfo;
    }

    public void init()
    {
        abilityNameText.text = abilityName;
        abilityExtraInfoText.text = abilityExtraInfo;
        abilityCounter.text = cooldownRounds.ToString();
        heroIcon = hero;
    }
}
