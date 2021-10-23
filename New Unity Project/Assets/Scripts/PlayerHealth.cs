using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public Image[] allHeartSprites;
    int currentHealth;

    Image[] activeHearts;

    public static PlayerHealth instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }
    private void Update()
    {
        activeHearts = GetComponentsInChildren<Image>();
        currentHealth = activeHearts.Length;
    }
    GameObject prevAdder;
    public void AddHeart(GameObject collisionObject)
    {
        if (collisionObject == prevAdder)
            return;
        if (currentHealth == maxHealth)
            return;

        allHeartSprites[currentHealth].gameObject.SetActive(true);
        prevAdder = collisionObject;
    }
    GameObject prevRemover;
    public void RemoveHeart(GameObject collisionObject)
    {
        if (collisionObject == prevRemover)
            return;
        if (currentHealth - 1 < 0)
            return;

        allHeartSprites[currentHealth - 1].gameObject.SetActive(false);
        prevRemover = collisionObject;
    }
    public void MakeFull()
    {
        foreach (var item in allHeartSprites)
        {
            item.gameObject.SetActive(true);
        }
    }
}
