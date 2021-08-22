using RPG.Saving;
using UnityEngine;

public class Experience : MonoBehaviour, ISaveable
{
    [SerializeField] float experiencePoints = 0f;

    public void GainExperience(float experience)
    {
        experiencePoints += experience;
    }

    public object CaptureState()
    {
        return experiencePoints;
    }


    public void RestoreState(object state)
    {
        float XP = (float)state;

        experiencePoints = XP;
    }
}