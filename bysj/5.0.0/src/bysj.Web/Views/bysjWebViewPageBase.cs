using Abp.Web.Mvc.Views;

namespace bysj.Web.Views
{
    public abstract class bysjWebViewPageBase : bysjWebViewPageBase<dynamic>
    {

    }

    public abstract class bysjWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected bysjWebViewPageBase()
        {
            LocalizationSourceName = bysjConsts.LocalizationSourceName;
        }
    }
}