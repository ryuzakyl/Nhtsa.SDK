namespace Nhtsa.SDK.Clients;

public static class Urls
{
    public static class VehiclesApi
    {
        public static string BaseUrl => "https://vpic.nhtsa.dot.gov/api/vehicles/";

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
    }

    public static class RecallsApi
    {
        public static string BaseUrl => "https://api.nhtsa.gov/recalls/";

        // TODO: to be done
    }
}
