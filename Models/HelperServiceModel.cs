using System;
using System.Collections.Generic;

namespace InterviewTask.Models
{
    public class HelperServiceModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TelephoneNumber { get; set; }

        public List<int> MondayOpeningHours { get; set; }
        public List<int> TuesdayOpeningHours { get; set; }
        public List<int> WednesdayOpeningHours { get; set; }
        public List<int> ThursdayOpeningHours { get; set; }
        public List<int> FridayOpeningHours { get; set; }
        public List<int> SaturdayOpeningHours { get; set; }
        public List<int> SundayOpeningHours { get; set; }

        public string GetClosingTime()
        {
            // Assuming the closing time is the second element in the list
            return $"{SundayOpeningHours[1]}:00"; // You might want to adjust this based on your actual data
        }

        public string GetOpeningTime()
        {
            // Assuming the opening time is the first element in the list
            return $"{MondayOpeningHours[0]}:00"; // You might want to adjust this based on your actual data
        }

        public string NextOpenDay
        {
            get
            {
                var now = DateTime.Now;
                var daysUntilNextOpen = ((int)now.DayOfWeek - 1 + 7) % 7; // Calculate days until the next Monday

                // Find the next open day
                for (int i = 0; i < 7; i++)
                {
                    int nextDay = (int)(now.DayOfWeek + i) % 7;
                    if (IsOpenOnDay(nextDay))
                    {
                        return GetDayOfWeekName(nextDay+1);
                    }
                }

                return "Unknown";
            }
        }

        public bool IsOpenOnDay(int day)
        {
            switch (day)
            {
                case 0:
                    return SundayOpeningHours.Count > 0;
                case 1:
                    return MondayOpeningHours.Count > 0;
                case 2:
                    return TuesdayOpeningHours.Count > 0;
                case 3:
                    return WednesdayOpeningHours.Count > 0;
                case 4:
                    return ThursdayOpeningHours.Count > 0;
                case 5:
                    return FridayOpeningHours.Count > 0;
                case 6:
                    return SaturdayOpeningHours.Count > 0;
                default:
                    return false;
            }
        }

        public string GetDayOfWeekName(int day)
        {
            return Enum.GetName(typeof(DayOfWeek), day);
        }
    }

}

