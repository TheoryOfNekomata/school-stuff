using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PointTracer {
    public partial class PointTracer : Form {
        private static int _brushSize = 4;
        private Bitmap _bmp;
        private Graphics _g;
        private Pen _p = new Pen(Brushes.Black, _brushSize);
        private Pen _p2 = new Pen(Brushes.Gray, _brushSize);
        private Stack<KeyValuePair<Point, bool>> _memento = new Stack<KeyValuePair<Point, bool>>();
        private CodeBox _codeBox = new CodeBox();

        public PointTracer() {
            InitializeComponent();
        }

        private void ClearPoints() {
            this.listPoints.Items.Clear();
            mnitmUndo.Enabled = false;
            mnitmRedo.Enabled = false;
        }

        private void PushPoint(int x, int y, bool terminal = false) {
            try {
                var lastItem = listPoints.Items[listPoints.Items.Count - 1];
                if(int.Parse(lastItem.SubItems[0].Text) == x && int.Parse(lastItem.SubItems[1].Text) == y) {
                    this.PopPoint();
                }
                
            } catch(Exception) {}
            listPoints.Items.Add(new ListViewItem(new[] { "" + x, "" + y, "" + terminal, "A" }));
        }

        private KeyValuePair<Point, bool> PopPoint() {
            if(listPoints.Items.Count == 0)
                mnitmUndo.Enabled = false;
            var lastItem = listPoints.Items[listPoints.Items.Count - 1];
            var x = int.Parse(lastItem.SubItems[0].Text);
            var y = int.Parse(lastItem.SubItems[1].Text);
            var t = bool.Parse(lastItem.SubItems[2].Text);
            if(listPoints.Items.Count > 0) listPoints.Items.RemoveAt(listPoints.Items.Count - 1);
            return new KeyValuePair <Point, bool>(new Point(x, y), t);
        }

        private void Draw() {
            this._bmp = new Bitmap(canvas.Width, canvas.Height);
            this.canvas.Image = this._bmp;
            this._g = Graphics.FromImage(canvas.Image);

            for(var i = 0; i < listPoints.Items.Count; i++) {
                var x2 = int.Parse(listPoints.Items[i].SubItems[0].Text);
                var y2 = int.Parse(listPoints.Items[i].SubItems[1].Text);

                if(i > 0) {
                    var x1 = int.Parse(listPoints.Items[i - 1].SubItems[0].Text);
                    var y1 = int.Parse(listPoints.Items[i - 1].SubItems[1].Text);
                    var t = bool.Parse(listPoints.Items[i - 1].SubItems[2].Text);
                    if(!t) this._g.DrawLine(this._p, new Point(x1, y1), new Point(x2, y2));
                    this._g.FillEllipse(this._p2.Brush, x1 - (_brushSize + 1), y1 - (_brushSize + 1), _brushSize * 2 + 1, _brushSize * 2 + 1);
                }
                this._g.FillEllipse(this._p2.Brush, x2 - (_brushSize + 1), y2 - (_brushSize + 1), _brushSize * 2 + 1, _brushSize * 2 + 1);
            }
        }

        private void Generate() {
            this._codeBox.GenerateText(listPoints.Items).ShowDialog(this);
        }

        private void Undo() {
            this._memento.Push(this.PopPoint());
            mnitmUndo.Enabled = listPoints.Items.Count > 0;
            mnitmRedo.Enabled = this._memento.Count > 0;
        }

        private void Redo() {
            var _recent = this._memento.Pop();
            this.PushPoint(_recent.Key.X, _recent.Key.Y, _recent.Value);
            mnitmUndo.Enabled = listPoints.Items.Count > 0;
            mnitmRedo.Enabled = this._memento.Count > 0;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e) {
            switch(e.Button) {
                case MouseButtons.Left:
                    this.PushPoint(e.X, e.Y);
                    mnitmUndo.Enabled = true;
                    mnitmRedo.Enabled = false;
                    this._memento.Clear();
                    break;
                case MouseButtons.Right:
                    this.PushPoint(e.X, e.Y, true);
                    break;
            }
            this.Draw();
        }

        private void PointTracer_ResizeEnd(object sender, EventArgs e) {
            this.Draw();
        }

        private void btnClearPts_Click(object sender, EventArgs e) {
            if(MessageBox.Show(this, "Are you sure to clear all points? This action is not undoable!", "Clear Points", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                this.ClearPoints();
            this.Draw();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            this.Generate();
        }

        private void mnitmUndo_Click(object sender, EventArgs e) {
            try {
                this.Undo();
                this.Draw();
            } catch(Exception) { }
        }

        private void mnitmRedo_Click(object sender, EventArgs e) {
            try {
                this.Redo();
                this.Draw();
            } catch(Exception) { }
        }
    }
}
