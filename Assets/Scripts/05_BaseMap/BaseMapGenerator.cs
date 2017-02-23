using UnityEngine;
using System.Collections.Generic;

public class BaseMapGenerator : MonoBehaviour {

	#region Variables
	int mapSizeX = 100;
	int mapSizeY = 100;

	public GameObject tile;
	GameObject mapHolder;
	
	int[,] mapArray;
	int[,] objectArray;
	int[,] objectPerDeploy;

	public GameObject[] mapObjects;

	int totalTiles;

	#region percentages
	float Rock2Percentage = .05f;
	int Rock2Amount;

	float Rock1Percentage = .10f;
	int Rock1Amount;

	float Wood2Percentage = .05f;
	int Wood2Amount;

	float Wood1Percentage = .10f;
	int Wood1Amount;
	#endregion

	#endregion



	#region UnityMethods
	void Start () 
	{
		ConfigureNumbers();
		GenerateMapHolder();
		GenerateMapData();
		GenerateMapVisuals();

		ConfigureObjects();		//Setup the object array
		GenerateRock2();
		GenerateObjects();
	}

	void Update () 
	{
		
	}
	#endregion

	void ConfigureNumbers()
	{
		totalTiles = mapSizeX * mapSizeY;
		Rock2Amount = Mathf.RoundToInt(totalTiles * Rock2Percentage);
		Rock1Amount = Mathf.RoundToInt(totalTiles * Rock1Percentage);
		Wood2Amount = Mathf.RoundToInt(totalTiles * Wood2Percentage);
		Wood1Amount = Mathf.RoundToInt(totalTiles * Wood1Percentage);
	}

	void GenerateMapHolder()
	{
		mapHolder = new GameObject();
		mapHolder.name = "MapHolder";
	}



	void GenerateMapData()
	{
		mapArray = new int[mapSizeX, mapSizeY];
		for (int x = 0; x < mapSizeX; x++)
		{
			for (int y = 0; y < mapSizeY; y++)
			{
				mapArray[x, y] = 1;
			}
		}
	}



	void GenerateMapVisuals()
	{
		for (int x = 0; x < mapSizeX; x++)
		{
			for (int y = 0; y < mapSizeY; y++)
			{
				GameObject tileGO = Instantiate(tile, new Vector2(x, y), transform.rotation, mapHolder.transform);
				tileGO.name = "Tile_" + x + "_" + y;
			}
		}
	}

	void ConfigureObjects()
	{
		objectArray = new int[mapSizeX, mapSizeY];
		objectPerDeploy = new int[mapSizeX, mapSizeY];
		for (int x = 0; x < mapSizeX; x++)
		{
			for (int y = 0; y < mapSizeY; y++)
			{
				objectArray[x,y] = 0;
				objectPerDeploy = 0;
			}
		}
	}

	void GenerateRock2()
	{
		int i = 0;
		while(Rock2Amount > i)
		{
			int x = Random.Range(0, mapSizeX);
			int y = Random.Range(0, mapSizeY);
			if(mapArray[x,y] == 1 && objectArray[x,y] == 0)
			{
				objectArray[x, y] = 1;
				
				i++;
			}
		}
	}

	void GenerateObjects()
	{
		for (int x = 0; x < mapSizeX; x++)
		{
			for (int y = 0; y < mapSizeY; y++)
			{
				if (objectArray[x, y] != 0)
				{
					Instantiate(mapObjects[1], new Vector2(x, y), transform.rotation);
				}
			}
		}
	}
}
