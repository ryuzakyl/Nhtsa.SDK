using System.Text.Json.Serialization;

namespace Nhtsa.SDK.Models.Vehicles;

public class VinFlatData
{
    [JsonPropertyName("ABS")]
    public string? ABS { get; set; }

    [JsonPropertyName("ActiveSafetySysNote")]
    public string? ActiveSafetySysNote { get; set; }

    [JsonPropertyName("AdaptiveCruiseControl")]
    public string? AdaptiveCruiseControl { get; set; }

    [JsonPropertyName("AdaptiveDrivingBeam")]
    public string? AdaptiveDrivingBeam { get; set; }

    [JsonPropertyName("AdaptiveHeadlights")]
    public string? AdaptiveHeadlights { get; set; }

    [JsonPropertyName("AdditionalErrorText")]
    public string? AdditionalErrorText { get; set; }

    [JsonPropertyName("AirBagLocCurtain")]
    public string? AirBagLocCurtain { get; set; }

    [JsonPropertyName("AirBagLocFront")]
    public string? AirBagLocFront { get; set; }

    [JsonPropertyName("AirBagLocKnee")]
    public string? AirBagLocKnee { get; set; }

    [JsonPropertyName("AirBagLocSeatCushion")]
    public string? AirBagLocSeatCushion { get; set; }

    [JsonPropertyName("AirBagLocSide")]
    public string? AirBagLocSide { get; set; }

    [JsonPropertyName("AutoReverseSystem")]
    public string? AutoReverseSystem { get; set; }

    [JsonPropertyName("AutomaticPedestrianAlertingSound")]
    public string? AutomaticPedestrianAlertingSound { get; set; }

    [JsonPropertyName("AxleConfiguration")]
    public string? AxleConfiguration { get; set; }

    [JsonPropertyName("Axles")]
    public string? Axles { get; set; }

    [JsonPropertyName("BasePrice")]
    public string? BasePrice { get; set; }

    [JsonPropertyName("BatteryA")]
    public string? BatteryA { get; set; }

    [JsonPropertyName("BatteryCells")]
    public string? BatteryCells { get; set; }

    [JsonPropertyName("BatteryInfo")]
    public string? BatteryInfo { get; set; }

    [JsonPropertyName("BatteryKWh")]
    public string? BatteryKWh { get; set; }

    [JsonPropertyName("BatteryModules")]
    public string? BatteryModules { get; set; }

    [JsonPropertyName("BatteryPacks")]
    public string? BatteryPacks { get; set; }

    [JsonPropertyName("BatteryType")]
    public string? BatteryType { get; set; }

    [JsonPropertyName("BatteryV")]
    public string? BatteryV { get; set; }

    [JsonPropertyName("BedLengthIN")]
    public string? BedLengthIN { get; set; }

    [JsonPropertyName("BedType")]
    public string? BedType { get; set; }

    [JsonPropertyName("BlindSpotIntervention")]
    public string? BlindSpotIntervention { get; set; }

    [JsonPropertyName("BlindSpotMon")]
    public string? BlindSpotMon { get; set; }

    [JsonPropertyName("BodyCabType")]
    public string? BodyCabType { get; set; }

    [JsonPropertyName("BodyClass")]
    public string? BodyClass { get; set; }

    [JsonPropertyName("BrakeSystemDesc")]
    public string? BrakeSystemDesc { get; set; }

    [JsonPropertyName("BrakeSystemType")]
    public string? BrakeSystemType { get; set; }

    [JsonPropertyName("BusFloorConfigType")]
    public string? BusFloorConfigType { get; set; }

    [JsonPropertyName("BusLength")]
    public string? BusLength { get; set; }

    [JsonPropertyName("BusType")]
    public string? BusType { get; set; }

    [JsonPropertyName("CAN_AACN")]
    public string? CAN_AACN { get; set; }

    [JsonPropertyName("CIB")]
    public string? CIB { get; set; }

    [JsonPropertyName("CashForClunkers")]
    public string? CashForClunkers { get; set; }

    [JsonPropertyName("ChargerLevel")]
    public string? ChargerLevel { get; set; }

    [JsonPropertyName("ChargerPowerKW")]
    public string? ChargerPowerKW { get; set; }

    [JsonPropertyName("CoolingType")]
    public string? CoolingType { get; set; }

    [JsonPropertyName("CurbWeightLB")]
    public string? CurbWeightLB { get; set; }

    [JsonPropertyName("CustomMotorcycleType")]
    public string? CustomMotorcycleType { get; set; }

    [JsonPropertyName("DaytimeRunningLight")]
    public string? DaytimeRunningLight { get; set; }

    [JsonPropertyName("DestinationMarket")]
    public string? DestinationMarket { get; set; }

    [JsonPropertyName("DisplacementCC")]
    public string? DisplacementCC { get; set; }

    [JsonPropertyName("DisplacementCI")]
    public string? DisplacementCI { get; set; }

    [JsonPropertyName("DisplacementL")]
    public string? DisplacementL { get; set; }

    [JsonPropertyName("Doors")]
    public string? Doors { get; set; }

    [JsonPropertyName("DriveType")]
    public string? DriveType { get; set; }

    [JsonPropertyName("DriverAssist")]
    public string? DriverAssist { get; set; }

    [JsonPropertyName("DynamicBrakeSupport")]
    public string? DynamicBrakeSupport { get; set; }

    [JsonPropertyName("EDR")]
    public string? EDR { get; set; }

    [JsonPropertyName("ESC")]
    public string? ESC { get; set; }

    [JsonPropertyName("EVDriveUnit")]
    public string? EVDriveUnit { get; set; }

    [JsonPropertyName("ElectrificationLevel")]
    public string? ElectrificationLevel { get; set; }

    [JsonPropertyName("EngineConfiguration")]
    public string? EngineConfiguration { get; set; }

    [JsonPropertyName("EngineCycles")]
    public string? EngineCycles { get; set; }

    [JsonPropertyName("EngineCylinders")]
    public string? EngineCylinders { get; set; }

    [JsonPropertyName("EngineHP")]
    public string? EngineHP { get; set; }

    [JsonPropertyName("EngineHP_to")]
    public string? EngineHP_to { get; set; }

    [JsonPropertyName("EngineKW")]
    public string? EngineKW { get; set; }

    [JsonPropertyName("EngineManufacturer")]
    public string? EngineManufacturer { get; set; }

    [JsonPropertyName("EngineModel")]
    public string? EngineModel { get; set; }

    [JsonPropertyName("EntertainmentSystem")]
    public string? EntertainmentSystem { get; set; }

    [JsonPropertyName("ErrorCode")]
    public string? ErrorCode { get; set; }

    [JsonPropertyName("ErrorText")]
    public string? ErrorText { get; set; }

    [JsonPropertyName("ForwardCollisionWarning")]
    public string? ForwardCollisionWarning { get; set; }

    [JsonPropertyName("FuelInjectionType")]
    public string? FuelInjectionType { get; set; }

    [JsonPropertyName("FuelTypePrimary")]
    public string? FuelTypePrimary { get; set; }

    [JsonPropertyName("FuelTypeSecondary")]
    public string? FuelTypeSecondary { get; set; }

    [JsonPropertyName("GCWR")]
    public string? GCWR { get; set; }

    [JsonPropertyName("GVWR")]
    public string? GVWR { get; set; }

    [JsonPropertyName("KeylessIgnition")]
    public string? KeylessIgnition { get; set; }

    [JsonPropertyName("LaneDepartureWarning")]
    public string? LaneDepartureWarning { get; set; }

    [JsonPropertyName("LaneKeepSystem")]
    public string? LaneKeepSystem { get; set; }

    [JsonPropertyName("LowerBeamHeadlampLightSource")]
    public string? LowerBeamHeadlampLightSource { get; set; }

    [JsonPropertyName("Make")]
    public string? Make { get; set; }

    [JsonPropertyName("Manufacturer")]
    public string? Manufacturer { get; set; }

    [JsonPropertyName("ManufacturerId")]
    public string? ManufacturerId { get; set; }

    [JsonPropertyName("Model")]
    public string? Model { get; set; }

    [JsonPropertyName("ModelYear")]
    public string? ModelYear { get; set; }

    [JsonPropertyName("MotorcycleSuspensionType")]
    public string? MotorcycleSuspensionType { get; set; }

    [JsonPropertyName("MotorcycleChassisType")]
    public string? MotorcycleChassisType { get; set; }

    [JsonPropertyName("NCSABodyType")]
    public string? NCSABodyType { get; set; }

    [JsonPropertyName("NCSAMake")]
    public string? NCSAMake { get; set; }

    [JsonPropertyName("NCSAModel")]
    public string? NCSAModel { get; set; }

    [JsonPropertyName("Note")]
    public string? Note { get; set; }

    [JsonPropertyName("OtherBusInfo")]
    public string? OtherBusInfo { get; set; }

    [JsonPropertyName("OtherEngineInfo")]
    public string? OtherEngineInfo { get; set; }

    [JsonPropertyName("OtherMotorcycleInfo")]
    public string? OtherMotorcycleInfo { get; set; }

    [JsonPropertyName("OtherRestraintSystemInfo")]
    public string? OtherRestraintSystemInfo { get; set; }

    [JsonPropertyName("PlantCity")]
    public string? PlantCity { get; set; }

    [JsonPropertyName("PlantCompanyName")]
    public string? PlantCompanyName { get; set; }

    [JsonPropertyName("PlantCountry")]
    public string? PlantCountry { get; set; }

    [JsonPropertyName("PlantState")]
    public string? PlantState { get; set; }

    [JsonPropertyName("PossibleValues")]
    public string? PossibleValues { get; set; }

    [JsonPropertyName("Pretensioner")]
    public string? Pretensioner { get; set; }

    [JsonPropertyName("RearAutomaticEmergencyBraking")]
    public string? RearAutomaticEmergencyBraking { get; set; }

    [JsonPropertyName("RearCrossTrafficAlert")]
    public string? RearCrossTrafficAlert { get; set; }

    [JsonPropertyName("RearVisibilitySystem")]
    public string? RearVisibilitySystem { get; set; }

    [JsonPropertyName("SAEAutomationLevel")]
    public string? SAEAutomationLevel { get; set; }

    [JsonPropertyName("SAEAutomationLevel_to")]
    public string? SAEAutomationLevel_to { get; set; }

    [JsonPropertyName("SeatBeltsAll")]
    public string? SeatBeltsAll { get; set; }

    [JsonPropertyName("SeatRows")]
    public string? SeatRows { get; set; }

    [JsonPropertyName("Seats")]
    public string? Seats { get; set; }

    [JsonPropertyName("SemiautomaticHeadlampBeamSwitching")]
    public string? SemiautomaticHeadlampBeamSwitching { get; set; }

    [JsonPropertyName("Series")]
    public string? Series { get; set; }

    [JsonPropertyName("Series2")]
    public string? Series2 { get; set; }

    [JsonPropertyName("SteeringLocation")]
    public string? SteeringLocation { get; set; }

    [JsonPropertyName("SuggestedVIN")]
    public string? SuggestedVIN { get; set; }

    [JsonPropertyName("TPMS")]
    public string? TPMS { get; set; }

    [JsonPropertyName("TopSpeedMPH")]
    public string? TopSpeedMPH { get; set; }

    [JsonPropertyName("TrackWidth")]
    public string? TrackWidth { get; set; }

    [JsonPropertyName("TractionControl")]
    public string? TractionControl { get; set; }

    [JsonPropertyName("TrailerBodyType")]
    public string? TrailerBodyType { get; set; }

    [JsonPropertyName("TrailerLength")]
    public string? TrailerLength { get; set; }

    [JsonPropertyName("TrailerType")]
    public string? TrailerType { get; set; }

    [JsonPropertyName("TransmissionSpeeds")]
    public string? TransmissionSpeeds { get; set; }

    [JsonPropertyName("TransmissionStyle")]
    public string? TransmissionStyle { get; set; }

    [JsonPropertyName("Trim")]
    public string? Trim { get; set; }

    [JsonPropertyName("Trim2")]
    public string? Trim2 { get; set; }

    [JsonPropertyName("Turbo")]
    public string? Turbo { get; set; }

    [JsonPropertyName("VIN")]
    public string? VIN { get; set; }

    [JsonPropertyName("ValveTrainDesign")]
    public string? ValveTrainDesign { get; set; }

    [JsonPropertyName("VehicleDescriptor")]
    public string? VehicleDescriptor { get; set; }

    [JsonPropertyName("VehicleType")]
    public string? VehicleType { get; set; }

    [JsonPropertyName("WheelBaseLong")]
    public string? WheelBaseLong { get; set; }

    [JsonPropertyName("WheelBaseShort")]
    public string? WheelBaseShort { get; set; }

    [JsonPropertyName("WheelBaseType")]
    public string? WheelBaseType { get; set; }

    [JsonPropertyName("WheelSizeFront")]
    public string? WheelSizeFront { get; set; }

    [JsonPropertyName("WheelSizeRear")]
    public string? WheelSizeRear { get; set; }

    [JsonPropertyName("Wheels")]
    public string? Wheels { get; set; }

    [JsonPropertyName("Windows")]
    public string? Windows { get; set; }
}
