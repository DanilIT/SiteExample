using System;
using System.Linq;

namespace TestSite.Domain.Entities.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string Codeword);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
