using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public SlotScript[] unlockSlots;

    public void upgrade()
    {
        for(int i = 0; i < unlockSlots.Length; i++) {
            unlockSlots[i].gameObject.SetActive(true);
        
        }
      Destroy(gameObject);
        
    }
}
