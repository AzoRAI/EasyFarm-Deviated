using System;

namespace EasyFarm.Engine.Navigation {

  public struct Position {
    uint8 Rotation;
    float X;
    float Y;
    float Z;
    uint16 Moving;
  }

  public class NavigationMesh {

    /// <summary>
    /// ZoneID refers to the FFXI Game Map 
    /// </summary>
    private int _ZoneID;
    public int ZoneID {
      get { return _ZoneID; }
      set { _ZoneID = value; }
    }



    public NavigationMesh(int zoneId) {

    }


    private bool IsInWater(Position point) {
      throw new NotImplementedException();
    }

    private bool Raycast(Position start, Position end) {
      throw new NotImplementedException();
    }

    private bool IsValidPosition(Position position) {
      throw new NotImplementedException();
    }


    //  Path Finding 


    public List<Position> FindPath(Position start, Position end) {
      throw new NotImplementedException();
    }

    public Dictionary<uint16, Position> FindRandomPosition(Position start, float maxRadius) {
      throw new NotImplementedException();
    }




  }
}