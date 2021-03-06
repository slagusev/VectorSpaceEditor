﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows;
using VectorSpace.MapData.MapItems;
using VectorSpace.MapData.Components;

namespace VectorSpace.UI.Converters
{
    /// <summary>
    /// Converts a ShapeItem point list to Geometry data for Path objects
    /// </summary>
    public class PointsToPathConverter : IValueConverter
    {
        #region IValueConverter Members
        /// <summary>
        /// Attempts to convert a ShapeItem to PathGeometry
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ShapePoints item = value as ShapePoints;
            if (item != null && item.Count > 0)
            {
                Point start = item[0];
                List<LineSegment> segments = new List<LineSegment>();
                for (int i = 1; i < item.Count; i++)
                {
                    segments.Add(new LineSegment(item[i], true));
                }

                PathFigure figure = new PathFigure(start, segments, item.IsPolygon);
                PathGeometry geometry = new PathGeometry();
                geometry.Figures.Add(figure);
                return geometry;
            }
            else
                return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
        #endregion
    }
}
