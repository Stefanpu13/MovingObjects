//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovingObjects.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameObject
    {
        public int ObjectId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double XDirection { get; set; }
        public string YDirection { get; set; }
        public int GameId { get; set; }
    
        public virtual Game Game { get; set; }
    }
}