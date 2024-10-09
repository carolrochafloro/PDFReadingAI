using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using Contracts;

namespace Entities;
public class Property
{
    public int Code { get; set; }
    public PropertyAddress Address { get; set; }
}
