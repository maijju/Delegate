using UnityEngine;
using TMPro;

public class LevelSystem : MonoBehaviour
{   
    int currentLevel = 1;
    public TextMeshProUGUI levelText;
    float xpToLevelUp = 250;

    XpSystem xpSystem;

    void Start()
    {
        xpSystem = GetComponent<XpSystem>();
        currentLevel = SomeComplexWayToCaluateLevel();
        if (xpSystem != null)
        {
            xpSystem.onGainedXp += UpdateLevel;
        }
    }

    void UpdateLevel()
    {
        int newLevel = SomeComplexWayToCaluateLevel();
        if (newLevel > currentLevel)
        {
            currentLevel = newLevel;
            levelText.text = currentLevel.ToString();
            print("Leveled Up!");
        }
    }

    int SomeComplexWayToCaluateLevel()
    {
        print("I'm Calculating!");
        int level = currentLevel;

        if (xpSystem.GetXp() >= xpToLevelUp)
        {
            xpSystem.InitXp();
            level+=1;
        }
        return level;
    }
}