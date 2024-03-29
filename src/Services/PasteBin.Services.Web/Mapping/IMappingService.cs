﻿namespace PasteBin.Services.Web.Mapping
{
    using System.Linq;

    public interface IMappingService
    {
        TDestination Map<TDestination>(object source)
            where TDestination : class;

        void Map<TSource, TDestination>(TSource source, TDestination destination)
            where TDestination : class;

        IQueryable<TDestination> Map<TDestination>(IQueryable source, object parameters = null)
            where TDestination : class;
    }
}