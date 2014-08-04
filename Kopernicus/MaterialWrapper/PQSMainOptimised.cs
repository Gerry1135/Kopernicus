// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSMainOptimised : Material
        {
            // Return the shader for this wrapper
            private const string shaderName = "Terrain/PQS/PQS Main - Optimised";
            private static Shader shaderForMaterial
            {
                get { return Shader.Find (shaderName); }
            }

            // Saturation, default = 1
            private const string saturationKey = "_saturation";
            public float saturation
            {
                get { return GetFloat (saturationKey); }
                set { SetFloat (saturationKey, value); }
            }

            // Contrast, default = 1
            private const string contrastKey = "_contrast";
            public float contrast
            {
                get { return GetFloat (contrastKey); }
                set { SetFloat (contrastKey, value); }
            }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            private const string tintColorKey = "_tintColor";
            public Color tintColor
            {
                get { return GetColor (tintColorKey); }
                set { SetColor (tintColorKey, value); }
            }

            // Near Blend, default = 0.5
            private const string powerNearKey = "_powerNear";
            public float powerNear
            {
                get { return GetFloat (powerNearKey); }
                set { SetFloat (powerNearKey, value); }
            }

            // Far Blend, default = 0.5
            private const string powerFarKey = "_powerFar";
            public float powerFar
            {
                get { return GetFloat (powerFarKey); }
                set { SetFloat (powerFarKey, value); }
            }

            // NearFar Start, default = 2000
            private const string groundTexStartKey = "_groundTexStart";
            public float groundTexStart
            {
                get { return GetFloat (groundTexStartKey); }
                set { SetFloat (groundTexStartKey, value); }
            }

            // NearFar End, default = 10000
            private const string groundTexEndKey = "_groundTexEnd";
            public float groundTexEnd
            {
                get { return GetFloat (groundTexEndKey); }
                set { SetFloat (groundTexEndKey, value); }
            }

            // Steep Blend, default = 1
            private const string steepPowerKey = "_steepPower";
            public float steepPower
            {
                get { return GetFloat (steepPowerKey); }
                set { SetFloat (steepPowerKey, value); }
            }

            // Steep Fade Start, default = 20000
            private const string steepTexStartKey = "_steepTexStart";
            public float steepTexStart
            {
                get { return GetFloat (steepTexStartKey); }
                set { SetFloat (steepTexStartKey, value); }
            }

            // Steep Fade End, default = 30000
            private const string steepTexEndKey = "_steepTexEnd";
            public float steepTexEnd
            {
                get { return GetFloat (steepTexEndKey); }
                set { SetFloat (steepTexEndKey, value); }
            }

            // Steep Texture, default = "white" {}
            private const string steepTexKey = "_steepTex";
            public Texture2D steepTex
            {
                get { return GetTexture (steepTexKey) as Texture2D; }
                set { SetTexture (steepTexKey, value); }
            }

            // Steep Bump Map, default = "bump" {}
            private const string steepBumpMapKey = "_steepBumpMap";
            public Texture2D steepBumpMap
            {
                get { return GetTexture (steepBumpMapKey) as Texture2D; }
                set { SetTexture (steepBumpMapKey, value); }
            }

            // Steep Near Tiling, default = 1
            private const string steepNearTilingKey = "_steepNearTiling";
            public float steepNearTiling
            {
                get { return GetFloat (steepNearTilingKey); }
                set { SetFloat (steepNearTilingKey, value); }
            }

            // Steep Far Tiling, default = 1
            private const string steepTilingKey = "_steepTiling";
            public float steepTiling
            {
                get { return GetFloat (steepTilingKey); }
                set { SetFloat (steepTilingKey, value); }
            }

            // Low Texture, default = "white" {}
            private const string lowTexKey = "_lowTex";
            public Texture2D lowTex
            {
                get { return GetTexture (lowTexKey) as Texture2D; }
                set { SetTexture (lowTexKey, value); }
            }

            // Low Bump Map, default = "bump" {}
            private const string lowBumpMapKey = "_lowBumpMap";
            public Texture2D lowBumpMap
            {
                get { return GetTexture (lowBumpMapKey) as Texture2D; }
                set { SetTexture (lowBumpMapKey, value); }
            }

            // Low Near Tiling, default = 1000
            private const string lowNearTilingKey = "_lowNearTiling";
            public float lowNearTiling
            {
                get { return GetFloat (lowNearTilingKey); }
                set { SetFloat (lowNearTilingKey, value); }
            }

            // Low Far Tiling, default = 10
            private const string lowMultiFactorKey = "_lowMultiFactor";
            public float lowMultiFactor
            {
                get { return GetFloat (lowMultiFactorKey); }
                set { SetFloat (lowMultiFactorKey, value); }
            }

            // Low Bump Near Tiling, default = 1
            private const string lowBumpNearTilingKey = "_lowBumpNearTiling";
            public float lowBumpNearTiling
            {
                get { return GetFloat (lowBumpNearTilingKey); }
                set { SetFloat (lowBumpNearTilingKey, value); }
            }

            // Low Bump Far Tiling, default = 1
            private const string lowBumpFarTilingKey = "_lowBumpFarTiling";
            public float lowBumpFarTiling
            {
                get { return GetFloat (lowBumpFarTilingKey); }
                set { SetFloat (lowBumpFarTilingKey, value); }
            }

            // Mid Texture, default = "white" {}
            private const string midTexKey = "_midTex";
            public Texture2D midTex
            {
                get { return GetTexture (midTexKey) as Texture2D; }
                set { SetTexture (midTexKey, value); }
            }

            // Mid Bump Map, default = "bump" {}
            private const string midBumpMapKey = "_midBumpMap";
            public Texture2D midBumpMap
            {
                get { return GetTexture (midBumpMapKey) as Texture2D; }
                set { SetTexture (midBumpMapKey, value); }
            }

            // Mid Near Tiling, default = 1000
            private const string midNearTilingKey = "_midNearTiling";
            public float midNearTiling
            {
                get { return GetFloat (midNearTilingKey); }
                set { SetFloat (midNearTilingKey, value); }
            }

            // Mid Far Tiling, default = 10
            private const string midMultiFactorKey = "_midMultiFactor";
            public float midMultiFactor
            {
                get { return GetFloat (midMultiFactorKey); }
                set { SetFloat (midMultiFactorKey, value); }
            }

            // Mid Bump Near Tiling, default = 1
            private const string midBumpNearTilingKey = "_midBumpNearTiling";
            public float midBumpNearTiling
            {
                get { return GetFloat (midBumpNearTilingKey); }
                set { SetFloat (midBumpNearTilingKey, value); }
            }

            // Mid Bump Far Tiling, default = 1
            private const string midBumpFarTilingKey = "_midBumpFarTiling";
            public float midBumpFarTiling
            {
                get { return GetFloat (midBumpFarTilingKey); }
                set { SetFloat (midBumpFarTilingKey, value); }
            }

            // High Texture, default = "white" {}
            private const string highTexKey = "_highTex";
            public Texture2D highTex
            {
                get { return GetTexture (highTexKey) as Texture2D; }
                set { SetTexture (highTexKey, value); }
            }

            // High Bump Map, default = "bump" {}
            private const string highBumpMapKey = "_highBumpMap";
            public Texture2D highBumpMap
            {
                get { return GetTexture (highBumpMapKey) as Texture2D; }
                set { SetTexture (highBumpMapKey, value); }
            }

            // High Near Tiling, default = 1000
            private const string highNearTilingKey = "_highNearTiling";
            public float highNearTiling
            {
                get { return GetFloat (highNearTilingKey); }
                set { SetFloat (highNearTilingKey, value); }
            }

            // High Far Tiling, default = 10
            private const string highMultiFactorKey = "_highMultiFactor";
            public float highMultiFactor
            {
                get { return GetFloat (highMultiFactorKey); }
                set { SetFloat (highMultiFactorKey, value); }
            }

            // High Bump Near Tiling, default = 1
            private const string highBumpNearTilingKey = "_highBumpNearTiling";
            public float highBumpNearTiling
            {
                get { return GetFloat (highBumpNearTilingKey); }
                set { SetFloat (highBumpNearTilingKey, value); }
            }

            // High Bump Far Tiling, default = 1
            private const string highBumpFarTilingKey = "_highBumpFarTiling";
            public float highBumpFarTiling
            {
                get { return GetFloat (highBumpFarTilingKey); }
                set { SetFloat (highBumpFarTilingKey, value); }
            }

            // Low Transition Start, default = 0
            private const string lowStartKey = "_lowStart";
            public float lowStart
            {
                get { return GetFloat (lowStartKey); }
                set { SetFloat (lowStartKey, value); }
            }

            // Low Transition End, default = 0.3
            private const string lowEndKey = "_lowEnd";
            public float lowEnd
            {
                get { return GetFloat (lowEndKey); }
                set { SetFloat (lowEndKey, value); }
            }

            // High Transition Start, default = 0.8
            private const string highStartKey = "_highStart";
            public float highStart
            {
                get { return GetFloat (highStartKey); }
                set { SetFloat (highStartKey, value); }
            }

            // High Transition End, default = 1
            private const string highEndKey = "_highEnd";
            public float highEnd
            {
                get { return GetFloat (highEndKey); }
                set { SetFloat (highEndKey, value); }
            }

            // AP Global Density, default = 1
            private const string globalDensityKey = "_globalDensity";
            public float globalDensity
            {
                get { return GetFloat (globalDensityKey); }
                set { SetFloat (globalDensityKey, value); }
            }

            // FogColorRamp, default = "white" {}
            private const string fogColorRampKey = "_fogColorRamp";
            public Texture2D fogColorRamp
            {
                get { return GetTexture (fogColorRampKey) as Texture2D; }
                set { SetTexture (fogColorRampKey, value); }
            }

            // PlanetOpacity, default = 1
            private const string planetOpacityKey = "_PlanetOpacity";
            public float planetOpacity
            {
                get { return GetFloat (planetOpacityKey); }
                set { SetFloat (planetOpacityKey, value); }
            }

            public PQSMainOptimised() : base(shaderForMaterial)
            {
            }

            public PQSMainOptimised(string contents) : base(contents)
            {
                base.shader = shaderForMaterial;
            }

            public PQSMainOptimised(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != shaderName)
                    throw new InvalidOperationException("PQSMainOptimised material requires the \"" + shaderName + "\" shader");
            }

        }
    }
}