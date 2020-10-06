using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Interfaces
{
    public interface IDatabaseContext
    {
        DbSet<Tasks> task { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
