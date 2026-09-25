using UnityEngine;

public class FriendlyOrcScript : OrcScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public override void AttackPlayer()
    {
        print("Friendly Orc is attacking the player.");
    }

}
