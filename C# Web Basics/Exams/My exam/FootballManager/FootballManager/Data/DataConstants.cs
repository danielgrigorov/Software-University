namespace FootballManager.Data
{
    public class DataConstants
    {
        public const int IdMaxLength = 40;
        public const int DefaultMaxLength = 20;

        public const int UserMinUsername = 5;
        public const int UserMinPassword = 5;
        public const int UserMinEmail = 10;
        public const int UserMaxEmail = 60;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const int FootballPlayerFullNameMinLength = 5;
        public const int FootballPlayerFullNameMaxLength = 80;
        public const int FootballPlayerPositionMinLength = 5;
        public const int FootballPlayerDescriptionMaxLength = 200;
        public const byte FootballPlayerQualitiesMin = 0;
        public const byte FootballPlayerQualitiesMax = 10;
        public const string PositionTypeGoalkeeper = "Goalkeeper";
        public const string PositionTypeRightFullback = "Right Fullback";
        public const string PositionTypeLeftFullback = "Right Fullback";
        public const string PositionTypeCenterFullback = "Center Fullback";
        public const string PositionTypeDefender = "Defender";
        public const string PositionTypeStriker = "Striker";
        public const string PositionTypeWinger = "Winger";
    }
}