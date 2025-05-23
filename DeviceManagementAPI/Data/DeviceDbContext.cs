using Microsoft.EntityFrameworkCore;
using DeviceManagementAPI.Models;

namespace DeviceManagementAPI.Data;
public class DeviceDbContext : DbContext
{
    public DeviceDbContext(DbContextOptions<DeviceDbContext> options) : base(options)
    {

    }
    public DbSet<Device> Devices { get; set;  }
}