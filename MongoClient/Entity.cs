﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoClientTool
{
   public class Entity
    {
       [BsonId]
       [BsonRepresentation(BsonType.ObjectId)]
       public string Id;
    }
}
