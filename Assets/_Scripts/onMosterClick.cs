using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onMosterClick : MonoBehaviour {

	public int expCount = 0;
    public int diamCount = 0;
    public int diamReward = 1;
    public int diamRewardRate = 1;
    public int expReward = 1;
    public int expRewardRate = 1;
    public int weaponCost = 50;
    public int companionCost = 1000;
    public int monsterCost = 120;
    public int swordSpriteNumber = 1;
    public int swordSpriteNumberCurrent = 0;
    public int companionSpriteNumber = 1;
    public int companionSpriteNumberCurrent = 0;
    public int adsExp = 150;
    public int adsDiam = 1000;
    public int OneNumber = 1;

    public GameObject shopPanel;
    public GameObject NOMsword;
    public GameObject NOMcomp;
    public GameObject MAXsword;
    public GameObject MAXcomp;
    public GameObject helpPanel;
    public GameObject mainScene;
    public GameObject secPanel;

    public Text expAds;
    public Text diamAds;
    public Text expCountText;
    public Text diamCountText;
    public Text weaponCostText;
    public Text companionCostText;
    public Text monsterCostText;

    public Image swordSprite;
    public Image swordSpriteCurrent;
    public Image backgroundmain;
    public Image companionSprite;
    public Image companionSpriteCurrent;

    public Sprite cats;
    public Sprite dogs;
    public Sprite dude;
    public Sprite knight;
    public Sprite swblue1;
    public Sprite swblue2;
    public Sprite swblue3;
    public Sprite swblue4;
    public Sprite swred1;
    public Sprite swred2;
    public Sprite swred3;
    public Sprite swred4;
    public Sprite swgreen1;
    public Sprite swgreen2;
    public Sprite swgreen3;
    public Sprite swgreen4;
    public Sprite swyellow1;
    public Sprite swyellow2;
    public Sprite swyellow3;
    public Sprite swyellow4;
    public Sprite daybacksprite;
    public Sprite nightbacksprite;
    public Sprite hellbacksprite;

    public void shopPanel_ShowAndHide()
    {
        shopPanel.SetActive(!shopPanel.activeSelf);
        mainScene.SetActive(!mainScene.activeSelf);
    }

    public void NOMsword_ShowAndHide()
    {
        NOMsword.SetActive(!NOMsword.activeSelf);
    }

    public void MAXsword_ShowAndHide()
    {
        MAXsword.SetActive(!MAXsword.activeSelf);
    }

    public void NOMcomp_ShowAndHide()
    {
        NOMcomp.SetActive(!NOMcomp.activeSelf);
    }

    public void MAXcomp_ShowAndHide()
    {
        MAXcomp.SetActive(!MAXcomp.activeSelf);
    }

    public void Start()
    {
        
    }

    public void Update()
    {
        companionSpriteCurrent = GetComponent<Image>();
        if (companionSpriteNumberCurrent == 1)
            companionSpriteCurrent.sprite = cats;
        else if (companionSpriteNumberCurrent == 2)
            companionSpriteCurrent.sprite = dogs;
        else if (companionSpriteNumberCurrent == 3)
            companionSpriteCurrent.sprite = dude;
        else if (companionSpriteNumberCurrent == 4)
            companionSpriteCurrent.sprite = knight;

        adsExp = companionCost / 10 + monsterCost / 10 + weaponCost / 10;
        adsDiam = companionCost / 9 + monsterCost / 9 + weaponCost / 9;

        backgroundmain = GetComponent<Image>();
        backgroundmain.sprite = daybacksprite;

        companionSprite = GetComponent<Image>();
        if (companionSpriteNumber == 1)
            companionSprite.sprite = cats;
        else if (companionSpriteNumber == 2)
            companionSprite.sprite = dogs;
        else if (companionSpriteNumber == 3)
            companionSprite.sprite = dude;
        else if (companionSpriteNumber == 4)
            companionSprite.sprite = knight;

        swordSprite = GetComponent<Image>();
        if      (swordSpriteNumber == 1)
            swordSprite.sprite = swgreen1;
        else if (swordSpriteNumber == 2)
            swordSprite.sprite = swblue1;
        else if (swordSpriteNumber == 3)
            swordSprite.sprite = swred1;
        else if (swordSpriteNumber == 4)
            swordSprite.sprite = swyellow1;
        else if (swordSpriteNumber == 5)
            swordSprite.sprite = swgreen2;
        else if (swordSpriteNumber == 6)
            swordSprite.sprite = swblue2;
        else if (swordSpriteNumber == 7)
            swordSprite.sprite = swred2;
        else if (swordSpriteNumber == 8)
            swordSprite.sprite = swyellow2;
        else if (swordSpriteNumber == 9)
            swordSprite.sprite = swgreen3;
        else if (swordSpriteNumber == 10)
            swordSprite.sprite = swblue3;
        else if (swordSpriteNumber == 11)
            swordSprite.sprite = swred3;
        else if (swordSpriteNumber == 12)
            swordSprite.sprite = swyellow3;
        else if (swordSpriteNumber == 13)
            swordSprite.sprite = swgreen4;
        else if (swordSpriteNumber == 14)
            swordSprite.sprite = swblue4;
        else if (swordSpriteNumber == 15)
            swordSprite.sprite = swred4;
        else if (swordSpriteNumber == 16)
            swordSprite.sprite = swyellow4;

        swordSpriteCurrent = GetComponent<Image>();
        if (swordSpriteNumberCurrent == 1)
            swordSpriteCurrent.sprite = swgreen1;
        else if (swordSpriteNumberCurrent == 2)
            swordSpriteCurrent.sprite = swblue1;
        else if (swordSpriteNumberCurrent == 3)
            swordSpriteCurrent.sprite = swred1;
        else if (swordSpriteNumberCurrent == 4)
            swordSpriteCurrent.sprite = swyellow1;
        else if (swordSpriteNumberCurrent == 5)
            swordSpriteCurrent.sprite = swgreen2;
        else if (swordSpriteNumberCurrent == 6)
            swordSpriteCurrent.sprite = swblue2;
        else if (swordSpriteNumberCurrent == 7)
            swordSpriteCurrent.sprite = swred2;
        else if (swordSpriteNumberCurrent == 8)
            swordSpriteCurrent.sprite = swyellow2;
        else if (swordSpriteNumberCurrent == 9)
            swordSpriteCurrent.sprite = swgreen3;
        else if (swordSpriteNumberCurrent == 10)
            swordSpriteCurrent.sprite = swblue3;
        else if (swordSpriteNumberCurrent == 11)
            swordSpriteCurrent.sprite = swred3;
        else if (swordSpriteNumberCurrent == 12)
            swordSpriteCurrent.sprite = swyellow3;
        else if (swordSpriteNumberCurrent == 13)
            swordSpriteCurrent.sprite = swgreen4;
        else if (swordSpriteNumberCurrent == 14)
            swordSpriteCurrent.sprite = swblue4;
        else if (swordSpriteNumberCurrent == 15)
            swordSpriteCurrent.sprite = swred4;
        else if (swordSpriteNumberCurrent == 16)
            swordSpriteCurrent.sprite = swyellow4;
    }

    public void weaponUpgrade()
    {
        if (diamCount >= weaponCost && swordSpriteNumber < 17)
            diamReward = diamReward * 2;
        weaponCost = weaponCost * 2 + weaponCost / 2 + weaponCost / 4;
        swordSpriteNumber = swordSpriteNumber + OneNumber;
        swordSpriteNumberCurrent = swordSpriteNumberCurrent + OneNumber;  
        if (diamCount < weaponCost)
            NOMsword.SetActive(NOMsword.activeSelf);
        if (swordSpriteNumber == 16)
            MAXsword.SetActive(MAXsword.activeSelf);

        swordSprite = GetComponent<Image>();
        if (swordSpriteNumber == 1)
            swordSprite.sprite = swgreen1;
        else if (swordSpriteNumber == 2)
            swordSprite.sprite = swblue1;
        else if (swordSpriteNumber == 3)
            swordSprite.sprite = swred1;
        else if (swordSpriteNumber == 4)
            swordSprite.sprite = swyellow1;
        else if (swordSpriteNumber == 5)
            swordSprite.sprite = swgreen2;
        else if (swordSpriteNumber == 6)
            swordSprite.sprite = swblue2;
        else if (swordSpriteNumber == 7)
            swordSprite.sprite = swred2;
        else if (swordSpriteNumber == 8)
            swordSprite.sprite = swyellow2;
        else if (swordSpriteNumber == 9)
            swordSprite.sprite = swgreen3;
        else if (swordSpriteNumber == 10)
            swordSprite.sprite = swblue3;
        else if (swordSpriteNumber == 11)
            swordSprite.sprite = swred3;
        else if (swordSpriteNumber == 12)
            swordSprite.sprite = swyellow3;
        else if (swordSpriteNumber == 13)
            swordSprite.sprite = swgreen4;
        else if (swordSpriteNumber == 14)
            swordSprite.sprite = swblue4;
        else if (swordSpriteNumber == 15)
            swordSprite.sprite = swred4;
        else if (swordSpriteNumber == 16)
            swordSprite.sprite = swyellow4;
    }

    public void purchaseCompanion()
    {
        if (diamCount >= companionCost && companionSpriteNumber < 5)
            diamRewardRate = diamRewardRate + OneNumber;
        companionCost = companionCost * 2 + companionCost / 2 + companionCost / 4 + companionCost / 8;
        companionSpriteNumber = companionSpriteNumber + OneNumber;
        companionSpriteNumberCurrent = companionSpriteNumberCurrent + OneNumber;
        if (diamCount < companionCost)
            NOMcomp.SetActive(NOMcomp.activeSelf);
        if (companionSpriteNumber == 5)
            MAXcomp.SetActive(MAXcomp.activeSelf);
    }      

    public void OnClick()
    {
        expCount = expCount + expReward*expRewardRate;
        diamCount = diamCount + diamReward*diamRewardRate;
        expCountText.text = expCount + "";
        diamCountText.text = diamCount + "";        
    }

    public void watchAdd()
    {
        expCount = expCount + adsExp;
        diamCount = diamCount + adsDiam;

    }
}
