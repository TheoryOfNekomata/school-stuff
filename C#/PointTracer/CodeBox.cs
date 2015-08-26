using System.Windows.Forms;

namespace PointTracer {
    public partial class CodeBox : Form {
        private ListView.ListViewItemCollection _collection;

        public CodeBox() {
            InitializeComponent();
        }

        public CodeBox(ListView.ListViewItemCollection c) : this() {
            this.GenerateText(c);
        }

        public CodeBox GenerateText(ListView.ListViewItemCollection collection) {
            this._collection = collection;
            this.txtboxCode.Text = string.Format("{0}", "// Paste this");
            for(var i = 1; i < collection.Count; i++) {
                var x1 = int.Parse(collection[i - 1].SubItems[0].Text);
                var y1 = int.Parse(collection[i - 1].SubItems[1].Text);
                var t = bool.Parse(collection[i - 1].SubItems[2].Text);
                var x2 = int.Parse(collection[i].SubItems[0].Text);
                var y2 = int.Parse(collection[i].SubItems[1].Text);

                if(!t) this.txtboxCode.Text += string.Format("\r\nthis.{4}.DrawLine(this.{5}, {0}, {1}, {2}, {3});", x1, y1, x2, y2, txtboxGraphics.Text, txtboxPen.Text);
            }
            return this;
        }

        public CodeBox GenerateText() {
            return this.GenerateText(_collection);
        }

        private void txtboxGraphics_TextChanged(object sender, System.EventArgs e) {
            var txtBox = (ToolStripTextBox) sender;
            if(!txtBox.Modified) return;
            this.GenerateText();
            txtBox.Modified = false;
        }

        private void txtboxPen_TextChanged(object sender, System.EventArgs e) {
            var txtBox = (ToolStripTextBox) sender;
            if(!txtBox.Modified) return;
            this.GenerateText();
            txtBox.Modified = false;
        }
    }
}
