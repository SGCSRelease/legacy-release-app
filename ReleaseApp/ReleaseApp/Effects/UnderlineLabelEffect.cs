using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ReleaseApp.Effects
{
    public class UnderlineLabelEffect : RoutingEffect
    {
        public const string EffectNamespace = "Example";
        public UnderlineLabelEffect() : base(EffectIds.UnderlineLabelEffect)
        {

        }
    }
}
