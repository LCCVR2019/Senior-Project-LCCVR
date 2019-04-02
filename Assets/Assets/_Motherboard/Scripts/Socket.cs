using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : Interactable
{
    public List<Part> m_TargetParts;
    public Transform m_Fixer;

    public override void Pressed()
    {
        CheckObject();
    }

    private void CheckObject()
    {
        if (!PartTracker.Instance.HasPart()) return;

        bool isCorrect = false;

        foreach(Part part in m_TargetParts)
        {
            if (part.gameObject.GetInstanceID() == PartTracker.Instance.m_CurrentPart.gameObject.GetInstanceID())
            {
                isCorrect = true;
                break;
            }
        }

        if(isCorrect)
        {
            Place();
            Output.Instance.SetCorrect();
        }
        else
        {
            Output.Instance.SetWrong();
        }
    }

    private void Place()
    {
        Part newPart = PartTracker.Instance.m_CurrentPart;

        if (m_Fixer)
        {
            newPart.gameObject.transform.parent = m_Fixer;
            newPart.gameObject.transform.localPosition = Vector3.zero;
            newPart.gameObject.transform.localRotation = Quaternion.identity;
        }

        newPart.gameObject.GetComponent<Collider>().enabled = false;
        GetComponent<Collider>().enabled = false;

        newPart.gameObject.SetActive(true);
        PartTracker.Instance.m_CurrentPart = null;
    }
}
