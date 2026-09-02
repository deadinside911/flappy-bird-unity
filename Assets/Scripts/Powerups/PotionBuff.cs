using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/Potion")]
public class PotionBuff : PowerupEffect
{
    public float strength;

    public override void Apply(GameObject target)
    {
        target.GetComponent<BirdController>().flapStrength += strength;
    }
}
