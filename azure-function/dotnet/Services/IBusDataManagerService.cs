﻿namespace GetBusData.Services;

public interface IBusDataManagerService
{
    Task ProcessBusDataAsync();
    Task ProcessGetDayQuartzAsync();
}
