using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName;

    void Start()
    {
        //Player player1 = new Player();
        //Player player2 = new Player("Carl");

        //print(player1.name);
        //print(player2.name);

        Player player = new Player(playerName);

        player.health = 10;
        player.DecreaseHealth(5);

        print(player.name);
        print(player.health);
    }
}
