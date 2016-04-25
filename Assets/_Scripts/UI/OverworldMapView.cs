﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]

public class OverworldMapView : MonoBehaviour 
{
    [SerializeField]
    int _sectorWidth = 4, _sectorHeight = 4;

    [SerializeField]
    Color _bgColor = new Color(0.2f, 0.2f, 0.2f),
        _youAreHereColor = Color.green;


    RawImage _rawImage;
    Texture2D _mapTexture;

    int _sectorsWide, _sectorsHigh;


    public void Init(int sectorsWide, int sectorsHigh)
    {
        _sectorsWide = Mathf.Max(0, sectorsWide);
        _sectorsHigh = Mathf.Max(0, sectorsHigh);


        if (_mapTexture != null)
        {
            Destroy(_mapTexture);
        }

        int mapWidthInPixels = _sectorsWide * _sectorWidth;
        int mapHeightInPixels = _sectorsHigh * _sectorHeight;

        _mapTexture = new Texture2D(mapWidthInPixels, mapHeightInPixels);
        _mapTexture.Clear(_bgColor);

        _rawImage = GetComponent<RawImage>();
        _rawImage.texture = _mapTexture;
    }

    public void UpdateMap(Vector2 playerOccupiedSector)
    {
        if(_mapTexture == null)
        {
            Debug.Log("_mapTexture is null.  You probably need to call Init");
            return;
        }

        _mapTexture.Clear(_bgColor);

        // Render the "you are here" sector
        if (playerOccupiedSector != WorldInfo.Instance.lostWoodsSector)
        {
            int w = _sectorWidth;
            int h = _sectorHeight;
            int x = (int)(w * playerOccupiedSector.x);
            int y = (int)(h * (_sectorsHigh - 1 - playerOccupiedSector.y));     // flip y

            _mapTexture.SetColorForArea(x, y, w, h, _youAreHereColor);
        }

        _mapTexture.Apply();
    }
}