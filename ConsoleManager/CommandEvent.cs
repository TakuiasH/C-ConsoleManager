using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandEvent {

    public static void OnCommand(string[] args, string cmd)
    {
        if (EqualsIgnoreCase(cmd, "ping"))
        {
            Debug.Log("pong!");
        }
        else
        {
            Debug.LogError("[Error] Comando desconhecido.");
        }
    }


    static bool EqualsIgnoreCase(string arg1, string arg2){return arg1.ToLower().Equals(arg2.ToLower());}
}
