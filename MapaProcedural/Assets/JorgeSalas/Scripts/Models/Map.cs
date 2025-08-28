using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Map
{
    public Map()
    {

    }

    public List<Vector3Int> GetOriginRectangle(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();

        for(int x = 0; x <= width; x++)
        {
            for(int y = 0; y <= height; y++)
            {
                coordenadas.Add(new Vector3Int(x, y, 0));
            }
        }
        return coordenadas;
    }

    public void Paint(List<Vector3Int> coordenadas, TileBase tile, Tilemap tilemap)
    {
        for(int i = 0; i < coordenadas.Count; i++)
        {
            tilemap.SetTile(coordenadas[i], tile);
        }
    }
}
