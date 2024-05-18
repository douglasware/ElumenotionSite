# Enable accidental deletions prevention in the Microsoft Entra provisioning service

Article · 10/23/2023

The Microsoft Entra provisioning service includes a feature to help avoid accidental deletions. This feature ensures that users aren't disabled or deleted in an application unexpectedly.

You use accidental deletions to specify a deletion threshold. Anything above the threshold that you set requires an admin to explicitly allow the processing of the deletions.


# Configure accidental deletion prevention

To enable accidental deletion prevention:

1\. Sign in to the Microsoft Entra admin center 7 as at least a Application Administrator.

2\. Browse to Identity > Applications > Enterprise applications.

3\. Select your application.

4\. Select Provisioning and then on the provisioning page select Edit provisioning.

1\. Under Settings, select the Prevent accidental deletions check box and specify a deletion threshold.

2\. Ensure the Notification Email address is completed. If the deletion threshold is met, an email is sent.

3\. Select Save to save the changes.

When the deletion threshold is met, the job goes into quarantine, and a notification email is sent. The quarantined job can then be allowed or rejected. To learn more about quarantine behavior, see Application provisioning in quarantine status.


# Recovering from an accidental deletion

When you encounter an accidental deletion, you see it on the provisioning status page. It says Provisioning has been quarantined. See quarantine details for more information .
