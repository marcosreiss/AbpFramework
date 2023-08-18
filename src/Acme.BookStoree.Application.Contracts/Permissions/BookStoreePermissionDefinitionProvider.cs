using Acme.BookStoree.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Acme.BookStoree.Permissions;
using Acme.BookStore.Permissions;

namespace Acme.BookStoree.Permissions;

public class BookStoreePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(BookStoreePermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(BookStoreePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(BookStoreePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(BookStoreePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(BookStoreePermissions.Books.Delete, L("Permission:Books.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookStoreeResource>(name);
    }
}
