## Cross-Tenant Synchronization and Access Management

### Step-by-Step Configuration Guide

#### **Step 1: Configure Cross-Tenant Synchronization**
In the source tenant, configure cross-tenant synchronization to provision internal accounts in the source tenant as external accounts in the target tenant.

When users are assigned to the cross-tenant synchronization service principal, they are automatically provisioned into the target tenant. As they are removed from the configuration, their accounts are automatically deprovisioned. Utilize attribute mappings to add directory extension attributes to users indicating their roles, such as SOC administrators. This attribute helps in skipping additional configuration steps by providing automatic access to necessary roles in the target tenant.

#### **Step 2: Create Access Packages in the Source Tenant**
Create an access package in the source tenant that includes the cross-tenant synchronization service principal as a resource.

This enables the users who are granted access to the package to also be assigned to the cross-tenant synchronization service principal. Regularly review and time-limit these assignments to ensure only necessary users have continued access.

#### **Step 3: Create Access Packages in the Target Tenant**
Create access packages in the target tenant specifically tailored for roles involved in incident investigations.

- **Autoassigned Access Package:** Ideal for users needing the Security Reader role.
- **Request-Based Access Package:** For users requiring Security Operator or Security Administrator roles.

Following setup, SOC users can navigate to a specific URL (myaccess.microsoft.com) to request access. This access, once granted, ensures users are provisioned roles in the target tenant(s) necessary for their responsibilities. Users can request additional access as needed and are deprovisioned from roles they no longer require after an access review.

### Topology 2

In this topology, the target tenant's administrator defines the access packages and resources that source users can request access to. If there is a need to restrict access selectively within the source tenant's user base, a cross-tenant access policy supplemented by an access package can effectively block all access except for designated groups included in specific access packages. This setup ensures stringent access control tailored to organizational needs.