using GlamBar.Domain.Common.Entities;
using GlamBar.Domain.Enums;

namespace GlamBar.Domain.Entities;

public class User : AuditableEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public Role Roles { get; set; } = Role.Customer;
}