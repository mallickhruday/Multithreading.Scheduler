﻿using System;

namespace Elders.Multithreading.Scheduler
{
    /// <summary>
    /// Defines async periodical work
    /// </summary>
    public interface IWork
    {
        DateTime ScheduledStart { get; }
        void Start();
        void Stop();
    }
}