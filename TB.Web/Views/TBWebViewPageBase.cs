using Abp.Web.Mvc.Views;

namespace TB.Web.Views
{
    public abstract class TBWebViewPageBase : TBWebViewPageBase<dynamic>
    {

    }

    public abstract class TBWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TBWebViewPageBase()
        {
            LocalizationSourceName = TBConsts.LocalizationSourceName;
        }
    }
}