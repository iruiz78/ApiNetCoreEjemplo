namespace WebApplication9.Repocitorio
{
    public interface IDBGestor<T>
    {
        public T Add(T model);
        public T Get(int id);
        public List<T> Get();
        public bool Delete(T model);
    }
}
