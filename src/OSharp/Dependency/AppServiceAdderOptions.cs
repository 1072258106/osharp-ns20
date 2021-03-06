﻿// -----------------------------------------------------------------------
//  <copyright file="AppServiceHandlerOptions.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-08-18 22:20</last-date>
// -----------------------------------------------------------------------

using OSharp.Reflection;


namespace OSharp.Dependency
{
    /// <summary>
    /// 应用程序服务添加器配置信息
    /// </summary>
    public class AppServiceAdderOptions
    {
        /// <summary>
        /// 初始化一个<see cref="AppServiceAdderOptions"/>类型的新实例
        /// </summary>
        public AppServiceAdderOptions()
        {
            TransientTypeFinder = new TransientDependencyTypeFinder();
            ScopedTypeFinder = new ScopedDependencyTypeFinder();
            SingletonTypeFinder = new SingletonDependencyTypeFinder();
        }

        /// <summary>
        /// 获取或设置 即时生命周期服务类型查找器
        /// </summary>
        public ITypeFinder TransientTypeFinder { get; set; }

        /// <summary>
        /// 获取或设置 作用域生命周期服务类型查找器
        /// </summary>
        public ITypeFinder ScopedTypeFinder { get; set; }

        /// <summary>
        /// 获取或设置 单例生命周期服务类型查找器
        /// </summary>
        public ITypeFinder SingletonTypeFinder { get; set; }
    }
}