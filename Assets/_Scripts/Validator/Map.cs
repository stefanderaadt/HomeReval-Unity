﻿using System.Collections.Generic;
using Windows.Kinect;

namespace HomeReval.Validator
{
    public class Map
    {
        public enum Mappings { Spine, LeftArm, RightArm, LeftLeg, RightLeg }

        private static readonly Dictionary<JointType, JointType> spineMappings 
            = new Dictionary<JointType, JointType>{
                { JointType.Head, JointType.Neck },
                //{ JointType.Neck, JointType.Head },
                { JointType.Neck, JointType.SpineShoulder },
                //{ JointType.SpineShoulder, JointType.Neck  },
                { JointType.SpineShoulder, JointType.SpineMid },
                //{ JointType.SpineMid, JointType.SpineShoulder },
                { JointType.SpineMid, JointType.SpineBase },
                //{ JointType.SpineBase, JointType.SpineMid }
            };

        private static readonly Dictionary<JointType, JointType> leftArmMappings
            = new Dictionary<JointType, JointType>{
                { JointType.ShoulderLeft, JointType.ElbowLeft },
                //{ JointType.ElbowLeft, JointType.ShoulderLeft },
                { JointType.ElbowLeft, JointType.WristLeft },
                //{ JointType.WristLeft, JointType.ElbowLeft },
                { JointType.WristLeft, JointType.HandLeft },
                //{ JointType.HandLeft, JointType.WristLeft }
            };

        private static readonly Dictionary<JointType, JointType> rightArmMappings
            = new Dictionary<JointType, JointType>{
                { JointType.ShoulderRight, JointType.ElbowRight },
                //{ JointType.ElbowRight, JointType.ShoulderRight },
                { JointType.ElbowRight, JointType.WristRight },
                //{ JointType.WristRight, JointType.ElbowRight },
                { JointType.WristRight, JointType.HandRight },
                //{ JointType.HandRight, JointType.WristRight }
            };

        private static readonly Dictionary<JointType, JointType> leftLegMappings
            = new Dictionary<JointType, JointType>{
                { JointType.HipLeft, JointType.KneeLeft },
                //{ JointType.KneeLeft, JointType.HipLeft },
                { JointType.KneeLeft, JointType.AnkleLeft },
                //{ JointType.AnkleLeft, JointType.KneeLeft },
                { JointType.AnkleLeft, JointType.FootLeft },
                //{ JointType.FootLeft, JointType.AnkleLeft }
            };

        private static readonly Dictionary<JointType, JointType> rightLegMappings
            = new Dictionary<JointType, JointType>{
                { JointType.HipRight, JointType.KneeRight },
                //{ JointType.KneeRight, JointType.HipRight },
                { JointType.KneeRight, JointType.AnkleRight },
                //{ JointType.AnkleRight, JointType.KneeRight },
                { JointType.AnkleRight, JointType.FootRight },
                //{ JointType.FootRight, JointType.AnkleRight }
            };

        private static readonly Dictionary<Mappings, Dictionary<JointType, JointType>> dictMappings = new Dictionary<Mappings, Dictionary<JointType, JointType>>
        {
            { Mappings.Spine, spineMappings },
            { Mappings.LeftArm, leftArmMappings },
            { Mappings.RightArm, rightArmMappings },
            { Mappings.LeftLeg, leftLegMappings },
            { Mappings.RightLeg, rightLegMappings }
        };

        public static Dictionary<Mappings, Dictionary<JointType, JointType>> DictMappings
        {
            get { return dictMappings; }
        }

        /*public static Dictionary<JointType, JointType> SpineMappings
        {
            get{return spineMappings;}
        }

        public static Dictionary<JointType, JointType> LeftArmMappings
        {
            get { return leftArmMappings; }
        }

        public static Dictionary<JointType, JointType> RightArmMappings
        {
            get { return rightArmMappings; }
        }

        public static Dictionary<JointType, JointType> LeftLegMappings
        {
            get { return leftLegMappings; }
        }

        public static Dictionary<JointType, JointType> RightLegMappings
        {
            get { return rightLegMappings; }
        }*/
    }
}
