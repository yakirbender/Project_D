using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    [SerializeField] protected int _hp, _atk, _mag, _spd, _def, _res, _mov;

    protected bool isSelected = false; 
	protected bool hasAttacked = false;
	protected bool doneMoving = false;
	protected bool hasMoved = false;

    [SerializeField]
    private int _posX, _posY;

    private Color unitColor;

    //Movement variables
	protected List<Tile> accessibleTiles;
	protected List<Tile> enemyTiles;
	protected int currentMovement;

}
