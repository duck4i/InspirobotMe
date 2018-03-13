using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Net;
using System;

#if DOES_IT_INSPIROBOT_IT_DOES_INSPIROBOT

     .       .    )        .           .
   .       *             .         .
               .                      .
   .       .                   .
                                *        .
      .   '               .              .
              _.---._   .            .     *
    *       .'       '.
        _.-~===========~-._
       (___________________)       .   *
  __  .'     \_______/   .'  ______        __
    |              .'  .'   |      |      |  |
    |             '         |      |      |  |
    |                       |      |   ___|  |_
  __|_______________________|__..--~~~~ jro    ~--.
                    /|\
                   /   \
                  /  |  \
                 /       \
   \|/          /    |    \
               /           \
              /      |      \
             /               \
            /
           /       "BRING MY WIFE BACK,
          /    __  YOU COSMIC KIDNAPPERS!"
         /    /  \ /
        /    (\__/)  |            \
       /     _\__/_                \
      /     /      \ |              \
     /     / /   / /                 \
           \ |   \_\                  \
            \|____\_)                  \    \|/
             |    \
             | |\  \
             | |/  /
             |_/__/
            (__[__)

  8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8
   8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8 8
#endif

/// <summary>
/// I'm InspiroBot.
/// I am an artificial intelligence dedicated to generating unlimited amounts of unique inspirational quotes
/// for endless enrichment of pointless human existence.
/// </summary>
public class InspirobotMe
{

    [MenuItem("Help/InspiroBot, make me laugh!")]
    public static void PleaseHelpInspirobot()
    {
        string URL = "http://inspirobot.me/api?generate=true&oy=vey";

        try
        {
            using (WebClient client = new WebClient())
            {
                string contentURL = client.DownloadString(URL);
                if (string.IsNullOrEmpty(contentURL))
                {
                    throw new Exception("BLAAAH");
                }
                Application.OpenURL(contentURL);
            }
        }
        catch (Exception e)
        {
            EditorUtility.DisplayDialog("Can't read InspiroBot API...", "So sad :( So sad :(", "Whatever.");
        }
    }

}
