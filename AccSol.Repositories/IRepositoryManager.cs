namespace AccSol.Repositories
{
    public interface IRepositoryManager
    {
        ICoaRepository Coa { get; }
        IClientRepository Client { get; }
        IPayeeCategoryRepository PayeeCategory { get; }
        IEmployeeRepository Employee { get; }
        IPayeeRepository Payee { get; }
        IProjectCategoryRepository ProjectCategory { get; }
        IProjectCodeRepository ProjectCode { get; }
        IDepartmentRepository Department { get; }
        IPettyCashRepository PettyCash { get; }
        IJournalRepository Journal { get; }
        IJournalTempRepository JournalTemp { get; }
    }
}
