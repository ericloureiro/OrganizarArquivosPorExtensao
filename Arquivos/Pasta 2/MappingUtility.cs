using System;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity;
using System.Linq;

namespace MXM.Framework.Core.DependencyInjection
{
    public static class MappingUtility
    {
        public static void Configure(String configurationFilePath, String configuredContainerName)
        {
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = configurationFilePath };
            System.Configuration.Configuration configuration =
                ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            var unitySection = (UnityConfigurationSection)configuration.GetSection("unity");
            unitySection.Configure(DependencyInjectionContainer.Current, configuredContainerName);
        }

        public static void MapType(Type from, Type to)
        {
            DependencyInjectionContainer.Current.RegisterType(from, to, null,
                new TransientLifetimeManager(), new InjectionMember[] { });
        }

        public static void MapFixedInstance(Type type, Object fixedInstance)
        {
            if (DependencyInjectionFactory.FixedInstances.ContainsKey(type))
            {
                UnmapFixedInstance(type);
            }
            DependencyInjectionFactory.FixedInstances.Add(type, fixedInstance);
        }

        public static void UnmapFixedInstance(Type type)
        {
            DependencyInjectionFactory.FixedInstances.Remove(type);
        }
    }
}
