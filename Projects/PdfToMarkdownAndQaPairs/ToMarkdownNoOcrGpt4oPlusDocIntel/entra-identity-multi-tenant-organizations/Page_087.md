Configure cross-tenant synchronization
===

Article · 03/11/2024

This article describes the steps to configure cross-tenant synchronization using the Microsoft Entra admin center. When configured, Microsoft Entra ID automatically provisions and de-provisions B2B users in your target tenant. For important details on what this service does, how it works, and frequently asked questions, see Automate user provisioning and deprovisioning to SaaS applications with Microsoft Entra ID.

[Diagram illustrating the cross-tenant synchronization process between the Source tenant and Target tenant. The Source tenant has internal users UserS1, UserS2, and UserS3 and is configured to automatically redeem invitations for outbound access settings. The Target tenant has internal users UserT1, UserT2, UserT3, and GroupT1, and external users UserS1 and UserS3 with inbound access settings allowing users to sync into this tenant and automatically redeem invitations. Scoping filters and attribute mappings between these entities are also shown.]

```mermaid
graph TD;
    source_tenant_A["Source tenant"];
    target_tenant_B["Target tenant"];
    source_config["Configuration"];
    
    source_internal_A["Internal UserS1\nUserS2\nUserS3"];
    source_outbound_access["Outbound access settings:\n Automatically redeem invitations"];
    source_tenant_A --> source_internal_A;
    source_tenant_A --> source_outbound_access;
    
    cross_tenant_sync["Cross-tenant synchronization"];
    source_tenant_A --> cross_tenant_sync;
    cross_tenant_sync --> target_tenant_B;

    target_internal_B["Internal UserT1\nUserT2\nUserT3\nGroupT1"];
    target_external_B["External UserS1\nUserS3"];
    target_inbound_access["Inbound access settings:\n Allow users sync into this tenant\n Automatically redeem invitations"];
    target_tenant_B --> target_internal_B;
    target_tenant_B --> target_external_B;
    target_tenant_B --> target_inbound_access;
    
    scoping_filters["Scope UserS1\nUserS3\nScoping filters department EQUALS Marketing"];
    attribute_mappings["Attribute mappings accountEnabled=accountEnabled\nemployeeld=employeeld\nuserPrincipalName=userPrincipalName\n+ extensionName=companyName"];
    source_config --> scoping_filters;
    source_config --> attribute_mappings;
    cross_tenant_sync --> source_config;
```

# Learning objectives

By the end of this article, you'll be able to:

- Create B2B users in your target tenant
- Remove B2B users in your target tenant
- Keep user attributes synchronized between your source and target tenants

Prerequisites

[Visual representation of the source tenant]