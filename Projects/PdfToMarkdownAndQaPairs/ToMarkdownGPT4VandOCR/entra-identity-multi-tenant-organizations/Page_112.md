## Users are skipped from synchronization. The scoping step includes the following filter with status false: "Filter external users.alternativeSecuritylds EQUALS 'None'"

### Cause

If SMS sign-in is enabled for a user, they will be skipped by the provisioning service.

### Solution

Disable SMS Sign-in for the users. The script below shows how you can disable SMS Sign-in using PowerShell.

### PowerShell

#### Disable SMS Sign-in options for the users

#### Import module

```powershell
Install-Module Microsoft.Graph.Users.Actions
Install-Module Microsoft.Graph.Identity.SignIns
Import-Module Microsoft.Graph.Users.Actions

Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All",
"UserAuthenticationMethod.Read.All", "UserAuthenticationMethod.ReadWrite", "Us
erAuthenticationMethod.ReadWrite.All"
```

#### The value for phoneAuthenticationMethodId is 3179e48a-750b-4051-897c-87b9720928f7

```powershell
$phoneAuthenticationMethodId = "3179e48a-750b-4051-897c-87b9720928f7"
```

#### Get the User Details

```powershell
$userId = "objectid_of_the_user_in_Azure_AD"
```

#### validate the value for SmsSignInState

```powershell
$smssignin = Get-MgUserAuthenticationPhoneMethod -UserId $userId
{
if($smssignin. SmsSignInState -eq "ready"){
    #### Disable Sms Sign-In for the user is set to ready
    Disable-MgUserAuthenticationPhoneMethodSmsSignIn -UserId $userId -
    PhoneAuthenticationMethodId $phoneAuthenticationMethodId
    Write-Host "SMS sign-in disabled for the user" -ForegroundColor Green
}
else{
    Write-Host "SMS sign-in status not set or found for the user " - 
    ForegroundColor Yellow
}
```
