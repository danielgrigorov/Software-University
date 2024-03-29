﻿namespace FootballManager.Data
{
    public class DataConstants
    {
        public const int IdMaxLength = 40;
        public const int DefaultMaxLength = 20;

        public const int UserMinUsername = 5;
        public const int UserMaxUsername = 20;
        public const int UserMinPassword = 5;
        public const int UserMaxPassword = 20;
        public const int UserMinEmail = 10;
        public const int UserMaxEmail = 60;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const int PlayerMinFullName = 5;
        public const int PlayerMaxFullName = 80;
        public const int PlayerMinPosition = 5;
        public const int PlayerMinSpeed = 0;
        public const int PlayerMaxSpeed = 10;
        public const int PlayerMinEndurance = 0;
        public const int PlayerMaxEndurance = 10;
        public const int PlayerMaxDescription = 200;

    }
}
