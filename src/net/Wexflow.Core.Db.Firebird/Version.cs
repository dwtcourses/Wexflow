﻿namespace Wexflow.Core.Db.Firebird
{
    public class Version : Core.Db.Version
    {
        public static readonly string ColumnName_Id = "ID";
        public static readonly string ColumnName_RecordId = "RECORD_ID";
        public static readonly string ColumnName_FilePath = "FILE_PATH";
        public static readonly string ColumnName_CreatedOn = "CREATED_ON";

        public static readonly string TableStruct = "(" + ColumnName_Id + " integer generated by default as identity primary key, "
                                                        + ColumnName_RecordId + " INTEGER, "
                                                        + ColumnName_FilePath + " VARCHAR(1024), "
                                                        + ColumnName_CreatedOn + " TIMESTAMP)";

        public int Id { get; set; }

        public override string GetDbId()
        {
            return Id.ToString();
        }
    }
}