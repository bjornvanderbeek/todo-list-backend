using Core;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Registrations
{
    public class TodoListRegistration
    {
        public static void Register()
        {
            BsonClassMap.RegisterClassMap<TodoList>(cm => {
                cm.AutoMap();
                cm.MapIdMember(m => m.Id)
                    .SetIdGenerator(new StringObjectIdGenerator())
                    .SetSerializer(new StringSerializer(BsonType.ObjectId));
             });
        }
    }
}
