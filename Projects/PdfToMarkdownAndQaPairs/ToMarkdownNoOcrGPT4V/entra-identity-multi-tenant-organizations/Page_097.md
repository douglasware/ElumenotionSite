## Fabricam to Contoso | Provisioning

### Step-by-Step Guide

#### 1. Overview
In the **Fabricam - Microsoft Entra ID** configuration, set up the provisioning to Contoso by following the instructions below.

#### 2. Admin Credentials
Ensure the appropriate admin credentials are set to manage the mappings between Fabricam and Contoso.

#### 3. Attribute Mapping
Navigate to the **Provision Microsoft Entra ID Users** setting under the **Mappings** section to adjust how data should flow between Microsoft Entra ID and Azure Active Directory.

- **Enabled**: Yes
- **Restore default mappings**: Unchecked

#### 4. Provisioning Settings
Make sure the provisioning status is set to **On** for continuous synchronization.

#### 5. Source Object Scope
Select **All records** under the **Source Object Scope** to ensure all user records are included in the synchronization process.

#### 6. Target Object Actions
Specify actions for target objects:
- **Create**
- **Update**
- **Delete**

Choose these options based on the desired outcome for records that do not match between source and target systems.

#### 7. Adding Scoping Filters
On the **Source Object Scope** page, select **Add scoping filter** to apply filters that define which users are included in the provisioning process.