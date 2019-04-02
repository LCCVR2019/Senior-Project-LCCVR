using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : Interactable
{
    public bool mHideOnPickup = true;

    public override void Pressed()
    {
        Pickup();
    }

    private void Pickup()
    {
        PartTracker.Instance.SetCurrentPart(this);

        if (mHideOnPickup) gameObject.SetActive(false);
    }

    public void Return()
    {
        gameObject.SetActive(true);
    }
}
