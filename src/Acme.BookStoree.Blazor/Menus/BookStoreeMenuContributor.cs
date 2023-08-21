using System.Threading.Tasks;
using Acme.BookStoree.Localization;
using Acme.BookStoree.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.BookStoree.Blazor.Menus;

public class BookStoreeMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<BookStoreeResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                BookStoreeMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        // ---------------- codigo do tutorial  -----------------------
        context.Menu.AddItem(
             new ApplicationMenuItem(
                "BooksStore",
                l["Menu:BookStore"],
                icon: "fa fa-book"
         ).AddItem(
            new ApplicationMenuItem(
                "BooksStore.Books",
                 l["Menu:Books"],
                 url: "/books",
                 icon: "fa fa-book-open"
                )
            ).AddItem(
                new ApplicationMenuItem(
                    "Bookstore.Autors",
                    l["Autors"],
                    url: "/autors",
                    icon: "fa fa-pen"
                    )
             )   
        );
        //------------------------------------------------------------

        //context.Menu.AddItem(
        //    new ApplicationMenuItem(
        //        "Autors",
        //        l["Menu:Autors"],
        //        icon: "fal fa-pen-line"
        //    ).AddItem(
        //        new ApplicationMenuItem(
        //            "Bookstore.Autors",
        //            l["Menu: Autors"], 
        //            url: "/autors"
        //            )
        //        )
        //    );
        
        return Task.CompletedTask;

    }
}
