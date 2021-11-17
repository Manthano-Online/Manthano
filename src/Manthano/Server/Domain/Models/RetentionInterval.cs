namespace Manthano.Domain.Models;

public enum RetentionInterval
{
    Undefined = 0,
    Daily = 1,
    EvenDay = 2,
    OddDay = 3,
    Monday = 4,
    Tuesday = 5,
    Wednesday = 6,
    Thursday = 7,
    Friday = 8,
    Saturday = 9,
    Sunday = 10,
    Monthly1 = 11,
    Monthly2 = 12,
    Monthly3 = 13,
    Monthly4 = 14,
    Monthly5 = 15,
    Monthly6 = 16,
    Monthly7 = 17,
    Monthly8 = 18,
    Monthly9 = 19,
    Monthly10 = 20,
    Monthly11 = 21,
    Monthly12 = 22,
    Monthly13 = 23,
    Monthly14 = 24,
    Monthly15 = 25,
    Monthly16 = 26,
    Monthly17 = 27,
    Monthly18 = 28,
    Monthly19 = 29,
    Monthly20 = 30,
    Monthly21 = 31,
    Monthly22 = 32,
    Monthly23 = 33,
    Monthly24 = 34,
    Monthly25 = 35,
    Monthly26 = 36,
    Monthly27 = 37,
    Monthly28 = 38,
    Monthly29 = 39,
    Monthly30 = 40,
    Monthly31 = 41
}

public class RetentionIntervalItem
{
    public int Key { get; set; }
    public RetentionInterval Retention { get; set; }
    public string German { get; set; }
    public string English { get; set; }
    public RetentionType RetentionType { get; set; }
    public int VerseCount { get; set; }

    public RetentionIntervalItem(int key, RetentionInterval retentionInterval, string english)
    {
        Key = key;
        Retention = retentionInterval;
        English = english;
    }

    public static Dictionary<int, RetentionIntervalItem> Items { get; } = new Dictionary<int, RetentionIntervalItem>
        {
            { 0, new RetentionIntervalItem(0, RetentionInterval.Undefined, "Undefined") { RetentionType = RetentionType.Undefined } },
            { 1, new RetentionIntervalItem(1, RetentionInterval.Daily, "Daily") { RetentionType = RetentionType.Daily } },
            { 2, new RetentionIntervalItem(2, RetentionInterval.EvenDay, "Even Days") { RetentionType = RetentionType.AlternativeDaily } },
            { 3, new RetentionIntervalItem(3, RetentionInterval.OddDay, "Odd Days") { RetentionType = RetentionType.AlternativeDaily } },
            { 4, new RetentionIntervalItem(4, RetentionInterval.Monday, "Monday") { RetentionType = RetentionType.Weekly } },
            { 5, new RetentionIntervalItem(5, RetentionInterval.Tuesday, "Tuesday") { RetentionType = RetentionType.Weekly } },
            { 6, new RetentionIntervalItem(6, RetentionInterval.Wednesday, "Wednesday") { RetentionType = RetentionType.Weekly } },
            { 7, new RetentionIntervalItem(7, RetentionInterval.Thursday, "Thursday") { RetentionType = RetentionType.Weekly } },
            { 8, new RetentionIntervalItem(8, RetentionInterval.Friday, "Friday") { RetentionType = RetentionType.Weekly } },
            { 9, new RetentionIntervalItem(9, RetentionInterval.Saturday, "Saturday") { RetentionType = RetentionType.Weekly } },
            { 10, new RetentionIntervalItem(10, RetentionInterval.Sunday, "Sunday") { RetentionType = RetentionType.Weekly } },
            { 11, new RetentionIntervalItem(11, RetentionInterval.Monthly1, "1st of month") { RetentionType = RetentionType.Monthly } },
            { 12, new RetentionIntervalItem(12, RetentionInterval.Monthly2, "2nd of month") { RetentionType = RetentionType.Monthly } },
            { 13, new RetentionIntervalItem(13, RetentionInterval.Monthly3, "3rd of month") { RetentionType = RetentionType.Monthly } },
            { 14, new RetentionIntervalItem(14, RetentionInterval.Monthly4, "4th of month") { RetentionType = RetentionType.Monthly } },
            { 15, new RetentionIntervalItem(15, RetentionInterval.Monthly5, "5th of month") { RetentionType = RetentionType.Monthly } },
            { 16, new RetentionIntervalItem(16, RetentionInterval.Monthly6, "6th of month") { RetentionType = RetentionType.Monthly } },
            { 17, new RetentionIntervalItem(17, RetentionInterval.Monthly7, "7th of month") { RetentionType = RetentionType.Monthly } },
            { 18, new RetentionIntervalItem(18, RetentionInterval.Monthly8, "8th of month") { RetentionType = RetentionType.Monthly } },
            { 19, new RetentionIntervalItem(19, RetentionInterval.Monthly9, "9th of month") { RetentionType = RetentionType.Monthly } },
            { 20, new RetentionIntervalItem(20, RetentionInterval.Monthly10, "10th of month") { RetentionType = RetentionType.Monthly } },
            { 21, new RetentionIntervalItem(21, RetentionInterval.Monthly11, "11th of month") { RetentionType = RetentionType.Monthly } },
            { 22, new RetentionIntervalItem(22, RetentionInterval.Monthly12, "12th of month") { RetentionType = RetentionType.Monthly } },
            { 23, new RetentionIntervalItem(23, RetentionInterval.Monthly13, "13th of month") { RetentionType = RetentionType.Monthly } },
            { 24, new RetentionIntervalItem(24, RetentionInterval.Monthly14, "14th of month") { RetentionType = RetentionType.Monthly } },
            { 25, new RetentionIntervalItem(25, RetentionInterval.Monthly15, "15th of month") { RetentionType = RetentionType.Monthly } },
            { 26, new RetentionIntervalItem(26, RetentionInterval.Monthly16, "16th of month") { RetentionType = RetentionType.Monthly } },
            { 27, new RetentionIntervalItem(27, RetentionInterval.Monthly17, "17th of month") { RetentionType = RetentionType.Monthly } },
            { 28, new RetentionIntervalItem(28, RetentionInterval.Monthly18, "18th of month") { RetentionType = RetentionType.Monthly } },
            { 29, new RetentionIntervalItem(29, RetentionInterval.Monthly19, "19th of month") { RetentionType = RetentionType.Monthly } },
            { 30, new RetentionIntervalItem(30, RetentionInterval.Monthly20, "20th of month") { RetentionType = RetentionType.Monthly } },
            { 31, new RetentionIntervalItem(31, RetentionInterval.Monthly21, "21st of month") { RetentionType = RetentionType.Monthly } },
            { 32, new RetentionIntervalItem(32, RetentionInterval.Monthly22, "22nd of month") { RetentionType = RetentionType.Monthly } },
            { 33, new RetentionIntervalItem(33, RetentionInterval.Monthly23, "23rd of month") { RetentionType = RetentionType.Monthly } },
            { 34, new RetentionIntervalItem(34, RetentionInterval.Monthly24, "24th of month") { RetentionType = RetentionType.Monthly } },
            { 35, new RetentionIntervalItem(35, RetentionInterval.Monthly25, "25th of month") { RetentionType = RetentionType.Monthly } },
            { 36, new RetentionIntervalItem(36, RetentionInterval.Monthly26, "26th of month") { RetentionType = RetentionType.Monthly } },
            { 37, new RetentionIntervalItem(37, RetentionInterval.Monthly27, "27th of month") { RetentionType = RetentionType.Monthly } },
            { 38, new RetentionIntervalItem(38, RetentionInterval.Monthly28, "28th of month") { RetentionType = RetentionType.Monthly } },
            { 39, new RetentionIntervalItem(39, RetentionInterval.Monthly29, "29th of month") { RetentionType = RetentionType.Monthly } },
            { 40, new RetentionIntervalItem(40, RetentionInterval.Monthly30, "30th of month") { RetentionType = RetentionType.Monthly } },
            { 41, new RetentionIntervalItem(41, RetentionInterval.Monthly31, "31st of month") { RetentionType = RetentionType.Monthly }}
        };
}

public enum RetentionType
{
    Undefined,
    Daily,
    AlternativeDaily,
    Weekly,
    Monthly
}