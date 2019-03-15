using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTracker : MonoBehaviour
{
    public static PartTracker Instance;

    public Part m_CurrentPart = null;

    private void Awake()
    {
        Instance = this;

        PlayerEvents.OnBack += BackReturn;
    }

    private void OnDestroy()
    {
        PlayerEvents.OnBack -= BackReturn;
    }

    public bool HasPart()
    {
        if (m_CurrentPart) return true;
        else return false;
    }

    public void SetCurrentPart(Part part)
    {
        if (m_CurrentPart != null) m_CurrentPart.Return();
        m_CurrentPart = part;
    }

    private void BackReturn()
    {
        if (m_CurrentPart != null) m_CurrentPart.Return();
        m_CurrentPart = null;
    }
}
