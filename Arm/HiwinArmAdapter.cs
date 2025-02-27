﻿using Arm.Type;
using Basic;

namespace Arm
{
    public class HiwinArmAdapter : IArmAdapter
    {
        public bool Connect()
        {
            throw new System.NotImplementedException();
        }

        public bool Disconnect()
        {
            throw new System.NotImplementedException();
        }

        public double GetNowPosition(CoordinateType coordinateType)
        {
            throw new System.NotImplementedException();
        }

        public double Speed { get; set; }
        public double Acceleration { get; set; }

        public double[] DescartesHomePosition { get; } = { 0, 368, 294, 180, 0, 90 };
        public double[] JointHomePosition { get; } = { 0, 0, 0, 0, 0, 0 };

        public bool Jog(Sign direction, Axis axis)
        {
            throw new System.NotImplementedException();
        }

        public bool AbsoluteMotion(double[] targetPosition, CoordinateType coordinateType, MotionType motionType, SmoothType smoothType)
        {
            throw new System.NotImplementedException();
        }

        public bool RelativeMotion(double[] position, CoordinateType coordinateType, MotionType motionType, SmoothType smoothType)
        {
            throw new System.NotImplementedException();
        }

        public bool Homing(CoordinateType coordinateType)
        {
            throw new System.NotImplementedException();
        }

        public bool AbortMotion()
        {
            throw new System.NotImplementedException();
        }
    }
}