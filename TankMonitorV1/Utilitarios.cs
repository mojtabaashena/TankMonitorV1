using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1
{
    public static  class Utilitarios
    {
        public static string IsSelected(this Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper htmlHelper, string controllers, string actions, string cssClass = "active")
        {
            string currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
            string currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;

            IEnumerable<string> acceptedActions = (actions ?? currentAction).Split(',');
            IEnumerable<string> acceptedControllers = (controllers ?? currentController).Split(',');

            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
                cssClass : String.Empty;
        }
    }
}
