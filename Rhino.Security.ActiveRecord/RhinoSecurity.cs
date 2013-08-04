using System;
using Rhino.Security.Model;

namespace Rhino.Security.ActiveRecord
{
    public class RhinoSecurity
    {
        public static Type[] Entities = new[]
            {
                typeof (EntitiesGroup),
                typeof (EntityReference),
                typeof (EntityType),
                typeof (Operation),
                typeof (Permission),
                typeof (UsersGroup)
            };
    }
}