using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CreateTileMap : MonoBehaviour
{
    [Header("Tiles")]
    public List<Tile> floorTiles;
    public List<Tile> groundTiles;

    public Tilemap tileMap;

    private readonly int floorY = 4;
    // Start is called before the first frame update
    void Start()
    {
        int map = PickRandomTile(ref floorTiles);
        for (int i = -11; i < 11; i++)
        {
            tileMap.SetTile(new Vector3Int(i, floorY, 0), floorTiles[map]);
            for (int j = floorY - 1; j > -1*(floorY+11); j--)
            {
                tileMap.SetTile(new Vector3Int(i, j, 0), groundTiles[map]);
            }
        }
    }

    int PickRandomTile(ref List<Tile> t) 
    {
        return Random.Range(0, t.Count);
    }

    


}
