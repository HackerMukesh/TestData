<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <section name="microsoft.web.services3" type="Microsoft.Web.Services3.Configuration.WebServicesConfiguration, Microsoft.Web.Services3, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />    
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <connectionStrings>
    <add name="FareportalLogsEntity" connectionString="metadata=res://*/EF.LCCPNRDetail.csdl|res://*/EF.LCCPNRDetail.ssdl|res://*/EF.LCCPNRDetail.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=172.22.10.31;initial catalog=FareportalLogs;persist security info=True;user id=fareportal;password=fareportal;multipleactiveresultsets=True;application name=EntityFramework&quot;" providerName="System.Data.EntityClient" /></connectionStrings>
    <system.web>
    <webServices>
      <soapServerProtocolFactory type="Microsoft.Web.Services3.WseProtocolFactory, Microsoft.Web.Services3, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
      <!--<soapExtensionTypes>
        <add type="TraceExtension,App_Code" priority="1" group="0"/>      
      </soapExtensionTypes>-->
    </webServices>
   
  </system.web>
  <microsoft.web.services3>
    <diagnostics> 
      <trace enabled="true" input="InputTrace.webinfo" output="OutputTrace.webinfo" />
    </diagnostics>
    <security></security>
    <policy fileName="wse3policyCache.config" />
  </microsoft.web.services3>
  <system.serviceModel>
    <bindings>
    </bindings>
    <behaviors>
      <serviceBehaviors>
        <behavior>
          <!-- To avoid disclosing metadata information, set the value below to false and remove the metadata endpoint above before deployment -->
          <serviceMetadata httpGetEnabled="true" />
          <!-- To receive exception details in faults for debugging purposes, set the value below to true.  Set to false before deployment to avoid disclosing exception information -->
          <serviceDebug includeExceptionDetailInFaults="true" />
        </behavior>
      </serviceBehaviors>
    </behaviors>
    <serviceHostingEnvironment multipleSiteBindingsEnabled="true" minFreeMemoryPercentageToActivateService="0" />
  </system.serviceModel>
  <system.webServer>
    <modules runAllManagedModulesForAllRequests="true" />
  </system.webServer>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-6.0.0.0" newVersion="6.0.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
  <entityFramework>
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.LocalDbConnectionFactory, EntityFramework">
      <parameters>
        <parameter value="mssqllocaldb" />
      </parameters>
    </defaultConnectionFactory>
  
  </entityFramework>
</configuration>
<!--ProjectGuid: {2DEE003E-2A98-4BFD-B790-4FFCCFE20782}-->
