using HRM.DAL.DbContext;
using HRM.DAL.Repository.RoleRepository;
using HRM.DAL.Repository.StatusRepository;
using HRM.DAL.Repository.StatusTypeRepository;
using HRM.DAL.Repository.TeamRepository;
using HRM.DAL.Repository.UserLevelRepository;
using HRM.DAL.Repository.UserRoleRepository;
using System;

namespace HRM.DAL
{
	public class UnitOfWork : IDisposable
	{

        private HRMContext _dbContext = new HRMContext();
        private OfficialHollidaysRepository hollidays;
        private RequestTypeRepository requestType;
        private RoleRepository role;
        private SettingsRepository settings;
        private StatusRepository status;
        private StatusTypeRepository statusType;
        private TeamRepository team;
        private UserDocumentRepository userDoc;
        private UserLevelRepository userLevel;
        private UserRepository user;
        private UserRequestRepository userRequest;
        private UserRoleRepository userRole;
        private UserTeamRepository userTeam;

        public  OfficialHollidaysRepository Hollidays {
        get {
                if (hollidays == null)
                    hollidays =new OfficialHollidaysRepository(_dbContext);
                return hollidays;
            }
        }
        public RequestTypeRepository RequestType {
            get
            {
                if (requestType == null)
                    requestType = new RequestTypeRepository(_dbContext);
                return requestType;
            }
        }
   
        public SettingsRepository Settings
        {
            get
            {
                if (settings == null)
                    settings = new SettingsRepository(_dbContext);
                return settings;
            }
        }

        public RoleRepository Role
        {
            get
            {
                if (role == null)
                    role = new RoleRepository(_dbContext);
                return role;
            }
        }
        public StatusRepository Status
        {
            get
            {
                if (status == null)
                    status = new StatusRepository(_dbContext);
                return status;
            }
        }
        public UserLevelRepository UserLevel
        {
            get
            {
                if (userLevel == null)
                    userLevel = new UserLevelRepository(_dbContext);
                return userLevel;
            }
        }
        public UserRoleRepository UserRole
        {
            get
            {
                if (userRole == null)
                    userRole = new UserRoleRepository(_dbContext);
                return userRole;
            }
        }
        public UserTeamRepository UserTeam
        {
            get
            {
                if (userTeam == null)
                    userTeam = new UserTeamRepository(_dbContext);
                return userTeam;
            }
        }


        public StatusTypeRepository StatusType
        {
            get
            {
                if (statusType == null)
                    statusType = new StatusTypeRepository(_dbContext);
                return statusType;
            }
        }
        public TeamRepository Team
        {
            get
            {
                if (team == null)
                    team = new TeamRepository(_dbContext);
                return team;
            }
        }
        public UserDocumentRepository UserDoc
        {
            get
            {
                if (userDoc == null)
                    userDoc = new UserDocumentRepository(_dbContext);
                return userDoc;
            }
        }
      
        public UserRepository User
        {
            get
            {
                if (user == null)
                    user = new UserRepository(_dbContext);
                return user;
            }
        }
        public UserRequestRepository UserRequest
        {
            get
            {
                if (userRequest == null)
                    userRequest = new UserRequestRepository(_dbContext);
                return userRequest;
            }
        }
    

        public HRMContext Context
		{
			get { return _dbContext; }
		}
		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
				disposedValue = true;
			}
		}
		public void Dispose()
		{

			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
