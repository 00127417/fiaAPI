﻿namespace Application.Common.Mappings
{
    using AutoMapper;

    public interface IMapFrom<T>
    {
        void Mapping(Profile profile);
    }
}