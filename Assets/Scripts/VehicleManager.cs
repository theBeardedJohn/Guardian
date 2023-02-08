using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleManager : MonoBehaviour
{

    [Header("Stored fluid values")]
    public int vehicleMaxHp;
    public int vehicleHp;
    public int vehicleMaxFuel;
    public int vehicleFuel;
    public int vehicleMaxElectricity;
    public int vehicleElectricity;


    [Header("Stored fixed values")]
    
    public float vehicleSpeedMult;


    [Header("Input values")]
    public float vehicleMoveVerticalInput;
    public float vehicleMoveHorizontalInput;

    [Header("Status bools")]
    public bool vehicleEngineStatus;
    public bool vehicleElectricityStatus;
    public bool vehicleLightsStatus;






}
