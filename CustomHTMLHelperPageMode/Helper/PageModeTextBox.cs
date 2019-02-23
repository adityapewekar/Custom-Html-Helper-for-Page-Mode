using System;
using System.Collections.Generic;
using System.Web.Mvc.Html;

namespace CustomHTMLHelperPageMode.Helper
{
    public static class PageModeTextBox
    {
        public static System.Web.Mvc.MvcHtmlString PageModeTextBoxFor<TModel, TValue>
       (this System.Web.Mvc.HtmlHelper<TModel> html,
       System.Linq.Expressions.Expression<Func<TModel, TValue>> expression,
       object htmlAttributes = null, bool readOnly = false)
        {

            System.Web.Mvc.ModelMetadata oModelMetadata =
                System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

            Dictionary<string, object> dynamicAttribute = new Dictionary<string, object>();

            foreach(var prop in htmlAttributes.GetType().GetProperties())
            {
                if(prop.Name== "htmlAttributes")
                {
                    var propValue = prop.GetValue(htmlAttributes, null);
                    foreach (var innerProp in propValue.GetType().GetProperties())
                    {
                        dynamicAttribute.Add(innerProp.Name, innerProp.GetValue(propValue, null));
                    }
                }
                else
                {
                    dynamicAttribute.Add(prop.Name, prop.GetValue(prop));
                }
            }
            

            if (html.ViewBag.PageMode == "View")
            {
                if (dynamicAttribute.ContainsKey("readonly") == false)
                {
                    dynamicAttribute.Add("readonly", "read-only");
                }
            }

     

            return (html.TextBoxFor(expression, dynamicAttribute));
        }
    }
}