using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Cozee_V4
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed class GameSettings : ApplicationSettingsBase
    {
        private static GameSettings defaultInstance = (GameSettings)SettingsBase.Synchronized((SettingsBase)new GameSettings());

        public static GameSettings Default
        {
            get
            {
                GameSettings defaultInstance = GameSettings.defaultInstance;
                return defaultInstance;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string Name
        {
            get => (string)this[nameof(Name)];
            set => this[nameof(Name)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string Path
        {
            get => (string)this[nameof(Path)];
            set => this[nameof(Path)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]

        public string Version
        {
            get => (string)this[nameof(Version)];
            set => this[nameof(Path)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string j
        {
            get => (string)this[nameof(j)];
            set => this[nameof(j)] = (object)value;
        }
    }
}