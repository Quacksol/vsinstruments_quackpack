using instruments;
using Vintagestory.API.Common;

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
        }
    }
    public class AcousticGuitarItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "acousticguitar";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class TrumpetItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "trumpet";
            animation = "holdbothhands";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class ClarinetItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "clarinet";
            animation = "holdbothhands";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class AccordionItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "accordion";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class SaxItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "sax";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class ViolinItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "violin";
            animation = "holdinglanternrighthand";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class DulcimerItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "dulcimer";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class SteelDrumItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "steeldrum";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class GrandPianoItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "grandpiano";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class MusicBoxItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "musicbox";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class HarpItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "harp";
            animation = "holdbothhands";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class MicItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "mic";
            animation = "holdinglanternrighthand";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
    public class DrumItem : InstrumentItem
    {
        public override void OnLoaded(ICoreAPI api)
        {
            base.OnLoaded(api);
            instrument = "drum";
            animation = "holdbothhandslarge";
            Definitions.GetInstance().AddInstrumentType(instrument, animation);
        }
    }
}
