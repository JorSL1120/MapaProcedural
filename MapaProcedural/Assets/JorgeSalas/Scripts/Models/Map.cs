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

    public List<Vector3Int> GetOriginTriangle(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();

        for (int x = 0; x <= width; x++)
        {
            height -= 1;
            for (int y = 0; y <= height; y++)
            {
                coordenadas.Add(new Vector3Int(x, y, 0));
            }
        }
        return coordenadas;
    }

    public List<Vector3Int> GetOriginCircle(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                coordenadas.Add(new Vector3Int(x, y, 0));
            }
        }
        coordenadas.Remove(new Vector3Int(0, 0, 0));
        coordenadas.Remove(new Vector3Int(0, height - 1, 0));
        coordenadas.Remove(new Vector3Int(width - 1, 0, 0));
        coordenadas.Remove(new Vector3Int(width - 1, height - 1, 0));
        return coordenadas;
    }

    public List<Vector3Int> GetOriginLine(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();

        for (int x = 0; x <= width; x++)
        {
            for (int y = 0; y <= height; y++)
            {
                if(x == y) coordenadas.Add(new Vector3Int(x, y, 0));
            }
        }
        return coordenadas;
    }

    public List<Vector3Int> GetOriginArrow(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();

        for (int x = 0; x <= width; x++)
        {
            for (int y = 0; y <= height; y++)
            {
                if ((x == y) || (x == 0 && y == 1) || (x == 0 && y == 2) || (x == 1 && y == 0) || (x == 2 && y == 0)) coordenadas.Add(new Vector3Int(x, y, 0));
            }
        }
        return coordenadas;
    }

    public List<Vector3Int> GetOriginSword(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();

        for (int x = 0; x <= width; x++)
        {
            for (int y = 0; y <= height; y++)
            {
                if ((x == y) || (x == 0 && y == 3) || (x == 3 && y == 0) || (x == 2 && y == 1) || (x == 1 && y == 2)) coordenadas.Add(new Vector3Int(x, y, 0));
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
