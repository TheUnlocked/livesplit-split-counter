using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class SplitCounterSettings : UserControl
    {
        public string Label { get; set; } = "Splits Completed";

        public List<SplitInfo> SkipSplits { get; private set; } = new List<SplitInfo>();

        public SplitCounterSettings()
        {
            InitializeComponent();
        }

        private void SplitCounterSettings_Load(object sender, EventArgs e)
        {
            ignoreSplitsDataGrid.DataSource = new BindingList<SplitInfo>(SkipSplits);
            labelTextBox.DataBindings.Clear();
            labelTextBox.DataBindings.Add(nameof(labelTextBox.Text), this, nameof(Label), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "Label", Label) ^
                CreateSetting(document, parent, "SplitsToSkip", SkipSplits.Select(x => x.SplitName).ToList());
        }

        public static int CreateSetting<T>(XmlDocument document, XmlElement parent, string name, List<T> value)
        {
            if (document != null)
            {
                var element = document.CreateElement(name);
                for (int i = 0; i < value.Count; i++)
                {
                    SettingsHelper.CreateSetting(document, element, "item", value[i]);
                }
                parent.AppendChild(element);
            }
            return value != null ? value.GetHashCode() : 0;
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement) node;
            Label = SettingsHelper.ParseString(element["Label"], "Splits Completed");
            SkipSplits = element["SplitsToSkip"].ChildNodes
                .Cast<XmlElement>()
                .Select(x => new SplitInfo() { SplitName = x.InnerText }).ToList();

            SplitCounterSettings_Load(this, null);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public class SplitInfo
        {
            public string SplitName { get; set; }
        }
    }
}
