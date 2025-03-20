using System;
using UnityEngine;

public class XpSystem : MonoBehaviour
{
    // Start is called before the first frame update
    float xp = 0;
    float xpGain = 50;

    public event Action onGainedXp;

    public void GainXp()
    {
        xp += xpGain;
        onGainedXp();
    }

    public float GetXp()
    {
        return xp;
    }

    public void InitXp()
    {
        xp = 0;
    }
}
