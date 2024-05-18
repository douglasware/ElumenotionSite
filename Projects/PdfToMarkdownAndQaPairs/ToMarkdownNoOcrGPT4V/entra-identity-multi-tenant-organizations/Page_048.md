## Diagram Overview

The diagram illustrates the integration process of recently acquired tenants into a parent company's systems, showing different types of applications and their relationship with HR and Active Directory.

### Flowchart Description

- **HR**: Serves as the starting point.
- **Active Directory**: Central management for user authentication.
- **Applications Covered**:
  - **SaaS apps**: Includes third-party services such as Salesforce and AWS.
  - **Microsoft apps**: Involves typical Microsoft suite applications.
  - **On-premises apps**: Covers internally hosted applications like internal SQL databases.

## Separate collaboration and resource tenants (user hub)

As organizations scale their usage of Azure, they often create dedicated tenants for managing critical Azure resources. Meanwhile, they rely on a central hub tenant for user provisioning. This model empowers administrators in the hub tenant to establish central security and governance policies while granting development teams greater autonomy and agility to deploy required Azure resources. Cross-tenant synchronization supports this topology by enabling administrators to provision a subset of users into the spoke tenants and manage the lifecycle of those users.