using Razor.Models;
using System;
using System.Collections.Generic;

namespace Razor.Services
{
    public interface IResourceRepository
    {
        IEnumerable<resPage> GetAllResources();
        IEnumerable<resPage> searchPhrase(string phrase);
        resPage GetResPage(int id);
        resPage Update(resPage updatedResource);
        resPage Add(resPage newResource);
        resPage Delete(int id);
    }
}
