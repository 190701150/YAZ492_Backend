﻿using Core.Application.Responses;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.Cars.Queries.GetById;

public class GetByIdCarResponse : IResponse
{
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int ModelId { get; set; }
    public int RentalBranchId { get; set; }
    public CarState CarState { get; set; }
    public int Kilometer { get; set; }
    public short ModelYear { get; set; }
    public string Plate { get; set; }
    public short MinFindeksCreditRate { get; set; }
    public List<string> Images { get; set; }
}
