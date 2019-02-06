We could not find a data exchange file at the path System.TypeLoadException: Method 'Initialize' in type 'Baseclass.Contrib.SpecFlow.Selenium.NUnit.GeneratorPlugin' from assembly 'Baseclass.Contrib.SpecFlow.Selenium.NUnit.SpecFlowPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' does not have an implementation.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
System.TypeLoadException: Method 'Initialize' in type 'Baseclass.Contrib.SpecFlow.Selenium.NUnit.GeneratorPlugin' from assembly 'Baseclass.Contrib.SpecFlow.Selenium.NUnit.SpecFlowPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' does not have an implementation.
   at System.Reflection.CustomAttribute._CreateCaObject(RuntimeModule pModule, IRuntimeMethodInfo pCtor, Byte** ppBlob, Byte* pEndBlob, Int32* pcNamedArgs)
   at System.Reflection.CustomAttribute.CreateCaObject(RuntimeModule module, IRuntimeMethodInfo ctor, IntPtr& blob, IntPtr blobEnd, Int32& namedArgs)
   at System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeModule decoratedModule, Int32 decoratedMetadataToken, Int32 pcaCount, RuntimeType attributeFilterType, Boolean mustBeInheritable, IList derivedAttributes, Boolean isDecoratedTargetSecurityTransparent)
   at System.Reflection.CustomAttribute.GetCustomAttributes(RuntimeAssembly assembly, RuntimeType caType)
   at System.Reflection.RuntimeAssembly.GetCustomAttributes(Type attributeType, Boolean inherit)
   at System.Attribute.GetCustomAttributes(Assembly element, Type attributeType, Boolean inherit)
   at System.Attribute.GetCustomAttribute(Assembly element, Type attributeType, Boolean inherit)
   at System.Attribute.GetCustomAttribute(Assembly element, Type attributeType)
   at TechTalk.SpecFlow.Generator.Plugins.GeneratorPluginLoader.LoadPlugin(PluginDescriptor pluginDescriptor)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugin(PluginDescriptor pluginDescriptor, IGeneratorPluginLoader pluginLoader, GeneratorPluginEvents generatorPluginEvents)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugins(ObjectContainer container, IGeneratorConfigurationProvider configurationProvider, SpecFlowConfigurationHolder configurationHolder, GeneratorPluginEvents generatorPluginEvents, SpecFlowProjectConfiguration specFlowConfiguration)
   at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: c:\users\jiriguel\appdata\local\microsoft\visualstudio\15.0_834915e8\extensions\2iekd0hv.v2q\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\JIRIGUEL\AppData\Local\Temp\1\tmpB3FA.tmp --outputdirectory C:\Users\JIRIGUEL\AppData\Local\Temp\1 --projectsettingsfile C:\Users\JIRIGUEL\AppData\Local\Temp\1\tmpB3F9.tmp
Working Directory: C:\Users\JIRIGUEL\source\repos\SeleniumSpecflow\packages\SpecFlow.2.4.1\tools