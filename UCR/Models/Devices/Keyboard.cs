﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCR.Models.Mapping;

namespace UCR.Models.Devices
{
    public sealed class Keyboard : Device
    {
        public Keyboard() : base(DeviceType.Keyboard)
        {
        }

        public Keyboard(Keyboard keyboard) : base(keyboard)
        {
            // TODO Copy vars
        }

        public override bool SubscribeInput(DeviceBinding deviceBinding)
        {
            throw new NotImplementedException();
        }

        public override bool SubscribeOutput(DeviceBinding deviceBinding)
        {
            throw new NotImplementedException();
        }

        public override void ClearSubscribers()
        {
            throw new NotImplementedException();
        }

        public override void SubscribeDeviceBindings(UCRContext ctx)
        {
            throw new NotImplementedException();
        }
    }
}
