using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependableDateTime
{
    class DateTimeHunter
    {
        //public IEnumerable<MethodInfo> FindAllUsages()
        //{
        //   // var methodBase = typeof(DateTime).GetRuntimeProperty("Now");

        //    var token = typeof(DateTime).GetRuntimeProperty("TargetProp").GetMethod;

        //    // const BindingFlags findAll = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic |
        //    //                              BindingFlags.Instance | BindingFlags.Static;

        //    AppDomain.CurrentDomain.GetAssemblies();
        //    var references =
        //        typeof(DateTimeHunter).a.ManifestModule.GetTypes()
        //            .SelectMany(x => x.GetMethods(Int32.MaxValue).Cast<MethodBase>().Union(x.GetConstructors(Int32.MaxValue)))
        //            .ToDictionary(y => y, y => y.GetMethodUsageOffsets(token).ToArray())
        //            .Where(z => z.Value.Length > 0).ToList();

        //}
    }
}
