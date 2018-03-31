using UnityEngine;

public class CheatParser : MonoBehaviour
{
    string cheatString;
    string[] cheats = { "secret",
                        "abcd",
			"space cheat" };    //Add your cheats here
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            cheatString = cheatString + Input.inputString.ToLower();
            int possibleCheats = 0;
            for (int i = 0; i < cheats.Length; i++)
	    {
	        if (cheats[i].StartsWith(cheatString)) possibleCheats += 1;
		if (i == cheats.Length - 1 && possibleCheats == 0)
		{
		    cheatString = cheatString[cheatString.Length - 1].ToString();
		}
	    }
	    
	    switch(cheatString)
	    {
	        case "secret":
		    Debug.Log("Secret Cheat");
		    cheatString = string.Empty;
		    break;
		case "abcd":
		    Debug.Log("Alphabet Cheat");
		    cheatString = string.Empty;
		    break;
		case "space cheat":
		    Debug.Log("Cheat With Space");
		    cheatString = string.Empty;
		    break;
	    }
        }
    }
}
