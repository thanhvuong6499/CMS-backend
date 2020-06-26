using CMSBackend.Common;
using CMSBackend.DAL;
using CMSBackend.Models.Entity.OutsideArticle;
using Common.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBackend.BUS
{
    public class OutsideArticleBUS
    {
        private OutsideArticleDAL _outsideArticleDAL = OutsideArticleDAL.GetOutsideArticleDALInstance();
        private OutsideArticleBUS()
        {

        }
        private static OutsideArticleBUS _instance;
        public static OutsideArticleBUS GetOutsideArticleBUSInstance()
        {
            if (_instance == null)
            {
                _instance = new OutsideArticleBUS();
            }
            return _instance;
        }

        public ReturnResult<OutsideArticle> GetAll()
        {
            return _outsideArticleDAL.GetAllArticle();
        }


    }
}
