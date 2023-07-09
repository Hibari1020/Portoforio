using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubePosition : MonoBehaviour
{
    [SerializeField]private GameObject _startCube;
    [SerializeField]private GameObject _finishCube;
    [SerializeField]private GameObject _redCube1;
    [SerializeField]private GameObject _redCube2;
    [SerializeField]private GameObject _redCube3;
    [SerializeField]private GameObject _redCube4;
    [SerializeField]private GameObject _redCube5;
    [SerializeField]private GameObject _redCube6;
    [SerializeField]private GameObject _redCube7;
    [SerializeField]private GameObject _redCube8;
    [SerializeField]private GameObject _redCube9;
    [SerializeField]private GameObject _redCube10;
    [SerializeField]private GameObject _blueCube1;
    [SerializeField]private GameObject _blueCube2;
    [SerializeField]private GameObject _blueCube3;
    [SerializeField]private GameObject _blueCube4;
    [SerializeField]private GameObject _blueCube5;
    [SerializeField]private GameObject _blueCube6;
    [SerializeField]private GameObject _blueCube7; 
    [SerializeField]private GameObject _blueCube8;
    [SerializeField]private GameObject _blueCube9;
    [SerializeField]private GameObject _blueCube10;
    [SerializeField]private GameObject _normalCube1;
    [SerializeField]private GameObject _normalCube2;
    [SerializeField]private GameObject _normalCube3;
    [SerializeField]private GameObject _moveCube1;
    [SerializeField]private GameObject _moveCube2;
    [SerializeField]private GameObject _moveCube3;
    [SerializeField]private GameObject _moveCube4;
    [SerializeField]private GameObject _moveCube5;

    List<int> cubeList = new List<int>();
    List<int> randomList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
      RandomNumber();
      RandomCube();
    }

   void RandomCube(){
        _startCube.transform.position = new Vector3(randomList[0], 0, 0);
        _redCube1.transform.position = new Vector3(randomList[1], 0, 0);
        _redCube2.transform.position = new Vector3(randomList[2], 0, 0);
        _redCube3.transform.position = new Vector3(randomList[3], 0, 0);
        _redCube4.transform.position = new Vector3(randomList[4], 0, 0);
        _redCube5.transform.position = new Vector3(randomList[5], 0, 0);
        _redCube6.transform.position = new Vector3(randomList[6], 0, 0);
        _redCube7.transform.position = new Vector3(randomList[7], 0, 0);
        _redCube8.transform.position = new Vector3(randomList[8], 0, 0);
        _redCube9.transform.position = new Vector3(randomList[9], 0, 0);
        _redCube10.transform.position = new Vector3(randomList[10], 0, 0);
        _blueCube1.transform.position = new Vector3(randomList[11], 0, 0);
        _blueCube2.transform.position = new Vector3(randomList[12], 0, 0);
        _blueCube3.transform.position = new Vector3(randomList[13], 0, 0);
        _blueCube4.transform.position = new Vector3(randomList[14], 0, 0);
        _blueCube5.transform.position = new Vector3(randomList[15], 0, 0);
        _blueCube6.transform.position = new Vector3(randomList[16], 0, 0);
        _blueCube7.transform.position = new Vector3(randomList[17], 0, 0);
        _blueCube8.transform.position = new Vector3(randomList[18], 0, 0);
        _blueCube9.transform.position = new Vector3(randomList[19], 0, 0);
        _blueCube10.transform.position = new Vector3(randomList[20], 0, 0);
        _normalCube1.transform.position = new Vector3(randomList[21], 0, 0);
        _normalCube2.transform.position = new Vector3(randomList[22], 0, 0);
        _normalCube3.transform.position = new Vector3(randomList[23], 0, 0);
        _moveCube1.transform.position = new Vector3(randomList[24], 0, 0);
        _moveCube2.transform.position = new Vector3(randomList[25], 0, 0);
        _moveCube3.transform.position = new Vector3(randomList[26], 0, 0);
        _moveCube4.transform.position = new Vector3(randomList[27], 0, 0);
        _moveCube5.transform.position = new Vector3(randomList[28], 0, 0);
        _finishCube.transform.position = new Vector3(randomList[29], 0, 0);
   }

   void RandomNumber(){
      for (int i = 0; i < 30; i++){
        cubeList.Add(i);

      }

      randomList.Add(0);

      for (int i = 1; i < 29; i++){
        var _randomNumber = UnityEngine.Random.Range(1, 29 - i);
        randomList.Add(cubeList[_randomNumber]);
        cubeList.RemoveAt(_randomNumber);
      }

      randomList.Add(29);


   }
}
