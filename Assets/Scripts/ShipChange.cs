using UnityEngine;
using System.Collections;

public class ShipChange : MonoBehaviour {

  public ShipType shipType;

  public GameObject ship;

  public GameObject triangleShip;
  public GameObject rectangleShip;
  public GameObject trapezoidShip;
  public GameObject ellipseShip;
  
  // Use this for initialization
  void Start() {
    
  }

  // Update is called once per frame
  void Update() {

    if (Input.GetKeyDown("1")) {

      shipType = ShipType.Triangle;
      SwitchShip(triangleShip);

    } else if (Input.GetKeyDown("2")) {

      shipType = ShipType.Rectangle;
      SwitchShip(rectangleShip);

    } else if (Input.GetKeyDown("3")) {

      shipType = ShipType.Trapezoid;
      SwitchShip(trapezoidShip);

    } else if (Input.GetKeyDown("4")) {

      shipType = ShipType.Ellipse;
      SwitchShip(ellipseShip);

    }

  }

  void SwitchShip(GameObject newShip) {
    Vector3 shipPos = ship.transform.position;
    Destroy(ship);
    ship = Instantiate(newShip, shipPos, Quaternion.identity) as GameObject;
  }

}
