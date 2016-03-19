﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Item_8_ChangeMesh_4 : ItemBase
{
    public static void Itemhandler(object param)
    {
        if (param is Player)
        {
            Player player = param as Player;
            PlayerController control = PlayerController.GetPlayerController(player.gameObject.GetInstanceID());
            if (null != control)
            {
                control.ChangePlayer("Tank_4");
            }
        }
    }
}