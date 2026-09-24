using UnityEngine;

public class OrcScript : EnemyBase
{
    public void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Orc is attacking the player.");
    }
}
