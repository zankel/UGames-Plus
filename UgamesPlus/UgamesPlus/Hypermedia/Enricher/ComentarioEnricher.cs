using Microsoft.AspNetCore.Mvc;
using UgamesPlus.Data.VO;
using UgamesPlus.Hypermedia.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgamesPlus.Hypermedia.Enricher
{
    public class ComentarioEnricher : ContentResponseEnricher<ComentarioVO>
    {
        private readonly object _lock = new object();
        protected override Task EnrichModel(ComentarioVO content, IUrlHelper urlHelper)
        {
            var path = "api/comentario/v1";
            string link = GetLink(content.Id, urlHelper, path);


            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });
            return null;
        }

        private string GetLink(long id, IUrlHelper urlHelper, string path)
        {
            lock (_lock)
            {
                var url = new { controller = path, id = id };
                return new StringBuilder(urlHelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();
            };
        }
    }
}
