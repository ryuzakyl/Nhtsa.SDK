namespace Nhtsa.SDK.Routes;

public static class Urls
{
    public static class VehiclesApi
    {
        public static string BaseUrl => "https://vpic.nhtsa.dot.gov/api/vehicles/";

        /// <summary>
        /// The Decode VIN API will decode the VIN and the decoded output will be made available in the format of
        /// Key-value pairs. The IDs (VariableID and ValueID) represent the unique ID associated with the
        /// Variable/Value. In case of text variables, the ValueID is not applicable.
        /// 
        /// Model Year in the request allows for the decoding to specifically be done in the current, or older
        /// (pre-1980), model year ranges. It is recommended to always send in the model year. This API also
        /// supports partial VIN decoding (VINs that are less than 17 characters).
        /// 
        /// In this case, the VIN will be decoded partially with the available characters. In case of partial VINs,
        /// a "*" could be used to indicate the unavailable characters. The 9th digit is not necessary.
        /// </summary>
        public static string DecodeVin => "/DecodeVin/{VIN}";

        /// <summary>
        /// The Decode VIN Flat Format API will decode the VIN and the decoded output will be made available in a
        /// flat file format. Model Year in the request allows for the decoding to specifically be done in the
        /// current, or older (pre-1980), model year ranges. It is recommended to always send in the model year.
        /// 
        /// This API also supports partial VIN decoding (VINs that are less than 17 characters). In this case, the
        /// VIN will be decoded partially with the available characters. In case of partial VINs, a "*" could be
        /// used to indicate the unavailable characters.
        /// </summary>
        public static string DecodeVinValues => "/DecodeVinValues/{VIN}";

        /// <summary>
        /// This is exactly like the Decode VIN method but provides additional information on variables related
        /// to other NHTSA programs like NCSA etc.
        /// </summary>
        public static string DecodeVinExtended => "/DecodeVinExtended/{VIN}";

        /// <summary>
        /// This is exactly like the Decode VIN (flat format) method but provides additional information on
        /// variables related to other NHTSA programs like NCSA etc.
        /// </summary>
        public static string DecodeVinValuesExtended => "/DecodeVinValuesExtended/{VIN}";

        /// <summary>
        /// This provides a list of all the Makes available in vPIC Dataset.
        /// </summary>
        /// <example>
        /// /GetAllMakes?format=json
        /// </example>
        public static string GetAllMakes => "/GetAllMakes";

        /// <summary>
        /// This provides information on the World Manufacturer Identifier for a specific WMI code. WMIs may be put in
        /// as either 3 characters representing VIN position 1-3 or 6 characters representing VIN positions
        /// 1-3 & 12-14. Example "JTD", "1T9131".
        /// </summary>
        /// <example>
        /// /DecodeWMI/1FD?format=json
        /// </example>
        public static string DecodeWMI => "/DecodeWMI/{WMI}";

        /// <summary>
        /// This returns all the Makes in the vPIC dataset for a specified manufacturer and whose Year From and Year To range cover the specified year
        /// 
        /// If supplied parameter is a number - method will do exact match on Manufacturer's Id.
        /// If supplied parameter is a string - it will look for manufacturers whose name is LIKE the provided name (it accepts a partial manufacturer name as an input). Multiple results are returned in case of multiple matches.
        ///
        /// Manufacturer can be idenfitied by Id, a partial name, or a full name (e.g., "988", "HONDA", "HONDA OF CANADA MFG., INC.", etc.)
        /// </summary>
        /// <example>
        /// /GetMakesForManufacturerAndYear/mer?year=2013&format=json
        /// /GetMakesForManufacturerAndYear/988?year=2013&format=json
        /// </example>
        public static string GetMakesForManufacturerAndYear => "/GetMakesForManufacturerAndYear/{MANUFACTURER}";

        /// <summary>
        /// This decodes a batch of VINs that are submitted in a standardized format in a string to return multiple decodes in a flat format. The input string should be in the following format
        ///    vin , modelYear ; vin , modelYear ; vin , modelYear ...
        /// "modelYear" is optional, the output for each VIN decode is in the same format as produced by the "Decode VIN (flat format)" method.
        /// </summary>
        public static string DecodeVinValuesBatch => "/DecodeVINValuesBatch";
    }

    public static class RecallsApi
    {
        public static string BaseUrl => "https://api.nhtsa.gov/recalls/";

        // TODO: to be done
    }
}
