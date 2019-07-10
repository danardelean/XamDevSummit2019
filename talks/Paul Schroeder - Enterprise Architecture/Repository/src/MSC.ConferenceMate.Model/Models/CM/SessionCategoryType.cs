// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using MSC.ConferenceMate.API.Client.Interface;
using MSC.ConferenceMate.Model.CM.Interface;
using xDTO = MSC.ConferenceMate.DTO.CM;

namespace MSC.ConferenceMate.Model.CM
{

	public class LoadRequestSessionCategoryType : EventArgs
	{
		public LoadRequestSessionCategoryType(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class SessionCategoryType : BaseModel<IWebApiDataServiceCM>, ISessionCategoryType
	{
		public event EventHandler<LoadRequestSessionCategoryType> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.SessionCategoryType _dto = null;

		public SessionCategoryType(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService) : base(log, dataService)
		{
			_dto = new xDTO.SessionCategoryType();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public SessionCategoryType(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService, xDTO.SessionCategoryType dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string Code { get { return _dto.Code; } }
		public virtual string CreatedBy { get { return _dto.CreatedBy; } }
		public virtual System.DateTime CreatedUtcDate { get { return _dto.CreatedUtcDate; } }
		public virtual int DataVersion { get { return _dto.DataVersion; } }
		public virtual bool IsDeleted { get { return _dto.IsDeleted; } }
		public virtual string ModifiedBy { get { return _dto.ModifiedBy; } }
		public virtual System.DateTime ModifiedUtcDate { get { return _dto.ModifiedUtcDate; } }
		public virtual string Name { get { return _dto.Name; } }
		public virtual int SessionCategoryTypeId { get { return _dto.SessionCategoryTypeId; } }

		private List<ISessionSessionCategoryType> _sessionSessionCategoryTypes = null; // Reverse Navigation


		public virtual List<ISessionSessionCategoryType> SessionSessionCategoryTypes
		{
			get
			{
				if (_sessionSessionCategoryTypes == null && _dto != null)
				{	// The core DTO object is loaded, but this property is not loaded.
					if (_dto.SessionSessionCategoryTypes != null)
					{	// The core DTO object has data for this property, load it into the model.
						_sessionSessionCategoryTypes = new List<ISessionSessionCategoryType>();
						foreach (var dtoItem in _dto.SessionSessionCategoryTypes)
						{
							_sessionSessionCategoryTypes.Add(new SessionSessionCategoryType(Log, DataService, dtoItem));
						}
					}
					else
					{	// Trigger the load data request - The core DTO object is loaded and does not have data for this property.
						OnLazyLoadRequest(this, new LoadRequestSessionCategoryType(nameof(SessionSessionCategoryTypes)));
					}
				}

				return _sessionSessionCategoryTypes;
			}
		}



	}
}