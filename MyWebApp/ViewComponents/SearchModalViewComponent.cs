/* Structure of a View Component:

1. View Component Class: 
    Defines the logic of the view component. Just like this file.
2. View Component View: 
    Defines the view of the view component. 
    Its file structure must be `Views/Shared/Components/{ComponentName}/{ViewName}.cshtml`.
3. Invoking the View Component: 
    Invoke the view component in other views using `@await Component.InvokeAsync("{ComponentName}")`.

*/ 

using Microsoft.AspNetCore.Mvc;

public class SearchModalViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}