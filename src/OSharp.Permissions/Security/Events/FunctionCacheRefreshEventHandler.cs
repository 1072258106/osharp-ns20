﻿// -----------------------------------------------------------------------
//  <copyright file="FunctionCacheRefreshEventHandler.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-12 22:23</last-date>
// -----------------------------------------------------------------------

using System;

using Microsoft.Extensions.DependencyInjection;

using OSharp.Core.Functions;
using OSharp.Dependency;
using OSharp.EventBuses;


namespace OSharp.Security.Events
{
    /// <summary>
    /// 功能信息缓存刷新事件处理器
    /// </summary>
    public class FunctionCacheRefreshEventHandler : EventHandlerBase<FunctionCacheRefreshEventData>, ITransientDependency
    {
        private readonly IServiceProvider _provider;

        /// <summary>
        /// 初始化一个<see cref="FunctionCacheRefreshEventHandler"/>类型的新实例
        /// </summary>
        public FunctionCacheRefreshEventHandler(IServiceProvider provider)
        {
            _provider = provider;
        }

        /// <summary>
        /// 事件处理
        /// </summary>
        /// <param name="eventData">事件源数据</param>
        public override void Handle(FunctionCacheRefreshEventData eventData)
        {
            IFunctionHandler functionHandler = _provider.GetService<IFunctionHandler>();
            functionHandler.RefreshCache();
        }
    }
}