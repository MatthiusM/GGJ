using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CreateTileMap : MonoBehaviour
{
    [Header("Tiles")]
    public List<Tile> floorTiles;
    public List<Tile> groundTiles;
    public List<Tile> skyTiles;

    public Tilemap tileMap;

    private readonly int floorY = 4;
    // Start is called before the first frame update
    void Start()
    {
        int map = PickRandomTile(ref floorTiles);
        for (int i = -11; i < 11; i++)
        {
            //grass top
            tileMap.SetTile(new Vector3Int(i, floorY, 0), floorTiles[map]);
            //floor
            for (int j = floorY - 1; j > -1*(floorY+3); j--)
            {
                tileMap.SetTile(new Vector3Int(i, j, 0), groundTiles[map]);
            }
            //sky
            for (int j = floorY + 1; j < (floorY + 100); j++)
            {
                //Debug.Log(j);
                tileMap.SetTile(new Vector3Int(i, j, 0), skyTiles[PickRandomTile(ref skyTiles)]);
            }
        }

        Camera.main.transform.position += new Vector3(0, 99, 0);
    }

    int PickRandomTile(ref List<Tile> t) 
    {
        return Random.Range(0, t.Count);
    }

    


}
