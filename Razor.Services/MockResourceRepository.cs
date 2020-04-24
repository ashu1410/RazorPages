using Razor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Razor.Services
{
    public class MockResourceRepository : IResourceRepository
    {
        private List<resPage> _resourceList;

        public MockResourceRepository()
        {
            _resourceList = new List<resPage>()
            {
                new resPage() { Link="https://docs.microsoft.com/en-us/windows-server/",Title="Dokumentacja Windows Server", ID_res=1, resCat=ResCategory.Administration ,Img_path="~/resources/os1.jpg"},
                new resPage() { Link="https://kubernetes.io/pl/docs/home/",Title="Dokumentacja Kubernetes" ,ID_res=1, resCat=ResCategory.Administration,Img_path="~/resources/os1.jpg" },
                new resPage() { Link="https://docs.microsoft.com/en-us/windows-server/identity/ad-ds/active-directory-domain-services",Title="Dokumentacja Windows Active Directory", ID_res=1, resCat=ResCategory.Administration,Img_path="~/resources/os1.jpg"},
                new resPage() { Link="https://docs.docker.com/",Title="Dokumentacja Docker", ID_res=1,  resCat=ResCategory.Administration,Img_path="~/resources/os1.jpg"},
                new resPage() { Link="https://docs.microsoft.com/pl-pl/aspnet/core/?view=aspnetcore-3.1",Title="Dokumentacja ASP.NET Core", ID_res=2, resCat=ResCategory.Web ,Img_path="~/resources/web.jpg"},
                new resPage() { Link="https://getbootstrap.com/docs/4.1/getting-started/introduction/",Title="Dokumentacja Bootstrap" ,ID_res=2, resCat=ResCategory.Web,Img_path="~/resources/web.jpg" },
                new resPage() { Link="https://angular.io/docs",Title="Dokumentacja Angular", ID_res=2, resCat=ResCategory.Web,Img_path="~/resources/web.jpg"},
                new resPage() { Link="https://developer.mozilla.org/pl/docs/Web/JavaScript",Title="Dokumentacja JavaScript", ID_res=2,  resCat=ResCategory.Web,Img_path="~/resources/web.jpg"},
                new resPage() { Link="https://www.postgresql.org/docs/",Title=" Dokumentacja PostgreSQL", ID_res=3, resCat=ResCategory.Database ,Img_path="~/resources/db.png"},
                new resPage() { Link="https://nodejs.org/en/docs/",Title="Dokumentacja Node.js" ,ID_res=3, resCat=ResCategory.Database,Img_path="~/resources/db.png" },
                new resPage() { Link="https://docs.oracle.com/en/",Title="Dokumentacja Oracle", ID_res=3, resCat=ResCategory.Database,Img_path="~/resources/db.png"},
                new resPage() { Link="https://docs.microsoft.com/en-us/sql/?view=sql-server-ver15",Title="Dokumentacja SQL", ID_res=3,  resCat=ResCategory.Database,Img_path="~/resources/db.png"},
                new resPage() { Link="https://docs.microsoft.com/pl-pl/dotnet/csharp/",Title="Dokumentacja C#", ID_res=4, resCat=ResCategory.Language ,Img_path="~/resources/desktop.jpg"},
                new resPage() { Link="https://docs.oracle.com/javase/7/docs/api/",Title="Dokumentacja Java" ,ID_res=4, resCat=ResCategory.Language,Img_path="~/resources/desktop.jpg" },
                new resPage() { Link="https://docs.python.org/3/",Title="Dokumentacja Python", ID_res=4, resCat=ResCategory.Language,Img_path="~/resources/desktop.jpg"},
                new resPage() { Link="https://devdocs.io/c/",Title="Dokumentacja C", ID_res=4,  resCat=ResCategory.Language,Img_path="~/resources/desktop.jpg"},
            };   
        }

        public resPage Add(resPage newResource)
        {
            newResource.ID_res = _resourceList.Max(r => r.ID_res) + 1;
            _resourceList.Add(newResource);
            return newResource;
        }

        public resPage Delete(int id)
        {
            resPage resToDel = _resourceList.FirstOrDefault(i => i.ID_res == id);
            if ( resToDel != null)
            {
                _resourceList.Remove(resToDel);
            }
            return resToDel;
        }

        public IEnumerable<resPage> GetAllResources()
        {
            return _resourceList;
        }

        public resPage GetResPage(int id)
        {
            return _resourceList.FirstOrDefault(e => e.ID_res == id);
        }

        public IEnumerable<resPage> searchPhrase(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return _resourceList;
            }
            else
            {
                phrase = (phrase.ToLower());
                return _resourceList.Where(r => r.Title.ToLower().Contains(phrase));
            }
        }

        public resPage Update(resPage updatedResource)
        {
            resPage _resPage = _resourceList.FirstOrDefault(r => r.ID_res == updatedResource.ID_res);
            if (_resPage != null)
            {
                _resPage.Link = updatedResource.Link;
                _resPage.Title = updatedResource.Title;
                _resPage.resCat = updatedResource.resCat;
                _resPage.Img_path = updatedResource.Img_path;
            }
            return _resPage;
        }
    }
}
