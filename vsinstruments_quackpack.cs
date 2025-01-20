using instruments;
using System.Diagnostics.Metrics;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace instruments_quackpack
{
    public class vsinstruments_quackpack : ModSystem
    { 
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            api.RegisterItemClass("accordion", typeof(AccordionItem));
            api.RegisterItemClass("acousticguitar", typeof(AcousticGuitarItem));
            api.RegisterItemClass("clarinet", typeof(ClarinetItem));
            api.RegisterItemClass("dulcimer", typeof(DulcimerItem));
            api.RegisterItemClass("drum", typeof(DrumItem));
            api.RegisterItemClass("grandpiano", typeof(GrandPianoItem));
            api.RegisterItemClass("harp", typeof(HarpItem));
            api.RegisterItemClass("mic", typeof(MicItem));
            api.RegisterItemClass("musicbox", typeof(MusicBoxItem));
            api.RegisterItemClass("sax", typeof(SaxItem));
            api.RegisterItemClass("steeldrum", typeof(SteelDrumItem));
            api.RegisterItemClass("trumpet", typeof(TrumpetItem));
            api.RegisterItemClass("violin", typeof(ViolinItem));

            /*
             * 
             *             Definitions.GetInstance.AddInstrumentType

                
                trumpet = 0,
                sax,
                dulcimer,
                accordion,
                bass,
                violin,
                clarinet,
                flute,
                bagpipes,
                steeldrum,
                acousticguitar,
                grandpiano,
                musicbox,
                harp,
                mic,
                drum,
            */
        }
    }
    public class TrumpetItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "trumpet";
            animation = "holdbothhands";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class ClarinetItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "clarinet";
            animation = "holdbothhands";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class AccordionItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "accordion";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class SaxItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "sax";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class ViolinItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "violin";
            animation = "holdinglanternrighthand";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class DulcimerItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "dulcimer";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class SteelDrumItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "steeldrum";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class GrandPianoItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "grandpiano";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class MusicBoxItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "musicbox";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class HarpItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "harp";
            animation = "holdbothhands";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class MicItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "mic";
            animation = "holdinglanternrighthand";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
    public class DrumItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            instrument = "drum";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
            base.OnLoaded(api);
        }
    }
}
