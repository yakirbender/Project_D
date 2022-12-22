using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    //https://cruise.umple.org/umpleonline/umple.php?model=221125x59g8eqe7di9

    //Tile's grid position. X corresponds to position from left to right, Y corresponds to position from top to bottom
    [SerializeField]
    public int PosX {get; set;}
    public int PosY {get; set;}

    //If tile is accessible, then units are able to move across it.
    public bool isAccessible {get; set;}

    //If tile is occupied by a unit, then other units cannot end their movement on the tile.
    public bool isOccupied {get; set;}

    //If tile is a fort/healing tile, it will heal the unit on it every turn.
    public bool canHeal {get; set;}

    //Stat modifiers of tile.
    [SerializeField] private int _atkMod, _spdMod, _defMod, _resMod, _movMod, _healMod;

    private Unit unit;

    [SerializeField] private Color _tileColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;

    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? _offsetColor : _tileColor;
    }

    private void OnMouseEnter()
    {
        _highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}
