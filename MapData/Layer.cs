﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorSpace.MapData.Interfaces;

namespace VectorSpace.MapData
{
    /// <summary>
    /// Map layers
    /// </summary>
    public class Layer
    {
        #region Variables & Properties
        /// <summary>
        /// Layer id (unique)
        /// </summary>
        public string Id { get { return id; } }
        protected string id;

        /// <summary>
        /// Layer name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected string name;

        /// <summary>
        /// Items contained within this layer
        /// </summary>
        public ObservableCollection<IRenderable> Items { get { return items; } }
        protected ObservableCollection<IRenderable> items;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates a layer
        /// </summary>
        /// <param name="id">Layer id</param>
        public Layer(string id)
        {
            this.id = id;
            this.name = "Layer " + id.ToString();

            items = new ObservableCollection<IRenderable>();
        }

        /// <summary>
        /// Creates a layer
        /// </summary>
        /// <param name="id">Layer id</param>
        /// <param name="name">Layer name</param>
        public Layer(string id, string name)
        {
            this.id = id;
            this.name = name;

            items = new ObservableCollection<IRenderable>();
        }
        #endregion


        public bool AddItem(IRenderable item)
        {
            if (!items.Contains(item))
            {
                items.Add(item);
                return true;
            }

            return false;
        }

        public bool RemoveItem(IRenderable item)
        {
            return items.Remove(item);
        }
    }
}
