using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapController : MonoBehaviour
{
    public TileBase tile;
    public int height;
    public int width;
    Vector3Int position = new Vector3Int(0, 0, 0);

    void Start()
    {
        // Creamos objeto vacio
        GameObject grid = new GameObject();
        grid.name = "Grid";

        // Le agregamos un objeto de la clase Grid
        grid.AddComponent<Grid>();
        Grid isometricGrid = grid.GetComponent<Grid>();
        isometricGrid.cellLayout = GridLayout.CellLayout.Isometric;
        isometricGrid.cellSize = new Vector3(1, 0.5f, 1);

        // Creamos el hijo
        GameObject tilemap = new GameObject();
        tilemap.name = "Tilemap";

        // Le agregamos sus objetos al gameobject tilemap
        tilemap.AddComponent<Tilemap>();
        tilemap.AddComponent<TilemapRenderer>();
        TilemapRenderer tilemapRenderer = tilemap.GetComponent<TilemapRenderer>();
        tilemapRenderer.sortOrder = TilemapRenderer.SortOrder.TopRight;

        // Asignarle a tilemap el padre que es grid
        tilemap.transform.parent = grid.transform;

        Tilemap map = tilemap.GetComponent<Tilemap>();
        //map.SetTile(position, tile);


        //Rectangle(map);
        //Triangle(map);
        //Circle(map);
        //Line(map);
        //Arrow(map);
        Sword(map);
    }

    public void Rectangle(Tilemap tilemap)
    {
        Map map = new Map();
        List<Vector3Int> coordenadas = map.GetOriginRectangle(height, width);

        map.Paint(coordenadas, tile, tilemap);
    }

    public void Triangle(Tilemap tilemap)
    {
        Map map = new Map();
        List<Vector3Int> coordenadas = map.GetOriginTriangle(height, width);

        map.Paint(coordenadas, tile, tilemap);
    }

    public void Circle(Tilemap tilemap)
    {
        Map map = new Map();
        List<Vector3Int> coordenadas = map.GetOriginCircle(height, width);

        map.Paint(coordenadas, tile, tilemap);
    }

    public void Line(Tilemap tilemap)
    {
        Map map = new Map();
        List<Vector3Int> coordenadas = map.GetOriginLine(height, width);

        map.Paint(coordenadas, tile, tilemap);
    }

    public void Arrow(Tilemap tilemap)
    {
        Map map = new Map();
        List<Vector3Int> coordenadas = map.GetOriginArrow(height, width);

        map.Paint(coordenadas, tile, tilemap);
    }

    public void Sword(Tilemap tilemap)
    {
        Map map = new Map();
        List<Vector3Int> coordenadas = map.GetOriginSword(height, width);

        map.Paint(coordenadas, tile, tilemap);
    }
}
