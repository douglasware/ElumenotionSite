## Application Provisioning in Quarantine Status

If provisioning seems to be in an unhealthy state, the configuration will go into quarantine. For more information, see [Application provisioning in quarantine status](#).

### Overview Tab
- **Current cycle status**
  - Initial cycle completed: **100% complete**
- **Users**
  - Total Users: **2**
- **View provisioning logs**

### Statistics to Date
- View provisioning details
- View technical information

### Select Provisioning Logs

Select **Provisioning logs** to determine which users have been provisioned successfully or unsuccessfully. By default, the logs are filtered by the service principal ID of the configuration. For more information, see [Provisioning logs in Microsoft Entra ID](#).

```plaintext
| Date       | Identity Name     | Source System      | Action | Target System         | Status |
|------------|-------------------|--------------------|--------|-----------------------|--------|
| 1/22/2024  | Display Name Here | Azure Active Directory | Update | Azure Active Directory | Success|
| 1/22/2024  | Display Name Here | Azure Active Directory | Create | Azure Active Directory | Success|
| 1/22/2024  | Display Name Here | Azure Active Directory | Other  | Azure Active Directory | Skipped|
```

### Select Audit Logs

Select **Audit logs** to view all logged events in Microsoft Entra ID. For more information, see [Audit logs in Microsoft Entra ID](#).