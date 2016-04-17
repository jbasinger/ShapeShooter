using UnityEngine;
using System.Collections;

public class ShipChange : MonoBehaviour {

  public ShipType shipType;
  public GameObject ship;
  public float shipChangeCooldown;

  public GameObject triangleShip;
  public GameObject rectangleShip;
  public GameObject trapezoidShip;
  public GameObject ellipseShip;

  float timer;

  // Use this for initialization
  void Start() {
    
  }

  // Update is called once per frame
  void Update() {

    if (timer <= 0) {
      
      if(Input.GetAxis("Mouse ScrollWheel") > 0) {
        SwitchShip(GetNextShip());
      } else if (Input.GetAxis("Mouse ScrollWheel") < 0) {
        SwitchShip(GetLastShip());
      }

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

    timer -= Time.deltaTime;

  }

  void SwitchShip(GameObject newShip) {
    timer = shipChangeCooldown;
    Vector3 shipPos = ship.transform.position;
    Destroy(ship);
    ship = Instantiate(newShip, shipPos, Quaternion.identity) as GameObject;
  }

  GameObject GetNextShip() {
    switch (shipType) {
      case ShipType.Triangle:

        shipType = ShipType.Rectangle;
        return rectangleShip;

      case ShipType.Rectangle:

        shipType = ShipType.Trapezoid;
        return trapezoidShip;

      case ShipType.Trapezoid:

        shipType = ShipType.Ellipse;
        return ellipseShip;

      case ShipType.Ellipse:

        shipType = ShipType.Triangle;
        return triangleShip;

      default:
        return null;
    }
  }

  GameObject GetLastShip() {
    switch (shipType) {
      case ShipType.Triangle:

        shipType = ShipType.Ellipse;
        return ellipseShip;

      case ShipType.Rectangle:

        shipType = ShipType.Triangle;
        return triangleShip;

      case ShipType.Trapezoid:

        shipType = ShipType.Rectangle;
        return rectangleShip;

      case ShipType.Ellipse:

        shipType = ShipType.Trapezoid;
        return trapezoidShip;

      default:
        return null;
    }
  }

}
