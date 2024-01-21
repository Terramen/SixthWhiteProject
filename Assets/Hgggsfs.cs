using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hgggsfs : MonoBehaviour
{
    public int gridSizeX = 5;
    public int gridSizeY = 5;
    public float spacing = 1.5f;

    private void Start()
    {
        GenerateCubeGrid();
    }

    private void GenerateCubeGrid()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector3 position = new Vector3(x * spacing, 0f, y * spacing);
                Quaternion rotation = Quaternion.identity;

                GameObject cube = CreateRandomColoredCube(position, rotation);
                AddClickHandler(cube);
            }
        }
    }

    private GameObject CreateRandomColoredCube(Vector3 position, Quaternion rotation)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = position;
        cube.transform.rotation = rotation;

        Renderer renderer = cube.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Random.ColorHSV();
        }

        return cube;
    }

    private void AddClickHandler(GameObject cube)
    {
        ClickableCube clickableCube = cube.AddComponent<ClickableCube>();
        clickableCube.OnCubeClicked += ChangeCubeColor;
    }

    private void ChangeCubeColor(ClickableCube clickedCube)
    {
        Renderer renderer = clickedCube.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Random.ColorHSV();
        }
    }
}

public class ClickableCube : MonoBehaviour
{
    public delegate void CubeClickedEventHandler(ClickableCube clickedCube);
    public event CubeClickedEventHandler OnCubeClicked;

    private void OnMouseDown()
    {
        OnCubeClicked?.Invoke(this);
    }
}
