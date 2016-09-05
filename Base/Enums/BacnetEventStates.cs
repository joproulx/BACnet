﻿namespace System.IO.BACnet
{
    public enum BacnetEventStates
    {
        EVENT_STATE_NORMAL = 0,
        EVENT_STATE_FAULT = 1,
        EVENT_STATE_OFFNORMAL = 2,
        EVENT_STATE_HIGH_LIMIT = 3,
        EVENT_STATE_LOW_LIMIT = 4,
        EVENT_STATE_LIFE_SAFETY_ALARM = 5
    }
}