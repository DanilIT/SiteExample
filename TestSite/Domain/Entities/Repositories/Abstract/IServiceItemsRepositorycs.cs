using System;
using System.Linq;
using TestSite.Domain.Entities;

namespace TestSite.Domain.Entities.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);

    }
}
