﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorSpace.MapData.Components;

namespace VectorSpace.MapData.Interfaces
{
    /// <summary>
    /// Interface for items that are rendered on the map canvas
    /// </summary>
    public interface IRenderable : INotifyPropertyChanged
    {
        #region Properties
        /// <summary>
        /// Object Type
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Property layer id
        /// </summary>
        string Layer { get; set; }

        /// <summary>
        /// Property holder name
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// Objects world position
        /// </summary>
        WorldPosition Position { get; set; }

        /// <summary>
        /// The ZIndex depth for the object (controlled by the layer placement)
        /// </summary>
        int ZIndex { get; set; } 
        #endregion
    }
}
