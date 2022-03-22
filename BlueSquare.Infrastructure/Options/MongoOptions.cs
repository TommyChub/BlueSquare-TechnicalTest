﻿namespace BlueSquare.Infrastructure.Options
{
    public class MongoOptions
    {
        public const string Position = "Mongo";

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
