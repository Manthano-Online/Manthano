namespace Manthano.Domain.Models.Extensions;

public static class ModelsExtensions
{
    public static RetentionInterval GetAlternatingInterval(this DateTime date)
    {
        return date.Day % 2 != 0 ? RetentionInterval.OddDay : RetentionInterval.EvenDay;
    }

    public static RetentionInterval GetWeeklyInterval(this DateTime date)
    {
        return date.DayOfWeek switch
        {
            DayOfWeek.Monday => RetentionInterval.Monday,
            DayOfWeek.Tuesday => RetentionInterval.Tuesday,
            DayOfWeek.Wednesday => RetentionInterval.Wednesday,
            DayOfWeek.Thursday => RetentionInterval.Thursday,
            DayOfWeek.Friday => RetentionInterval.Friday,
            DayOfWeek.Saturday => RetentionInterval.Saturday,
            DayOfWeek.Sunday => RetentionInterval.Sunday,
            _ => RetentionInterval.Undefined
        };
    }

    public static RetentionInterval GetMonthlyInterval(this DateTime date)
    {
        return date.Day switch
        {
            1 => RetentionInterval.Monthly1,
            2 => RetentionInterval.Monthly2,
            3 => RetentionInterval.Monthly3,
            4 => RetentionInterval.Monthly4,
            5 => RetentionInterval.Monthly5,
            6 => RetentionInterval.Monthly6,
            7 => RetentionInterval.Monthly7,
            8 => RetentionInterval.Monthly8,
            9 => RetentionInterval.Monthly9,
            10 => RetentionInterval.Monthly10,
            11 => RetentionInterval.Monthly11,
            12 => RetentionInterval.Monthly12,
            13 => RetentionInterval.Monthly13,
            14 => RetentionInterval.Monthly14,
            15 => RetentionInterval.Monthly15,
            16 => RetentionInterval.Monthly16,
            17 => RetentionInterval.Monthly17,
            18 => RetentionInterval.Monthly18,
            19 => RetentionInterval.Monthly19,
            21 => RetentionInterval.Monthly21,
            22 => RetentionInterval.Monthly22,
            23 => RetentionInterval.Monthly23,
            24 => RetentionInterval.Monthly24,
            25 => RetentionInterval.Monthly25,
            26 => RetentionInterval.Monthly26,
            27 => RetentionInterval.Monthly27,
            28 => RetentionInterval.Monthly28,
            29 => RetentionInterval.Monthly29,
            30 => RetentionInterval.Monthly30,
            31 => RetentionInterval.Monthly31,
            _ => RetentionInterval.Undefined
        };
    }
}
