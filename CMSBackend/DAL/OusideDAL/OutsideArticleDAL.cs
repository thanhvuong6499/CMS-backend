using CMSBackend.Common;
using CMSBackend.Models.Entity.OutsideArticle;
using Common.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBackend.DAL
{
    public class OutsideArticleDAL
    {
        private OutsideArticleDAL()
        {

        }
        private static OutsideArticleDAL _instance;
        public static OutsideArticleDAL GetOutsideArticleDALInstance()
        {
            if (_instance == null)
            {
                _instance = new OutsideArticleDAL();
            }
            return _instance;
        }

        public ReturnResult<OutsideArticle> GetAllArticle()
        {
            var result = new ReturnResult<OutsideArticle>();
            DbProvider db;
            List<OutsideArticle> lst;
            try
            {
                result = new ReturnResult<OutsideArticle>();
                db = new DbProvider();
                lst = new List<OutsideArticle>();
                db.SetQuery("Outside_Article_GetAll", CommandType.StoredProcedure)
                    .SetParameter("ErrorCode", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                    .SetParameter("ErrorMessage", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                    .GetList<OutsideArticle>(out lst)
                    .Complete();
                db.GetOutValue("ErrorCode", out string outCode)
                    .GetOutValue("ErrorMessage", out string outMessage);
                // get out value
                if (outCode.ToString() != "0")
                {
                    result.Failed(outCode, outMessage);
                    return result;
                }
                else
                {
                    result.ItemList = lst;
                    result.ErrorCode = "0";
                    result.ErrorMessage = "";
                }
            }
            catch (Exception ex)
            {
                result.Failed("-1", ex.Message);
            }
            return result;
        }

    }
}
