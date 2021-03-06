﻿using System.Collections.Generic;

public class TileInfo
{
    // 96, 9C?
    static List<int> _flatTiles = new List<int> {
        0x00, 0x02, 0x06, 0x0C, 0x0E, 0x14, 0x1A, 0x20, 0x40,
        0x46, 0x4C, 0x8C, 0x8D, 0x8E, 0x8F, 0x91, 0x92, 0x93, 0x94, 0x95,
        0x97, 0x98, 0x99, 0x9A, 0x9B, 0x9D,

        0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A,
        0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x60, 0x61, 0x64, 0x65, 0x66, 0x67,
        0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72,
        0x73, 0x74, 0x75, 0x78, 0x79, 0x7A, 0x7B, 0x7C, 0x7D, 0x7E, 0x7F,
        0x80, 0x81, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89,

        0x28, 0x2A, 0x3C, 0x3E,
        0x2E, 0x30, 0x42, 0x44,
        0x34, 0x36, 0x48, 0x4A,

        0x18, 0x24,
        0x16, 0x1C, 0x22,
        0x90
    };

    static List<int> _shortTiles = new List<int> {
        0x01,
        0x07, 0x1B,
        0x0D
    };

    static List<int> _unitHeightTiles = new List<int> {
        0x21
    };

    static List<int> _passableTiles = new List<int> {
        0x00, 0x02, 0x14, 0x18, 0x40, 0x8C, 0x8D, 0x8E, 0x8F, 0x91,
        0x06, 0x1A, 0x46, 0x92, 0x93, 0x94, 0x95, 0x97,
        0x0C, 0x0E, 0x20, 0x24, 0x4C, 0x98, 0x99, 0x9A, 0x9B, 0x9D,
        0x16, 0x1C, 0x22,
        0x90
    };

    static List<int> _flatImpassableTiles = new List<int> {
        0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A,
        0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x60, 0x61, 0x64, 0x65, 0x66, 0x67,
        0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72,
        0x73, 0x74, 0x75, 0x78, 0x79, 0x7A, 0x7B, 0x7C, 0x7D, 0x7E, 0x7F,
        0x80, 0x81, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89
    };

    static List<int> _entranceTiles = new List<int> {
        0x18, 0x24,
        0x00, 0x06, 0x0C
    };

    static List<int> _waterTiles = new List<int> {
        0x50, 0x51, 0x52, 0x64, 0x65, 0x66, 0x78, 0x79, 0x7A,
        0x56, 0x57, 0x58, 0x6A, 0x6B, 0x6C, 0x7E, 0x7F, 0x80,
        0x5C, 0x5D, 0x5E, 0x70, 0x71, 0x72, 0x84, 0x85, 0x86
    };

    static List<int> _sandTiles = new List<int> {
        0x02, 0x40,
        0x56, 0x54, 0x55, 0x59, 0x5A, 0X5B,
        0x67, 0x68, 0x69, 0x6D, 0x6E, 0x6F,
        0x7B, 0x7C, 0x7D, 0x81, 0x82, 0x83,
        0x8C, 0x8D, 0x8E, 0x8F, 0x92, 0x93, 0x94, 0x95
    };

    static List<int> _armosTiles = new List<int> {
        0x16, 0x1C, 0x22
    };


    static public List<int> WaterTiles { get { return _waterTiles; } }
    static public List<int> SandTiles { get { return _sandTiles; } }


    public static bool IsTileFlat(int tileCode)
    {
        return _flatTiles.Contains(tileCode);
    }
    public static bool IsTileShort(int tileCode)
    {
        return _shortTiles.Contains(tileCode);
    }
    public static bool IsTileUnitHeight(int tileCode)
    {
        return _unitHeightTiles.Contains(tileCode);
    }
    public static bool IsTilePassable(int tileCode)
    {
        return _passableTiles.Contains(tileCode);
    }
    public static bool IsTileFlatImpassable(int tileCode)
    {
        return _flatImpassableTiles.Contains(tileCode);
    }
    public static bool IsTileAnEntrance(int tileCode)
    {
        return _entranceTiles.Contains(tileCode);
    }
    public static bool IsTileWater(int tileCode)
    {
        return _waterTiles.Contains(tileCode);
    }
    public static bool IsTileSand(int tileCode)
    {
        return _sandTiles.Contains(tileCode);
    }

    public static bool IsArmosTile(int tileCode)
    {
        return _armosTiles.Contains(tileCode);
    }
    public static bool IsRedArmosTile(int tileCode) { return tileCode == 0x16; }
    public static bool IsGreenArmosTile(int tileCode) { return tileCode == 0x1C; }
    public static bool IsWhiteArmosTile(int tileCode) { return tileCode == 0x22; }

    public static int GetReplacementTileForArmosTile(int tileCode)
    {
        int r = tileCode;
        if (IsRedArmosTile(tileCode)) { r = 0x02; }
        else if (IsGreenArmosTile(tileCode)) { r = 0x02; }
        else if (IsWhiteArmosTile(tileCode)) { r = 0x0E; }
        return r;
    }
}