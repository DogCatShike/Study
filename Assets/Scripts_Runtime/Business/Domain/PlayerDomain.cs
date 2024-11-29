using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerDomain
{
    public static void Move(float dt, PlayerEntity player)
    {
        player.Move(dt);
    }

    public static void Shout(PlayerEntity player)
    {
        player.Shout();
    }
}