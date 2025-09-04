using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Tilemaps;


public enum MapType {Line, Rectangle, Circle, Triangle}
public class Map
{
    /*
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
    
    public List<Vector3Int> GetOriginRectangle2(int height, int width)
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();
        int area = width * height;

        for (int i = 0; i < area; i++)
        {
            int x = i / width;
            int y = i % height;
            coordenadas.Add(new Vector3Int(x, y, 0));
        }
        return coordenadas;
    }

    public void Paint(List<Vector3Int> coordenadas, TileBase tile, Tilemap tilemap)
    {
        for(int i = 0; i < coordenadas.Count; i++)
        {
            tilemap.SetTile(coordenadas[i], tile);
        }
    }*/

    private MapType _type;
    private Vector2Int _origin;
    private Vector2Int _size;
    private Tilemap _tilemap;

    public Map(Vector2Int origin, Vector2Int size, Tilemap tilemap, MapType type)
    {
        _origin = origin;
        _size = size;
        _tilemap = tilemap;
        _type = type;
    }

    public List<Vector3Int> generateCoordinates()
    {
        List<Vector3Int> coordenadas = new List<Vector3Int>();
        switch (_type)
        {
            case MapType.Line:
                for(int x = _origin.x; x < _size.x; x++)
                {
                    for(int y = _origin.y; y < _size.y; y++)
                    {
                        if(x == y) coordenadas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadas;

            case MapType.Rectangle:
                for (int x = _origin.x; x < _size.x + _origin.x; x++)
                {
                    for (int y = _origin.y; y < _size.y + _origin.y; y++)
                    {
                        coordenadas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadas;

            case MapType.Circle:
                for (int x = _origin.x; x < _size.x + _origin.x; x++)
                {
                    for (int y = _origin.y; y < _size.y + _origin.y; y++)
                    {
                        coordenadas.Add(new Vector3Int(x, y, 0));
                    }
                }
                coordenadas.Remove(new Vector3Int(_origin.x, _origin.y, 0));
                coordenadas.Remove(new Vector3Int(_origin.x, (_size.y + _origin.y - 1), 0));
                coordenadas.Remove(new Vector3Int((_size.x + _origin.x - 1), _origin.y, 0));
                coordenadas.Remove(new Vector3Int((_size.x + _origin.x - 1), (_size.y + _origin.y - 1), 0));
                return coordenadas;

            case MapType.Triangle:
                for (int x = _origin.x; x <= _size.x + _origin.x; x++)
                {
                    _size.y -= 1;
                    for (int y = _origin.y; y <= _size.y + _origin.y; y++)
                    {
                        coordenadas.Add(new Vector3Int(x, y, 0));
                    }
                }
                return coordenadas;
        }
        return coordenadas;
    }

    public void Render(List<Vector3Int> coordenadas, Tile tile, Tilemap tilemap)
    {
        for (int i = 0; i < coordenadas.Count; i++)
        {
            tilemap.SetTile(coordenadas[i], tile);
        }
    }
}
