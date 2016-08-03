using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SyncSoft.Payment.IOC
{
    public class Container2
    {
        private static readonly Dictionary<Type, Type> iocMap = new Dictionary<Type, Type>();

        public static void Register<TYpetoResolve, TResolvedType>()
        {
            if (iocMap.ContainsKey(typeof(TYpetoResolve)))
            {
                throw new Exception(string.Format("Type {0} already registered.", typeof(TYpetoResolve).FullName));
            }
            iocMap.Add(typeof(TYpetoResolve), typeof(TResolvedType));
        }

        public static T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }


        public static object Resolve(Type typeToResolve)
        {
            //Find the registered type for typeToResolve
            if (!iocMap.ContainsKey(typeToResolve))
            {
                throw new Exception(string.Format("Can't resolve type {0}. Type is not registered.", typeToResolve.FullName));
            }
            Type resolvedType = iocMap[typeToResolve];
            //Try to construct the object
            //step-1: find the constructor. 
            ConstructorInfo ctorInfo = resolvedType.GetConstructors().First();
            //step-2:find the parameters for the constructor and try to resolve those.
            List<ParameterInfo> paramsInfo = ctorInfo.GetParameters().ToList();
            List<object> resolvedParams = new List<object>();
            foreach (ParameterInfo param in paramsInfo)
            {
                Type t = param.ParameterType;
                object res = Resolve(t);
                resolvedParams.Add(res);
            }
            //step-3:using reflection invoke constructor to create the object
            object retObject = ctorInfo.Invoke(resolvedParams.ToArray());
            return retObject;
        }




    }
}