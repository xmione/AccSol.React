using AccSol.EF.Data;

namespace AccSol.Repositories
{
    public class RepositoryManager:IRepositoryManager
    {
        private ApplicationDbContext _dbContext;
        private ICoaRepository? _coaRepository;
        private IClientRepository? _clientRepository;
        private IPayeeCategoryRepository? _payeeCategoryRepository;
        private IEmployeeRepository? _employeeRepository;
        private IPayeeRepository? _payeeRepository;
        private IProjectCategoryRepository? _projectCategoryRepository;
        private IProjectCodeRepository? _projectCodeRepository;
        private IDepartmentRepository? _departmentRepository;
        private IPettyCashRepository? _pettyCashRepository;
        private IJournalRepository? _journalRepository;
        private IJournalTempRepository? _journalTempRepository;
        public RepositoryManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICoaRepository Coa
        {
            get
            {
                if (_coaRepository == null)
                    _coaRepository = new CoaRepository(_dbContext);
                return _coaRepository;
            }
        }
         
        public IClientRepository Client
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new ClientRepository(_dbContext);
                return _clientRepository;
            }
        }
         
        public IPayeeCategoryRepository PayeeCategory
        {
            get
            {
                if (_payeeCategoryRepository == null)
                    _payeeCategoryRepository = new PayeeCategoryRepository(_dbContext);
                return _payeeCategoryRepository;
            }
        }
         
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_dbContext);
                return _employeeRepository;
            }
        }
         
        public IPayeeRepository Payee
        {
            get
            {
                if (_payeeRepository == null)
                    _payeeRepository = new PayeeRepository(_dbContext);
                return _payeeRepository;
            }
        }
         
        public IProjectCategoryRepository ProjectCategory
        {
            get
            {
                if (_projectCategoryRepository == null)
                    _projectCategoryRepository = new ProjectCategoryRepository(_dbContext);
                return _projectCategoryRepository;
            }
        }
         
        public IProjectCodeRepository ProjectCode
        {
            get
            {
                if (_projectCodeRepository == null)
                    _projectCodeRepository = new ProjectCodeRepository(_dbContext);
                return _projectCodeRepository;
            }
        }
         
        public IDepartmentRepository Department
        {
            get
            {
                if (_departmentRepository == null)
                    _departmentRepository = new DepartmentRepository(_dbContext);
                return _departmentRepository;
            }
        }
         
        public IPettyCashRepository PettyCash
        {
            get
            {
                if (_pettyCashRepository == null)
                    _pettyCashRepository = new PettyCashRepository(_dbContext);
                return _pettyCashRepository;
            }
        }
         
        public IJournalRepository Journal
        {
            get
            {
                if (_journalRepository == null)
                    _journalRepository = new JournalRepository(_dbContext);
                return _journalRepository;
            }
        }
        
        public IJournalTempRepository JournalTemp
        {
            get
            {
                if (_journalTempRepository == null)
                    _journalTempRepository = new JournalTempRepository(_dbContext);
                return _journalTempRepository;
            }
        }
    }
}
