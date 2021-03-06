// Copyright 2016 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Mapping;
using System.Windows;

namespace ArcGISRuntime.WPF.Samples.MapRotation
{
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        "Map rotation",
        "MapView",
        "This sample demonstrates how to rotate a map.",
        "Use the available slider to dictate the number of degrees the map is rotated")]
    public partial class MapRotation
    {
        public MapRotation()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            // Show a new map with a streets basemap.
            MyMapView.Map = new Map(Basemap.CreateStreets());
        }

        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Display the rotation value in the Label formatted nicely with degree symbol.
            MyLabel.Text = string.Format("{0:0}°", MySlider.Value);

            // Set the MapView rotation to that of the Slider.
            MyMapView.SetViewpointRotationAsync(e.NewValue);
        }
    }
}