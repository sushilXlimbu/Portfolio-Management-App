namespace Portfoliowebsite.Interface
{
    public interface IBase<T>
    {
        public T SelectedData(Guid? id);
    }
}
