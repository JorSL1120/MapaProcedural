public class Player
{
    /* Mi intento
     * 
     * int Vida = 10;
    int Mana = 0;

    void VidaActual(int Vida)
    {
        return;
    }

    void RestVida()
    {
        int Damage = 1;
        Vida -= Damage;
    }*/

    public int health;
    public int mana;
    public string name;

    public Player(string name = "player1")
    {
        this.name = name;
    }

    public int ActualHealth()
    {
        return health;
    }

    public void DecreaseHealth(int damage)
    {
        health -= damage;
    }

    public void IncreaseHealth(int heal = 0)
    {
        health += heal;
    }
}
