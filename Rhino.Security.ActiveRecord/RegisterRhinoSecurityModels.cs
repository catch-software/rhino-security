using System;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Internal;

namespace Rhino.Security.ActiveRecord
{
	public class RegisterRhinoSecurityModels
	{
        public void BeforeNHibernateInitialization()
		{
            ActiveRecordStarter.ModelsValidated -= CreateDummyModelsForRhinoSecurityClasses;
			ActiveRecordStarter.ModelsValidated += CreateDummyModelsForRhinoSecurityClasses;
		}

	    static void CreateDummyModelsForRhinoSecurityClasses(ActiveRecordModelCollection models, IConfigurationSource source)
	    {
		    var modelBuilder = new ActiveRecordModelBuilder();

	        foreach (Type type in RhinoSecurity.Entities)
	        {
	            if (!models.Contains(type))
	            {
	                modelBuilder.CreateDummyModelFor(type);
	            }
	        }
	    }
	}
}