﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SyncSoft.Payment.IOC
{
    public class Container
    {
        private static readonly Dictionary<string, Type> iocMap = new Dictionary<string, Type>();


        /// <summary>
        /// 通过名称注册的情况
        /// </summary>
        /// <typeparam name="TYpetoResolve"></typeparam>
        /// <typeparam name="TResolvedType"></typeparam>
        /// <param name="name"></param>
        public static void Register<TYpetoResolve, TResolvedType>(string name="")
        {
            if (iocMap.ContainsKey(typeof(TYpetoResolve)+name))
            {
                throw new Exception(string.Format("Type {0} already registered.", typeof(TYpetoResolve).FullName));
            }
            iocMap.Add(typeof(TYpetoResolve)+name, typeof(TResolvedType));
        }

        public static T Resolve<T>(string name = "")
        {
            return (T)Resolve(typeof(T),name);
        }


        public static object Resolve(Type typeToResolve, string name = "")
        {
            //Find the registered type for typeToResolve
            if (!iocMap.ContainsKey(typeToResolve+name))
            {
                throw new Exception(string.Format("Can't resolve type {0}. Type is not registered.", typeToResolve.FullName));
            }
            Type resolvedType = iocMap[typeToResolve + name];
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