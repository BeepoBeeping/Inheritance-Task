using UnityEngine;

public class DragonScript : EnemyBase
{

    public void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Dragon is attacking the player.");
    }
}
