1. In the source tenant, select Provisioning and expand the Settings section.

![Outbound access settings - Contoso > Cross-tenant synchronization | Configurations > Fabrikam to Contoso Fabrikam to Contoso | Provisioning Fabrikam - Microsoft Entra ID ✅ « ❌ Save ✅ Discard Overview v Admin Credentials Provision on demand Manage V Mappings Users and groups Provisioning Settings Expression builder Activity ❌ Send an email notification when a failure occurs Audit logs ✅ Prevent accidental deletion 0 Accidental deletion threshold \* Provisioning logs 500 Insights Scope ❌ Sync only assigned users and groups V Troubleshooting + Support New support request Provisioning Status O On Off +" ](figures/0)

```mermaid
graph TD;
    A["Outbound access settings - Contoso"] --> B["Cross-tenant synchronization"]
    B --> C["Configurations > Fabrikam to Contoso"]
    C --> D["Fabrikam to Contoso | Provisioning"]
    D --> E["Overview"]
    D --> F["Admin Credentials"]
    D --> G["Provision on demand"]
    D --> H["Mappings"]
    D --> I["Users and groups"]
    D --> J["Provisioning"]
    D --> K["Expression builder"]
    D --> L["Activity"]
    L --> M["Send an email notification when a failure occurs"]
    L --> N["Audit logs"]
    L --> O["Prevent accidental deletion"]
    L --> P["Accidental deletion threshold * Provisioning logs 500 Insights Scope"]
    P --> Q["Sync only assigned users and groups"]
    P --> R["Troubleshooting + Support"]
    R --> S["New support request"]
    P --> T["Provisioning Status On Off"]
```

2. Check the Send an email notification when a failure occurs check box.

3. In the Notification Email box, enter the email address of a person or group who should receive provisioning error notifications.

Email notifications are sent within 24 hours of the job entering quarantine state. For custom alerts, see Understand how provisioning integrates with Azure Monitor logs.

4. To prevent accidental deletion, select Prevent accidental deletion and specify a threshold value. By default, the threshold is set to 500.

For more information, see Enable accidental deletions prevention in the Microsoft Entra provisioning service.

5. Select Save to save any changes.

Step 11: Test provision on demand

![Logo](figures/1) 

Source tenant