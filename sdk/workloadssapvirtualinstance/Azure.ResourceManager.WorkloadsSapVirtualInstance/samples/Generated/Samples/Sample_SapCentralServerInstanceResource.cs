// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.WorkloadsSapVirtualInstance.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Samples
{
    public partial class Sample_SapCentralServerInstanceResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SapCentralServerInstancesGet()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_Get.json
            // this example is just showing the usage of "SAPCentralServerInstance_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            SapCentralServerInstanceResource result = await sapCentralServerInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapCentralServerInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SapCentralServerInstancesDelete()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_Delete.json
            // this example is just showing the usage of "SAPCentralServerInstance_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            await sapCentralServerInstance.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SapCentralServerInstancesUpdate()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_Update.json
            // this example is just showing the usage of "SAPCentralServerInstance_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "6d875e77-e412-4d7d-9af4-8895278b4443";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            SapCentralServerInstancePatch patch = new SapCentralServerInstancePatch
            {
                Tags =
{
["tag1"] = "value1"
},
            };
            SapCentralServerInstanceResource result = await sapCentralServerInstance.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SapCentralServerInstanceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_StartTheSAPCentralServicesInstance()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_StartInstance.json
            // this example is just showing the usage of "SAPCentralServerInstances_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            StartSapInstanceContent content = new StartSapInstanceContent();
            ArmOperation<OperationStatusResult> lro = await sapCentralServerInstance.StartAsync(WaitUntil.Completed, content: content);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Start_StartTheVirtualMachineSAndTheSAPCentralServicesInstanceOnIt()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_StartInstanceVM.json
            // this example is just showing the usage of "SAPCentralServerInstances_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            StartSapInstanceContent content = new StartSapInstanceContent
            {
                StartVm = true,
            };
            ArmOperation<OperationStatusResult> lro = await sapCentralServerInstance.StartAsync(WaitUntil.Completed, content: content);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopTheSAPCentralServicesInstance()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_StopInstance.json
            // this example is just showing the usage of "SAPCentralServerInstances_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            StopSapInstanceContent content = new StopSapInstanceContent
            {
                SoftStopTimeoutSeconds = 1200L,
            };
            ArmOperation<OperationStatusResult> lro = await sapCentralServerInstance.StopAsync(WaitUntil.Completed, content: content);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Stop_StopTheSAPCentralServicesInstanceAndItsUnderlyingVirtualMachineS()
        {
            // Generated from example definition: 2024-09-01/SapCentralInstances_StopInstanceVM.json
            // this example is just showing the usage of "SAPCentralServerInstances_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SapCentralServerInstanceResource created on azure
            // for more information of creating SapCentralServerInstanceResource, please refer to the document of SapCentralServerInstanceResource
            string subscriptionId = "8e17e36c-42e9-4cd5-a078-7b44883414e0";
            string resourceGroupName = "test-rg";
            string sapVirtualInstanceName = "X00";
            string centralInstanceName = "centralServer";
            ResourceIdentifier sapCentralServerInstanceResourceId = SapCentralServerInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            SapCentralServerInstanceResource sapCentralServerInstance = client.GetSapCentralServerInstanceResource(sapCentralServerInstanceResourceId);

            // invoke the operation
            StopSapInstanceContent content = new StopSapInstanceContent
            {
                DeallocateVm = true,
            };
            ArmOperation<OperationStatusResult> lro = await sapCentralServerInstance.StopAsync(WaitUntil.Completed, content: content);
            OperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
