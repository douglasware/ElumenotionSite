Attributes and objects
===

The following attributes and objects aren't supported:

· Multivalued attributes.

· Reference attributes (for example, manager).

· Groups.

· Complex anchors (for example, ObjectTypeName+UserName).

· Attributes that have characters such as "." or "["

· Binary attributes.

· On-premises applications are sometimes not federated with Microsoft Entra ID and require local passwords. The on-premises provisioning preview doesn't support password synchronization. Provisioning initial one-time passwords is supported. Ensure that you're using the Redact function to redact the passwords from the logs. In the SQL and LDAP connectors, the passwords aren't exported on the initial call to the application, but rather a second call with set password.


SSL certificates
===

The Microsoft Entra ECMA Connector Host currently requires either an SSL certificate to be trusted by Azure or the provisioning agent to be used. The certificate subject must match the host name the Microsoft Entra ECMA Connector Host is installed on.


Anchor attributes
===

The Microsoft Entra ECMA Connector Host currently doesn't support anchor attribute changes (renames) or target systems, which require multiple attributes to form an anchor.


Attribute discovery and mapping
===

The attributes that the target application supports are discovered and surfaced in the Microsoft Entra admin center in Attribute Mappings. Newly added attributes will continue to be discovered. If an attribute type has changed, for example, string to Boolean, and the attribute is part of the mappings, the type won't change automatically in the Microsoft Entra admin center. Customers will need to go into advanced settings in mappings and manually update the attribute type.


Provisioning agent
===