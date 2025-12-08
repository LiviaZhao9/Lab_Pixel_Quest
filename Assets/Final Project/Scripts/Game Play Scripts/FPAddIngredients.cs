using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPAddIngredients : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public Transform MinigamePanel;

    public float updateDuration = 1f;

    private void OnMouseDown()
    {
        string tag = gameObject.tag;
        FPHoldBarMinigame minigame = MinigamePanel.GetComponent<FPHoldBarMinigame>();

        if (Player.transform.childCount >= 1)
        {
            FPCupStats stats = Player.transform.GetChild(0).GetComponent<FPCupStats>();

            switch (tag)
            {
                case "Ice":
                    {
                        if (stats.ice < 2)
                        {
                            stats.ice += 1;

                        }
                        break;
                    }
                case "Coffee":
                    {
                        if (stats.totalIngredients < 4)
                        {
                            if (minigame.ingredientStat > 4 - stats.totalIngredients)
                            {
                                stats.coffee += 4 - stats.totalIngredients;
                                stats.totalIngredients += 4 - stats.totalIngredients;
                            }
                            else
                            {
                                stats.coffee += minigame.ingredientStat;
                                stats.totalIngredients += minigame.ingredientStat;
                            }
                        }
                        break;
                    }

                case "Soda":
                    {
                        if (stats.totalIngredients < 4)
                        {
                            if (minigame.ingredientStat > 4 - stats.totalIngredients)
                            {
                                stats.soda += 4 - stats.totalIngredients;
                                stats.totalIngredients += 4 - stats.totalIngredients;
                            }
                            else
                            {
                                stats.soda += minigame.ingredientStat;
                                stats.totalIngredients += minigame.ingredientStat;
                            }
                        }
                        break;
                    }
            }
        }
    }

}

