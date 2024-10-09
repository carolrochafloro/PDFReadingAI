using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;
public class Contract
{
    public int Id { get; set; }
    public int TenantId { get; set; }
    public int PropertyId { get; set; }
    public DateOnly Start { get; set; }
    public int DurationInMonths { get; set; }
    public DateOnly DueDateForPayment { get; set; }
    public int RentPrice { get; set; }

}
