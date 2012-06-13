/*
 * Created by: 
 * Created: Friday, April 06, 2007
 */


namespace GFK.Business
{
    public interface IUnitOfWorkManager
    {
        IUnitOfWork Create(bool transactional);
    }
}