using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void SetValue(float number)
    {
        value = number;
    }

    public void UpdateValue(float number)
    {
        value += number;
    }
}
