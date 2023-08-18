using Volo.Abp.Settings;

namespace Acme.BookStoree.Settings;

public class BookStoreeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreeSettings.MySetting1));
    }
}
