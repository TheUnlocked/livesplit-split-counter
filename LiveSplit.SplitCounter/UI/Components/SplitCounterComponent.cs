using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class SplitCounterComponent : IComponent
    {
        protected InfoTextComponent InternalComponent { get; set; }

        public SplitCounterSettings Settings { get; set; }

        private LiveSplitState CurrentState { get; set; }

        private bool IsDirty { get; set; } = true;

        public string ComponentName => "Splits Completed";

        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float VerticalHeight => InternalComponent.VerticalHeight;
        public float MinimumHeight => InternalComponent.MinimumHeight;

        public float PaddingTop => InternalComponent.PaddingTop;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingRight => InternalComponent.PaddingRight;

        public IDictionary<string, Action> ContextMenuControls => null;

        public SplitCounterComponent(LiveSplitState state)
        {
            Settings = new SplitCounterSettings();
            InternalComponent = new InfoTextComponent(Settings.Label, "0");
            CurrentState = state;

            CurrentState.OnStart += OnGenericUpdate;
            CurrentState.OnSplit += OnGenericUpdate;
            CurrentState.OnSkipSplit += OnGenericUpdate;
            CurrentState.OnUndoSplit += OnGenericUpdate;
            CurrentState.OnReset += OnReset;
        }

        public void Dispose()
        {
            CurrentState.OnStart -= OnGenericUpdate;
            CurrentState.OnSplit -= OnGenericUpdate;
            CurrentState.OnSkipSplit -= OnGenericUpdate;
            CurrentState.OnUndoSplit -= OnGenericUpdate;
            CurrentState.OnReset -= OnReset;
        }

        private void OnGenericUpdate(object sender, EventArgs e)
        {
            IsDirty = true;
        }

        private void OnReset(object sender, TimerPhase value)
        {
            IsDirty = true;
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (!IsDirty)
            {
                return;
            }

            // It's not super efficient to do this every time
            // but it's also very fast so who cares.
            int numSplits = CurrentState.Run.Count();
            int completedSplits = 0;
            HashSet<string> skipSplitsSet = new HashSet<string>(Settings.SkipSplits.Select(x => x.SplitName));

            for (int i = 0; i < numSplits; i++)
            {
                if (i >= CurrentState.CurrentSplitIndex)
                {
                    break;
                }
                if (!skipSplitsSet.Contains(CurrentState.Run[i].Name))
                {
                    completedSplits++;
                }
            }

            InternalComponent.InformationName = Settings.Label;
            InternalComponent.InformationValue = completedSplits.ToString();
            InternalComponent.Update(invalidator, state, width, height, mode);

            IsDirty = false;
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            IsDirty = true;
            return Settings.GetSettings(document);
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public void SetSettings(XmlNode settings)
        {
            IsDirty = true;
            Settings.SetSettings(settings);
        }
    }
}
