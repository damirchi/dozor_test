/*
 * Created by: 
 * Created: Friday, April 06, 2007
 */

using System;

namespace GFK.Business
{
    public interface IUnitOfWork : IDisposable
    {
        bool IsDirty { get;}
        void Commit();
    }
}