using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Interfaces
{
    public interface ISafeJsonSerializable
    {
        string GetOriginalJsonString();
        string GetModifiedJsonString();
    }
}
