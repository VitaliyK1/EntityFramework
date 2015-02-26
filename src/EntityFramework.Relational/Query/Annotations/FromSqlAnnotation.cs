// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.Relational.Query.Annotations
{
    public class FromSqlAnnotation
    {
        public string Sql { get; set; }
        public object[] Parameters { get; set; }

        public override string ToString()
        {
            return Sql;
        }
    }
}
