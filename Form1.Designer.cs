﻿namespace iwm_Commandliner3
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.DgvMacro = new System.Windows.Forms.DataGridView();
			this.DgvTb11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DgvTb12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsResult_全選択 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_全クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_全コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_上書き = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_L3 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_ファイル名を貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_名前を付けて保存 = new System.Windows.Forms.ToolStripMenuItem();
			this.TbCmd = new System.Windows.Forms.TextBox();
			this.CmsCmd = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsCmd_全クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_全コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_上書き = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_タブ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_改行 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_マクロ変数_日付 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_年 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_月 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_日 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_時間 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_時 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_分 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_秒 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_マイクロ秒 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_マクロ変数_出力のデータ = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_マクロ変数_出力の行番号 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_マクロ変数_出力の行データ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_定数など = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_定数など_SJIS = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_定数など_UTF8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_フォルダ選択 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_ファイル選択 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_コマンドをグループ化 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_コマンドをグループ化_追加 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_コマンドをグループ化_出力 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_コマンドをグループ化_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmd_コマンドをグループ化_簡単な説明 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_コマンドを保存 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmd_コマンドを読込 = new System.Windows.Forms.ToolStripMenuItem();
			this.TbCurDir = new System.Windows.Forms.TextBox();
			this.CmsTbCurDir = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTbCurDir_全コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.BtnCmdExec = new System.Windows.Forms.Button();
			this.BtnResultMem = new System.Windows.Forms.Button();
			this.CbTextCode = new System.Windows.Forms.ComboBox();
			this.CmsCbTextCode = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsCbTextCode_全コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CbCmdHistory = new System.Windows.Forms.ComboBox();
			this.CbResultHistory = new System.Windows.Forms.ComboBox();
			this.BtnAllClear = new System.Windows.Forms.Button();
			this.BtnDgvMacro = new System.Windows.Forms.Button();
			this.BtnDgvCmd = new System.Windows.Forms.Button();
			this.BtnMemoCopy = new System.Windows.Forms.Button();
			this.TbDgvCmdSearch = new System.Windows.Forms.TextBox();
			this.CmsTbDgvCmdSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTbDgvCmdSearch_全クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTbDgvCmdSearch_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.NudTbResult = new System.Windows.Forms.NumericUpDown();
			this.Lbl2 = new System.Windows.Forms.Label();
			this.DgvCmd = new System.Windows.Forms.DataGridView();
			this.DgvTb21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TbResult = new System.Windows.Forms.TextBox();
			this.CmsCmdMemo = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsCmdMemo_全クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmdMemo_全コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsCmdMemo_上書き = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsCmdMemo_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.LblWait = new System.Windows.Forms.Label();
			this.TbInfo = new System.Windows.Forms.TextBox();
			this.Lbl_F1 = new System.Windows.Forms.Label();
			this.Lbl_F2 = new System.Windows.Forms.Label();
			this.Lbl_F3 = new System.Windows.Forms.Label();
			this.Lbl_F4 = new System.Windows.Forms.Label();
			this.Lbl_F5 = new System.Windows.Forms.Label();
			this.Lbl_F7 = new System.Windows.Forms.Label();
			this.Lbl_F8 = new System.Windows.Forms.Label();
			this.Lbl_F9 = new System.Windows.Forms.Label();
			this.LblCmd = new System.Windows.Forms.Label();
			this.LblCmdMemo = new System.Windows.Forms.Label();
			this.LblResult = new System.Windows.Forms.Label();
			this.Lbl_F6 = new System.Windows.Forms.Label();
			this.LblCurDir = new System.Windows.Forms.Label();
			this.CmsTextSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTextSelect_Cancel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_切り取り = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_DQで囲む = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_DQを消去 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_ネット検索 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_Google = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_Google翻訳 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_Googleマップ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_YouTube = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_ネット検索_Wikipedia = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_関連付けられたアプリケーションで開く = new System.Windows.Forms.ToolStripMenuItem();
			this.RtbCmdMemo = new System.Windows.Forms.RichTextBox();
			this.BtnResult1 = new System.Windows.Forms.Button();
			this.BtnResult2 = new System.Windows.Forms.Button();
			this.BtnResult3 = new System.Windows.Forms.Button();
			this.BtnResult4 = new System.Windows.Forms.Button();
			this.BtnResult5 = new System.Windows.Forms.Button();
			this.PanelResult = new System.Windows.Forms.Panel();
			this.BtnPasteCancel = new System.Windows.Forms.Button();
			this.BtnPasteFilename = new System.Windows.Forms.Button();
			this.BtnPasteTextfile = new System.Windows.Forms.Button();
			this.BtnCmdExecStream = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvMacro)).BeginInit();
			this.CmsResult.SuspendLayout();
			this.CmsCmd.SuspendLayout();
			this.CmsTbCurDir.SuspendLayout();
			this.CmsCbTextCode.SuspendLayout();
			this.CmsTbDgvCmdSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NudTbResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvCmd)).BeginInit();
			this.CmsCmdMemo.SuspendLayout();
			this.CmsTextSelect.SuspendLayout();
			this.PanelResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// DgvMacro
			// 
			this.DgvMacro.AllowUserToAddRows = false;
			this.DgvMacro.AllowUserToDeleteRows = false;
			this.DgvMacro.AllowUserToResizeColumns = false;
			this.DgvMacro.AllowUserToResizeRows = false;
			this.DgvMacro.BackgroundColor = System.Drawing.Color.LightGray;
			this.DgvMacro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvMacro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.DgvTb11,
			this.DgvTb12});
			this.DgvMacro.ContextMenuStrip = this.CmsNull;
			this.DgvMacro.GridColor = System.Drawing.Color.LightGray;
			this.DgvMacro.Location = new System.Drawing.Point(87, 133);
			this.DgvMacro.Margin = new System.Windows.Forms.Padding(0);
			this.DgvMacro.MultiSelect = false;
			this.DgvMacro.Name = "DgvMacro";
			this.DgvMacro.ReadOnly = true;
			this.DgvMacro.RowHeadersVisible = false;
			this.DgvMacro.RowTemplate.Height = 21;
			this.DgvMacro.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.DgvMacro.Size = new System.Drawing.Size(68, 23);
			this.DgvMacro.StandardTab = true;
			this.DgvMacro.TabIndex = 0;
			this.DgvMacro.TabStop = false;
			this.DgvMacro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvMacro_CellFormatting);
			this.DgvMacro.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMacro_CellMouseClick);
			this.DgvMacro.Enter += new System.EventHandler(this.DgvMacro_Enter);
			this.DgvMacro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvMacro_KeyDown);
			this.DgvMacro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvMacro_KeyUp);
			this.DgvMacro.Leave += new System.EventHandler(this.DgvMacro_Leave);
			// 
			// DgvTb11
			// 
			this.DgvTb11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DgvTb11.ContextMenuStrip = this.CmsNull;
			this.DgvTb11.FillWeight = 150F;
			this.DgvTb11.HeaderText = "マクロ";
			this.DgvTb11.MinimumWidth = 85;
			this.DgvTb11.Name = "DgvTb11";
			this.DgvTb11.ReadOnly = true;
			this.DgvTb11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DgvTb11.Width = 85;
			// 
			// CmsNull
			// 
			this.CmsNull.Name = "contextMenuStrip0";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// DgvTb12
			// 
			this.DgvTb12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DgvTb12.ContextMenuStrip = this.CmsNull;
			this.DgvTb12.FillWeight = 150F;
			this.DgvTb12.HeaderText = "説明";
			this.DgvTb12.MinimumWidth = 545;
			this.DgvTb12.Name = "DgvTb12";
			this.DgvTb12.ReadOnly = true;
			this.DgvTb12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DgvTb12.Width = 545;
			// 
			// CmsResult
			// 
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsResult_全選択,
			this.toolStripSeparator8,
			this.CmsResult_全クリア,
			this.CmsResult_全コピー,
			this.CmsResult_上書き,
			this.CmsResult_L3,
			this.CmsResult_貼り付け,
			this.CmsResult_ファイル名を貼り付け,
			this.toolStripSeparator11,
			this.CmsResult_名前を付けて保存});
			this.CmsResult.Name = "CmsResult";
			this.CmsResult.Size = new System.Drawing.Size(171, 176);
			// 
			// CmsResult_全選択
			// 
			this.CmsResult_全選択.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_全選択.Image")));
			this.CmsResult_全選択.Name = "CmsResult_全選択";
			this.CmsResult_全選択.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_全選択.Text = "全選択";
			this.CmsResult_全選択.Click += new System.EventHandler(this.CmsResult_全選択_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(167, 6);
			// 
			// CmsResult_全クリア
			// 
			this.CmsResult_全クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_全クリア.Image")));
			this.CmsResult_全クリア.Name = "CmsResult_全クリア";
			this.CmsResult_全クリア.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_全クリア.Text = "全クリア";
			this.CmsResult_全クリア.Click += new System.EventHandler(this.CmsResult_全クリア_Click);
			// 
			// CmsResult_全コピー
			// 
			this.CmsResult_全コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_全コピー.Image")));
			this.CmsResult_全コピー.Name = "CmsResult_全コピー";
			this.CmsResult_全コピー.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_全コピー.Text = "全コピー";
			this.CmsResult_全コピー.Click += new System.EventHandler(this.CmsResult_全コピー_Click);
			// 
			// CmsResult_上書き
			// 
			this.CmsResult_上書き.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_上書き.Image")));
			this.CmsResult_上書き.Name = "CmsResult_上書き";
			this.CmsResult_上書き.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_上書き.Text = "上書き";
			this.CmsResult_上書き.Click += new System.EventHandler(this.CmsResult_上書き_Click);
			// 
			// CmsResult_L3
			// 
			this.CmsResult_L3.Name = "CmsResult_L3";
			this.CmsResult_L3.Size = new System.Drawing.Size(167, 6);
			// 
			// CmsResult_貼り付け
			// 
			this.CmsResult_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_貼り付け.Image")));
			this.CmsResult_貼り付け.Name = "CmsResult_貼り付け";
			this.CmsResult_貼り付け.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_貼り付け.Text = "貼り付け";
			this.CmsResult_貼り付け.Click += new System.EventHandler(this.CmsResult_貼り付け_Click);
			// 
			// CmsResult_ファイル名を貼り付け
			// 
			this.CmsResult_ファイル名を貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_ファイル名を貼り付け.Image")));
			this.CmsResult_ファイル名を貼り付け.Name = "CmsResult_ファイル名を貼り付け";
			this.CmsResult_ファイル名を貼り付け.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_ファイル名を貼り付け.Text = "ファイル名を貼り付け";
			this.CmsResult_ファイル名を貼り付け.Click += new System.EventHandler(this.CmsResult_ファイル名を貼り付け_Click);
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(167, 6);
			// 
			// CmsResult_名前を付けて保存
			// 
			this.CmsResult_名前を付けて保存.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmsResult_名前を付けて保存.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_名前を付けて保存.Image")));
			this.CmsResult_名前を付けて保存.Name = "CmsResult_名前を付けて保存";
			this.CmsResult_名前を付けて保存.Size = new System.Drawing.Size(170, 22);
			this.CmsResult_名前を付けて保存.Text = "名前を付けて保存";
			this.CmsResult_名前を付けて保存.Click += new System.EventHandler(this.CmsResult_名前を付けて保存_Click);
			// 
			// TbCmd
			// 
			this.TbCmd.AllowDrop = true;
			this.TbCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TbCmd.BackColor = System.Drawing.Color.White;
			this.TbCmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbCmd.ContextMenuStrip = this.CmsCmd;
			this.TbCmd.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbCmd.ForeColor = System.Drawing.Color.Black;
			this.TbCmd.Location = new System.Drawing.Point(11, 24);
			this.TbCmd.Margin = new System.Windows.Forms.Padding(0);
			this.TbCmd.Multiline = true;
			this.TbCmd.Name = "TbCmd";
			this.TbCmd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.TbCmd.Size = new System.Drawing.Size(483, 45);
			this.TbCmd.TabIndex = 0;
			this.TbCmd.WordWrap = false;
			this.TbCmd.TextChanged += new System.EventHandler(this.TbCmd_TextChanged);
			this.TbCmd.DragDrop += new System.Windows.Forms.DragEventHandler(this.TbCmd_DragDrop);
			this.TbCmd.DragEnter += new System.Windows.Forms.DragEventHandler(this.TbCmd_DragEnter);
			this.TbCmd.Enter += new System.EventHandler(this.TbCmd_Enter);
			this.TbCmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbCmd_KeyDown);
			this.TbCmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCmd_KeyPress);
			this.TbCmd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbCmd_KeyUp);
			this.TbCmd.Leave += new System.EventHandler(this.TbCmd_Leave);
			this.TbCmd.MouseHover += new System.EventHandler(this.TbCmd_MouseHover);
			this.TbCmd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbCmd_MouseUp);
			// 
			// CmsCmd
			// 
			this.CmsCmd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmd_全クリア,
			this.CmsCmd_全コピー,
			this.CmsCmd_上書き,
			this.toolStripSeparator1,
			this.CmsCmd_貼り付け,
			this.CmsCmd_マクロ変数,
			this.CmsCmd_定数など,
			this.toolStripSeparator4,
			this.CmsCmd_フォルダ選択,
			this.CmsCmd_ファイル選択,
			this.toolStripSeparator7,
			this.CmsCmd_コマンドをグループ化,
			this.CmsCmd_コマンドを保存,
			this.CmsCmd_コマンドを読込});
			this.CmsCmd.Name = "CmsResult";
			this.CmsCmd.Size = new System.Drawing.Size(166, 264);
			// 
			// CmsCmd_全クリア
			// 
			this.CmsCmd_全クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_全クリア.Image")));
			this.CmsCmd_全クリア.Name = "CmsCmd_全クリア";
			this.CmsCmd_全クリア.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_全クリア.Text = "全クリア";
			this.CmsCmd_全クリア.Click += new System.EventHandler(this.CmsCmd_全クリア_Click);
			// 
			// CmsCmd_全コピー
			// 
			this.CmsCmd_全コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_全コピー.Image")));
			this.CmsCmd_全コピー.Name = "CmsCmd_全コピー";
			this.CmsCmd_全コピー.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_全コピー.Text = "全コピー";
			this.CmsCmd_全コピー.Click += new System.EventHandler(this.CmsCmd_全コピー_Click);
			// 
			// CmsCmd_上書き
			// 
			this.CmsCmd_上書き.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_上書き.Image")));
			this.CmsCmd_上書き.Name = "CmsCmd_上書き";
			this.CmsCmd_上書き.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_上書き.Text = "上書き";
			this.CmsCmd_上書き.Click += new System.EventHandler(this.CmsCmd_上書き_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
			// 
			// CmsCmd_貼り付け
			// 
			this.CmsCmd_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_貼り付け.Image")));
			this.CmsCmd_貼り付け.Name = "CmsCmd_貼り付け";
			this.CmsCmd_貼り付け.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_貼り付け.Text = "貼り付け";
			this.CmsCmd_貼り付け.Click += new System.EventHandler(this.CmsCmd_貼り付け_Click);
			// 
			// CmsCmd_マクロ変数
			// 
			this.CmsCmd_マクロ変数.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmd_マクロ変数_タブ,
			this.CmsCmd_マクロ変数_改行,
			this.toolStripSeparator14,
			this.CmsCmd_マクロ変数_日付,
			this.CmsCmd_マクロ変数_時間,
			this.CmsCmd_マクロ変数_マイクロ秒,
			this.toolStripSeparator12,
			this.CmsCmd_マクロ変数_出力のデータ,
			this.toolStripSeparator13,
			this.CmsCmd_マクロ変数_出力の行番号,
			this.CmsCmd_マクロ変数_出力の行データ});
			this.CmsCmd_マクロ変数.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数.Image")));
			this.CmsCmd_マクロ変数.Name = "CmsCmd_マクロ変数";
			this.CmsCmd_マクロ変数.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_マクロ変数.Text = "マクロ変数";
			// 
			// CmsCmd_マクロ変数_タブ
			// 
			this.CmsCmd_マクロ変数_タブ.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_タブ.Image")));
			this.CmsCmd_マクロ変数_タブ.Name = "CmsCmd_マクロ変数_タブ";
			this.CmsCmd_マクロ変数_タブ.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_タブ.Text = "タブ #{\\t}";
			this.CmsCmd_マクロ変数_タブ.Click += new System.EventHandler(this.CmsCmd_マクロ変数_タブ_Click);
			// 
			// CmsCmd_マクロ変数_改行
			// 
			this.CmsCmd_マクロ変数_改行.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_改行.Image")));
			this.CmsCmd_マクロ変数_改行.Name = "CmsCmd_マクロ変数_改行";
			this.CmsCmd_マクロ変数_改行.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_改行.Text = "改行 #{\\n}";
			this.CmsCmd_マクロ変数_改行.Click += new System.EventHandler(this.CmsCmd_マクロ変数_改行_Click);
			// 
			// toolStripSeparator14
			// 
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new System.Drawing.Size(332, 6);
			// 
			// CmsCmd_マクロ変数_日付
			// 
			this.CmsCmd_マクロ変数_日付.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmd_マクロ変数_年,
			this.CmsCmd_マクロ変数_月,
			this.CmsCmd_マクロ変数_日});
			this.CmsCmd_マクロ変数_日付.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_日付.Image")));
			this.CmsCmd_マクロ変数_日付.Name = "CmsCmd_マクロ変数_日付";
			this.CmsCmd_マクロ変数_日付.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_日付.Text = "日付 #{ymd}";
			this.CmsCmd_マクロ変数_日付.Click += new System.EventHandler(this.CmsCmd_マクロ変数_日付_Click);
			// 
			// CmsCmd_マクロ変数_年
			// 
			this.CmsCmd_マクロ変数_年.Name = "CmsCmd_マクロ変数_年";
			this.CmsCmd_マクロ変数_年.Size = new System.Drawing.Size(114, 22);
			this.CmsCmd_マクロ変数_年.Text = "年 #{y}";
			this.CmsCmd_マクロ変数_年.Click += new System.EventHandler(this.CmsCmd_マクロ変数_年_Click);
			// 
			// CmsCmd_マクロ変数_月
			// 
			this.CmsCmd_マクロ変数_月.Name = "CmsCmd_マクロ変数_月";
			this.CmsCmd_マクロ変数_月.Size = new System.Drawing.Size(114, 22);
			this.CmsCmd_マクロ変数_月.Text = "月 #{m}";
			this.CmsCmd_マクロ変数_月.Click += new System.EventHandler(this.CmsCmd_マクロ変数_月_Click);
			// 
			// CmsCmd_マクロ変数_日
			// 
			this.CmsCmd_マクロ変数_日.Name = "CmsCmd_マクロ変数_日";
			this.CmsCmd_マクロ変数_日.Size = new System.Drawing.Size(114, 22);
			this.CmsCmd_マクロ変数_日.Text = "日 #{d}";
			this.CmsCmd_マクロ変数_日.Click += new System.EventHandler(this.CmsCmd_マクロ変数_日_Click);
			// 
			// CmsCmd_マクロ変数_時間
			// 
			this.CmsCmd_マクロ変数_時間.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmd_マクロ変数_時,
			this.CmsCmd_マクロ変数_分,
			this.CmsCmd_マクロ変数_秒});
			this.CmsCmd_マクロ変数_時間.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_時間.Image")));
			this.CmsCmd_マクロ変数_時間.Name = "CmsCmd_マクロ変数_時間";
			this.CmsCmd_マクロ変数_時間.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_時間.Text = "時間 #{hns}";
			this.CmsCmd_マクロ変数_時間.Click += new System.EventHandler(this.CmsCmd_マクロ変数_時間_Click);
			// 
			// CmsCmd_マクロ変数_時
			// 
			this.CmsCmd_マクロ変数_時.Name = "CmsCmd_マクロ変数_時";
			this.CmsCmd_マクロ変数_時.Size = new System.Drawing.Size(111, 22);
			this.CmsCmd_マクロ変数_時.Text = "時 #{h}";
			this.CmsCmd_マクロ変数_時.Click += new System.EventHandler(this.CmsCmd_マクロ変数_時_Click);
			// 
			// CmsCmd_マクロ変数_分
			// 
			this.CmsCmd_マクロ変数_分.Name = "CmsCmd_マクロ変数_分";
			this.CmsCmd_マクロ変数_分.Size = new System.Drawing.Size(111, 22);
			this.CmsCmd_マクロ変数_分.Text = "分 #{n}";
			this.CmsCmd_マクロ変数_分.Click += new System.EventHandler(this.CmsCmd_マクロ変数_分_Click);
			// 
			// CmsCmd_マクロ変数_秒
			// 
			this.CmsCmd_マクロ変数_秒.Name = "CmsCmd_マクロ変数_秒";
			this.CmsCmd_マクロ変数_秒.Size = new System.Drawing.Size(111, 22);
			this.CmsCmd_マクロ変数_秒.Text = "秒 #{s}";
			this.CmsCmd_マクロ変数_秒.Click += new System.EventHandler(this.CmsCmd_マクロ変数_秒_Click);
			// 
			// CmsCmd_マクロ変数_マイクロ秒
			// 
			this.CmsCmd_マクロ変数_マイクロ秒.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_マイクロ秒.Image")));
			this.CmsCmd_マクロ変数_マイクロ秒.Name = "CmsCmd_マクロ変数_マイクロ秒";
			this.CmsCmd_マクロ変数_マイクロ秒.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_マイクロ秒.Text = "マイクロ秒 #{msec}";
			this.CmsCmd_マクロ変数_マイクロ秒.Click += new System.EventHandler(this.CmsCmd_マクロ変数_マイクロ秒_Click);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(332, 6);
			// 
			// CmsCmd_マクロ変数_出力のデータ
			// 
			this.CmsCmd_マクロ変数_出力のデータ.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_出力のデータ.Image")));
			this.CmsCmd_マクロ変数_出力のデータ.Name = "CmsCmd_マクロ変数_出力のデータ";
			this.CmsCmd_マクロ変数_出力のデータ.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_出力のデータ.Text = "出力[NUM]のデータ #{result,[NUM]}";
			this.CmsCmd_マクロ変数_出力のデータ.Click += new System.EventHandler(this.CmsCmd_マクロ変数_出力のデータ_Click);
			// 
			// toolStripSeparator13
			// 
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new System.Drawing.Size(332, 6);
			// 
			// CmsCmd_マクロ変数_出力の行番号
			// 
			this.CmsCmd_マクロ変数_出力の行番号.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_出力の行番号.Image")));
			this.CmsCmd_マクロ変数_出力の行番号.Name = "CmsCmd_マクロ変数_出力の行番号";
			this.CmsCmd_マクロ変数_出力の行番号.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_出力の行番号.Text = "出力の行番号（[NUM]で桁数指定）#{line,[NUM]}";
			this.CmsCmd_マクロ変数_出力の行番号.Click += new System.EventHandler(this.CmsCmd_マクロ変数_出力の行番号_Click);
			// 
			// CmsCmd_マクロ変数_出力の行データ
			// 
			this.CmsCmd_マクロ変数_出力の行データ.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_マクロ変数_出力の行データ.Image")));
			this.CmsCmd_マクロ変数_出力の行データ.Name = "CmsCmd_マクロ変数_出力の行データ";
			this.CmsCmd_マクロ変数_出力の行データ.Size = new System.Drawing.Size(335, 22);
			this.CmsCmd_マクロ変数_出力の行データ.Text = "出力の行データ #{}";
			this.CmsCmd_マクロ変数_出力の行データ.Click += new System.EventHandler(this.CmsCmd_マクロ変数_出力の行データ_Click);
			// 
			// CmsCmd_定数など
			// 
			this.CmsCmd_定数など.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmd_定数など_SJIS,
			this.CmsCmd_定数など_UTF8});
			this.CmsCmd_定数など.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_定数など.Image")));
			this.CmsCmd_定数など.Name = "CmsCmd_定数など";
			this.CmsCmd_定数など.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_定数など.Text = "定数など";
			// 
			// CmsCmd_定数など_SJIS
			// 
			this.CmsCmd_定数など_SJIS.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_定数など_SJIS.Image")));
			this.CmsCmd_定数など_SJIS.Name = "CmsCmd_定数など_SJIS";
			this.CmsCmd_定数など_SJIS.Size = new System.Drawing.Size(116, 22);
			this.CmsCmd_定数など_SJIS.Text = "Shift_JIS";
			this.CmsCmd_定数など_SJIS.Click += new System.EventHandler(this.CmsCmd_定数など_SJIS_Click);
			// 
			// CmsCmd_定数など_UTF8
			// 
			this.CmsCmd_定数など_UTF8.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_定数など_UTF8.Image")));
			this.CmsCmd_定数など_UTF8.Name = "CmsCmd_定数など_UTF8";
			this.CmsCmd_定数など_UTF8.Size = new System.Drawing.Size(116, 22);
			this.CmsCmd_定数など_UTF8.Text = "UTF-8";
			this.CmsCmd_定数など_UTF8.Click += new System.EventHandler(this.CmsCmd_定数など_UTF8_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
			// 
			// CmsCmd_フォルダ選択
			// 
			this.CmsCmd_フォルダ選択.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_フォルダ選択.Image")));
			this.CmsCmd_フォルダ選択.Name = "CmsCmd_フォルダ選択";
			this.CmsCmd_フォルダ選択.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_フォルダ選択.Text = "フォルダ選択";
			this.CmsCmd_フォルダ選択.Click += new System.EventHandler(this.CmsCmd_フォルダ選択_Click);
			// 
			// CmsCmd_ファイル選択
			// 
			this.CmsCmd_ファイル選択.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_ファイル選択.Image")));
			this.CmsCmd_ファイル選択.Name = "CmsCmd_ファイル選択";
			this.CmsCmd_ファイル選択.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_ファイル選択.Text = "ファイル選択";
			this.CmsCmd_ファイル選択.Click += new System.EventHandler(this.CmsCmd_ファイル選択_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(162, 6);
			// 
			// CmsCmd_コマンドをグループ化
			// 
			this.CmsCmd_コマンドをグループ化.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmd_コマンドをグループ化_追加,
			this.CmsCmd_コマンドをグループ化_出力,
			this.CmsCmd_コマンドをグループ化_クリア,
			this.toolStripSeparator5,
			this.CmsCmd_コマンドをグループ化_簡単な説明});
			this.CmsCmd_コマンドをグループ化.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドをグループ化.Image")));
			this.CmsCmd_コマンドをグループ化.Name = "CmsCmd_コマンドをグループ化";
			this.CmsCmd_コマンドをグループ化.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_コマンドをグループ化.Text = "コマンドをグループ化";
			// 
			// CmsCmd_コマンドをグループ化_追加
			// 
			this.CmsCmd_コマンドをグループ化_追加.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドをグループ化_追加.Image")));
			this.CmsCmd_コマンドをグループ化_追加.Name = "CmsCmd_コマンドをグループ化_追加";
			this.CmsCmd_コマンドをグループ化_追加.Size = new System.Drawing.Size(152, 22);
			this.CmsCmd_コマンドをグループ化_追加.Text = "キャッシュに追加";
			this.CmsCmd_コマンドをグループ化_追加.Click += new System.EventHandler(this.CmsCmd_コマンドをグループ化_追加_Click);
			// 
			// CmsCmd_コマンドをグループ化_出力
			// 
			this.CmsCmd_コマンドをグループ化_出力.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドをグループ化_出力.Image")));
			this.CmsCmd_コマンドをグループ化_出力.Name = "CmsCmd_コマンドをグループ化_出力";
			this.CmsCmd_コマンドをグループ化_出力.Size = new System.Drawing.Size(152, 22);
			this.CmsCmd_コマンドをグループ化_出力.Text = "出力";
			this.CmsCmd_コマンドをグループ化_出力.Click += new System.EventHandler(this.CmsCmd_コマンドをグループ化_出力_Click);
			// 
			// CmsCmd_コマンドをグループ化_クリア
			// 
			this.CmsCmd_コマンドをグループ化_クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドをグループ化_クリア.Image")));
			this.CmsCmd_コマンドをグループ化_クリア.Name = "CmsCmd_コマンドをグループ化_クリア";
			this.CmsCmd_コマンドをグループ化_クリア.Size = new System.Drawing.Size(152, 22);
			this.CmsCmd_コマンドをグループ化_クリア.Text = "キャッシュをクリア";
			this.CmsCmd_コマンドをグループ化_クリア.Click += new System.EventHandler(this.CmsCmd_コマンドをグループ化_クリア_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
			// 
			// CmsCmd_コマンドをグループ化_簡単な説明
			// 
			this.CmsCmd_コマンドをグループ化_簡単な説明.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドをグループ化_簡単な説明.Image")));
			this.CmsCmd_コマンドをグループ化_簡単な説明.Name = "CmsCmd_コマンドをグループ化_簡単な説明";
			this.CmsCmd_コマンドをグループ化_簡単な説明.Size = new System.Drawing.Size(152, 22);
			this.CmsCmd_コマンドをグループ化_簡単な説明.Text = "簡単な説明";
			this.CmsCmd_コマンドをグループ化_簡単な説明.Click += new System.EventHandler(this.CmsCmd_コマンドをグループ化_簡単な説明_Click);
			// 
			// CmsCmd_コマンドを保存
			// 
			this.CmsCmd_コマンドを保存.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドを保存.Image")));
			this.CmsCmd_コマンドを保存.Name = "CmsCmd_コマンドを保存";
			this.CmsCmd_コマンドを保存.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_コマンドを保存.Text = "コマンドを保存";
			this.CmsCmd_コマンドを保存.Click += new System.EventHandler(this.CmsCmd_コマンドを保存_Click);
			// 
			// CmsCmd_コマンドを読込
			// 
			this.CmsCmd_コマンドを読込.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmd_コマンドを読込.Image")));
			this.CmsCmd_コマンドを読込.Name = "CmsCmd_コマンドを読込";
			this.CmsCmd_コマンドを読込.Size = new System.Drawing.Size(165, 22);
			this.CmsCmd_コマンドを読込.Text = "コマンドを読込";
			this.CmsCmd_コマンドを読込.Click += new System.EventHandler(this.CmsCmd_コマンドを読込_Click);
			// 
			// TbCurDir
			// 
			this.TbCurDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TbCurDir.BackColor = System.Drawing.Color.DimGray;
			this.TbCurDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbCurDir.ContextMenuStrip = this.CmsTbCurDir;
			this.TbCurDir.Cursor = System.Windows.Forms.Cursors.Default;
			this.TbCurDir.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbCurDir.ForeColor = System.Drawing.Color.White;
			this.TbCurDir.Location = new System.Drawing.Point(11, 4);
			this.TbCurDir.Margin = new System.Windows.Forms.Padding(0);
			this.TbCurDir.Name = "TbCurDir";
			this.TbCurDir.ReadOnly = true;
			this.TbCurDir.Size = new System.Drawing.Size(482, 13);
			this.TbCurDir.TabIndex = 0;
			this.TbCurDir.TabStop = false;
			this.TbCurDir.Text = "TbCurDir";
			this.TbCurDir.WordWrap = false;
			this.TbCurDir.Click += new System.EventHandler(this.TbCurDir_Click);
			this.TbCurDir.Enter += new System.EventHandler(this.TbCurDir_Enter);
			this.TbCurDir.Leave += new System.EventHandler(this.TbCurDir_Leave);
			this.TbCurDir.MouseHover += new System.EventHandler(this.TbCurDir_MouseHover);
			// 
			// CmsTbCurDir
			// 
			this.CmsTbCurDir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsTbCurDir_全コピー});
			this.CmsTbCurDir.Name = "CmsResult";
			this.CmsTbCurDir.Size = new System.Drawing.Size(112, 26);
			// 
			// CmsTbCurDir_全コピー
			// 
			this.CmsTbCurDir_全コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsTbCurDir_全コピー.Image")));
			this.CmsTbCurDir_全コピー.Name = "CmsTbCurDir_全コピー";
			this.CmsTbCurDir_全コピー.Size = new System.Drawing.Size(111, 22);
			this.CmsTbCurDir_全コピー.Text = "全コピー";
			this.CmsTbCurDir_全コピー.Click += new System.EventHandler(this.CmsTbCurDir_全コピー_Click);
			// 
			// ToolTip1
			// 
			this.ToolTip1.AutoPopDelay = 6000;
			this.ToolTip1.BackColor = System.Drawing.Color.Ivory;
			this.ToolTip1.ForeColor = System.Drawing.Color.Black;
			this.ToolTip1.InitialDelay = 500;
			this.ToolTip1.ReshowDelay = 100;
			// 
			// BtnCmdExec
			// 
			this.BtnCmdExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCmdExec.BackColor = System.Drawing.Color.RoyalBlue;
			this.BtnCmdExec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnCmdExec.ContextMenuStrip = this.CmsNull;
			this.BtnCmdExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCmdExec.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnCmdExec.ForeColor = System.Drawing.Color.White;
			this.BtnCmdExec.Location = new System.Drawing.Point(415, 134);
			this.BtnCmdExec.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCmdExec.Name = "BtnCmdExec";
			this.BtnCmdExec.Size = new System.Drawing.Size(22, 22);
			this.BtnCmdExec.TabIndex = 0;
			this.BtnCmdExec.TabStop = false;
			this.BtnCmdExec.Text = "▶";
			this.ToolTip1.SetToolTip(this.BtnCmdExec, " [F5] 実行");
			this.BtnCmdExec.UseVisualStyleBackColor = false;
			this.BtnCmdExec.Click += new System.EventHandler(this.BtnCmdExec_Click);
			// 
			// BtnResultMem
			// 
			this.BtnResultMem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnResultMem.BackColor = System.Drawing.Color.RoyalBlue;
			this.BtnResultMem.ContextMenuStrip = this.CmsNull;
			this.BtnResultMem.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnResultMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResultMem.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnResultMem.ForeColor = System.Drawing.Color.White;
			this.BtnResultMem.Location = new System.Drawing.Point(87, 410);
			this.BtnResultMem.Margin = new System.Windows.Forms.Padding(0);
			this.BtnResultMem.Name = "BtnResultMem";
			this.BtnResultMem.Size = new System.Drawing.Size(22, 22);
			this.BtnResultMem.TabIndex = 0;
			this.BtnResultMem.TabStop = false;
			this.BtnResultMem.Text = "▲";
			this.ToolTip1.SetToolTip(this.BtnResultMem, "[F9] 出力を直前に戻す");
			this.BtnResultMem.UseVisualStyleBackColor = false;
			this.BtnResultMem.Click += new System.EventHandler(this.BtnResultMem_Click);
			// 
			// CbTextCode
			// 
			this.CbTextCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CbTextCode.BackColor = System.Drawing.Color.DimGray;
			this.CbTextCode.ContextMenuStrip = this.CmsCbTextCode;
			this.CbTextCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbTextCode.DropDownWidth = 72;
			this.CbTextCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbTextCode.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbTextCode.ForeColor = System.Drawing.Color.White;
			this.CbTextCode.FormattingEnabled = true;
			this.CbTextCode.Location = new System.Drawing.Point(325, 135);
			this.CbTextCode.Margin = new System.Windows.Forms.Padding(0);
			this.CbTextCode.Name = "CbTextCode";
			this.CbTextCode.Size = new System.Drawing.Size(72, 20);
			this.CbTextCode.TabIndex = 0;
			this.CbTextCode.TabStop = false;
			this.ToolTip1.SetToolTip(this.CbTextCode, "[F4] 出力文字コード");
			this.CbTextCode.SelectedIndexChanged += new System.EventHandler(this.CbTextCode_SelectedIndexChanged);
			this.CbTextCode.Enter += new System.EventHandler(this.CbTextCode_Enter);
			this.CbTextCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CbTextCode_KeyUp);
			this.CbTextCode.Leave += new System.EventHandler(this.CbTextCode_Leave);
			// 
			// CmsCbTextCode
			// 
			this.CmsCbTextCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCbTextCode_全コピー});
			this.CmsCbTextCode.Name = "CmsResult";
			this.CmsCbTextCode.Size = new System.Drawing.Size(112, 26);
			// 
			// CmsCbTextCode_全コピー
			// 
			this.CmsCbTextCode_全コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsCbTextCode_全コピー.Image")));
			this.CmsCbTextCode_全コピー.Name = "CmsCbTextCode_全コピー";
			this.CmsCbTextCode_全コピー.Size = new System.Drawing.Size(111, 22);
			this.CmsCbTextCode_全コピー.Text = "全コピー";
			this.CmsCbTextCode_全コピー.Click += new System.EventHandler(this.CmsCbTextCode_全コピー_Click);
			// 
			// CbCmdHistory
			// 
			this.CbCmdHistory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.CbCmdHistory.ContextMenuStrip = this.CmsNull;
			this.CbCmdHistory.DropDownHeight = 140;
			this.CbCmdHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbCmdHistory.DropDownWidth = 482;
			this.CbCmdHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbCmdHistory.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbCmdHistory.ForeColor = System.Drawing.Color.Black;
			this.CbCmdHistory.FormattingEnabled = true;
			this.CbCmdHistory.IntegralHeight = false;
			this.CbCmdHistory.ItemHeight = 13;
			this.CbCmdHistory.Location = new System.Drawing.Point(11, 135);
			this.CbCmdHistory.Margin = new System.Windows.Forms.Padding(0);
			this.CbCmdHistory.MaxDropDownItems = 10;
			this.CbCmdHistory.Name = "CbCmdHistory";
			this.CbCmdHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CbCmdHistory.Size = new System.Drawing.Size(55, 21);
			this.CbCmdHistory.TabIndex = 0;
			this.CbCmdHistory.TabStop = false;
			this.ToolTip1.SetToolTip(this.CbCmdHistory, "[F1] マクロ・コマンド履歴");
			this.CbCmdHistory.DropDownClosed += new System.EventHandler(this.CbCmdHistory_DropDownClosed);
			this.CbCmdHistory.Enter += new System.EventHandler(this.CbCmdHistory_Enter);
			this.CbCmdHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbCmdHistory_KeyDown);
			this.CbCmdHistory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CbCmdHistory_KeyUp);
			this.CbCmdHistory.Leave += new System.EventHandler(this.CbCmdHistory_Leave);
			// 
			// CbResultHistory
			// 
			this.CbResultHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CbResultHistory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.CbResultHistory.ContextMenuStrip = this.CmsNull;
			this.CbResultHistory.DropDownHeight = 140;
			this.CbResultHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbResultHistory.DropDownWidth = 482;
			this.CbResultHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbResultHistory.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbResultHistory.ForeColor = System.Drawing.Color.Black;
			this.CbResultHistory.FormattingEnabled = true;
			this.CbResultHistory.IntegralHeight = false;
			this.CbResultHistory.ItemHeight = 12;
			this.CbResultHistory.Location = new System.Drawing.Point(11, 411);
			this.CbResultHistory.Margin = new System.Windows.Forms.Padding(0);
			this.CbResultHistory.MaxDropDownItems = 10;
			this.CbResultHistory.Name = "CbResultHistory";
			this.CbResultHistory.Size = new System.Drawing.Size(70, 20);
			this.CbResultHistory.TabIndex = 0;
			this.CbResultHistory.TabStop = false;
			this.ToolTip1.SetToolTip(this.CbResultHistory, "[F8] 出力履歴");
			this.CbResultHistory.DropDownClosed += new System.EventHandler(this.CbResultHistory_DropDownClosed);
			this.CbResultHistory.Enter += new System.EventHandler(this.CbResultHistory_Enter);
			this.CbResultHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbResultHistory_KeyDown);
			this.CbResultHistory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CbResultHistory_KeyUp);
			this.CbResultHistory.Leave += new System.EventHandler(this.CbResultHistory_Leave);
			// 
			// BtnAllClear
			// 
			this.BtnAllClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAllClear.BackColor = System.Drawing.Color.Crimson;
			this.BtnAllClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BtnAllClear.ContextMenuStrip = this.CmsNull;
			this.BtnAllClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAllClear.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnAllClear.ForeColor = System.Drawing.Color.White;
			this.BtnAllClear.Location = new System.Drawing.Point(472, 134);
			this.BtnAllClear.Margin = new System.Windows.Forms.Padding(0);
			this.BtnAllClear.Name = "BtnAllClear";
			this.BtnAllClear.Size = new System.Drawing.Size(22, 22);
			this.BtnAllClear.TabIndex = 0;
			this.BtnAllClear.TabStop = false;
			this.BtnAllClear.Text = "✖";
			this.ToolTip1.SetToolTip(this.BtnAllClear, "[F7] 出力をクリア");
			this.BtnAllClear.UseVisualStyleBackColor = false;
			this.BtnAllClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// BtnDgvMacro
			// 
			this.BtnDgvMacro.BackColor = System.Drawing.Color.LightYellow;
			this.BtnDgvMacro.ContextMenuStrip = this.CmsNull;
			this.BtnDgvMacro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnDgvMacro.Font = new System.Drawing.Font("Yu Gothic UI", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnDgvMacro.ForeColor = System.Drawing.Color.Black;
			this.BtnDgvMacro.Location = new System.Drawing.Point(73, 138);
			this.BtnDgvMacro.Margin = new System.Windows.Forms.Padding(0);
			this.BtnDgvMacro.Name = "BtnDgvMacro";
			this.BtnDgvMacro.Size = new System.Drawing.Size(14, 14);
			this.BtnDgvMacro.TabIndex = 0;
			this.BtnDgvMacro.TabStop = false;
			this.BtnDgvMacro.Text = "✔";
			this.ToolTip1.SetToolTip(this.BtnDgvMacro, "[F2] マクロ");
			this.BtnDgvMacro.UseVisualStyleBackColor = false;
			this.BtnDgvMacro.Click += new System.EventHandler(this.BtnDgvMacro_Click);
			// 
			// BtnDgvCmd
			// 
			this.BtnDgvCmd.BackColor = System.Drawing.Color.LightYellow;
			this.BtnDgvCmd.ContextMenuStrip = this.CmsNull;
			this.BtnDgvCmd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnDgvCmd.Font = new System.Drawing.Font("Yu Gothic UI", 3.75F);
			this.BtnDgvCmd.ForeColor = System.Drawing.Color.Black;
			this.BtnDgvCmd.Location = new System.Drawing.Point(158, 138);
			this.BtnDgvCmd.Margin = new System.Windows.Forms.Padding(0);
			this.BtnDgvCmd.Name = "BtnDgvCmd";
			this.BtnDgvCmd.Size = new System.Drawing.Size(14, 14);
			this.BtnDgvCmd.TabIndex = 0;
			this.BtnDgvCmd.TabStop = false;
			this.BtnDgvCmd.Text = "✔";
			this.ToolTip1.SetToolTip(this.BtnDgvCmd, "[F3] コマンド");
			this.BtnDgvCmd.UseVisualStyleBackColor = false;
			this.BtnDgvCmd.Click += new System.EventHandler(this.BtnDgvCmd_Click);
			// 
			// BtnMemoCopy
			// 
			this.BtnMemoCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnMemoCopy.BackColor = System.Drawing.Color.DimGray;
			this.BtnMemoCopy.ContextMenuStrip = this.CmsNull;
			this.BtnMemoCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMemoCopy.Font = new System.Drawing.Font("Yu Gothic UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnMemoCopy.ForeColor = System.Drawing.Color.White;
			this.BtnMemoCopy.Location = new System.Drawing.Point(444, 134);
			this.BtnMemoCopy.Margin = new System.Windows.Forms.Padding(0);
			this.BtnMemoCopy.Name = "BtnMemoCopy";
			this.BtnMemoCopy.Size = new System.Drawing.Size(22, 22);
			this.BtnMemoCopy.TabIndex = 0;
			this.BtnMemoCopy.TabStop = false;
			this.BtnMemoCopy.Text = "▼";
			this.ToolTip1.SetToolTip(this.BtnMemoCopy, "[F6] メモを出力にコピー");
			this.BtnMemoCopy.UseVisualStyleBackColor = false;
			this.BtnMemoCopy.Click += new System.EventHandler(this.BtnMemoCopy_Click);
			// 
			// TbDgvCmdSearch
			// 
			this.TbDgvCmdSearch.BackColor = System.Drawing.Color.LightYellow;
			this.TbDgvCmdSearch.ContextMenuStrip = this.CmsTbDgvCmdSearch;
			this.TbDgvCmdSearch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbDgvCmdSearch.ForeColor = System.Drawing.Color.Black;
			this.TbDgvCmdSearch.Location = new System.Drawing.Point(237, 135);
			this.TbDgvCmdSearch.Margin = new System.Windows.Forms.Padding(0);
			this.TbDgvCmdSearch.Name = "TbDgvCmdSearch";
			this.TbDgvCmdSearch.Size = new System.Drawing.Size(80, 20);
			this.TbDgvCmdSearch.TabIndex = 0;
			this.TbDgvCmdSearch.TabStop = false;
			this.ToolTip1.SetToolTip(this.TbDgvCmdSearch, "正規表現による検索");
			this.TbDgvCmdSearch.WordWrap = false;
			this.TbDgvCmdSearch.TextChanged += new System.EventHandler(this.TbDgvCmdSearch_TextChanged);
			this.TbDgvCmdSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbDgvCmdSearch_KeyUp);
			// 
			// CmsTbDgvCmdSearch
			// 
			this.CmsTbDgvCmdSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsTbDgvCmdSearch_全クリア,
			this.CmsTbDgvCmdSearch_貼り付け});
			this.CmsTbDgvCmdSearch.Name = "CmsResult";
			this.CmsTbDgvCmdSearch.Size = new System.Drawing.Size(116, 48);
			// 
			// CmsTbDgvCmdSearch_全クリア
			// 
			this.CmsTbDgvCmdSearch_全クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsTbDgvCmdSearch_全クリア.Image")));
			this.CmsTbDgvCmdSearch_全クリア.Name = "CmsTbDgvCmdSearch_全クリア";
			this.CmsTbDgvCmdSearch_全クリア.Size = new System.Drawing.Size(115, 22);
			this.CmsTbDgvCmdSearch_全クリア.Text = "全クリア";
			this.CmsTbDgvCmdSearch_全クリア.Click += new System.EventHandler(this.CmsTbDgvCmdSearch_全クリア_Click);
			// 
			// CmsTbDgvCmdSearch_貼り付け
			// 
			this.CmsTbDgvCmdSearch_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsTbDgvCmdSearch_貼り付け.Image")));
			this.CmsTbDgvCmdSearch_貼り付け.Name = "CmsTbDgvCmdSearch_貼り付け";
			this.CmsTbDgvCmdSearch_貼り付け.Size = new System.Drawing.Size(115, 22);
			this.CmsTbDgvCmdSearch_貼り付け.Text = "貼り付け";
			this.CmsTbDgvCmdSearch_貼り付け.Click += new System.EventHandler(this.CmsTbDgvCmdSearch_貼り付け_Click);
			// 
			// NudTbResult
			// 
			this.NudTbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.NudTbResult.BackColor = System.Drawing.Color.DimGray;
			this.NudTbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NudTbResult.ContextMenuStrip = this.CmsNull;
			this.NudTbResult.Cursor = System.Windows.Forms.Cursors.Default;
			this.NudTbResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.NudTbResult.ForeColor = System.Drawing.Color.White;
			this.NudTbResult.Location = new System.Drawing.Point(437, 411);
			this.NudTbResult.Margin = new System.Windows.Forms.Padding(0);
			this.NudTbResult.Maximum = new decimal(new int[] {
			22,
			0,
			0,
			0});
			this.NudTbResult.Minimum = new decimal(new int[] {
			4,
			0,
			0,
			0});
			this.NudTbResult.Name = "NudTbResult";
			this.NudTbResult.Size = new System.Drawing.Size(45, 20);
			this.NudTbResult.TabIndex = 0;
			this.NudTbResult.TabStop = false;
			this.NudTbResult.Value = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.NudTbResult.ValueChanged += new System.EventHandler(this.NudTbResult_ValueChanged);
			this.NudTbResult.DoubleClick += new System.EventHandler(this.NudTbResult_DoubleClick);
			this.NudTbResult.Enter += new System.EventHandler(this.NudTbResult_Enter);
			this.NudTbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NudTbResult_KeyUp);
			this.NudTbResult.Leave += new System.EventHandler(this.NudTbResult_Leave);
			// 
			// Lbl2
			// 
			this.Lbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl2.AutoSize = true;
			this.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Lbl2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl2.ForeColor = System.Drawing.Color.White;
			this.Lbl2.Location = new System.Drawing.Point(481, 412);
			this.Lbl2.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl2.Name = "Lbl2";
			this.Lbl2.Size = new System.Drawing.Size(20, 15);
			this.Lbl2.TabIndex = 0;
			this.Lbl2.Text = "pt";
			this.Lbl2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// DgvCmd
			// 
			this.DgvCmd.AllowUserToAddRows = false;
			this.DgvCmd.AllowUserToDeleteRows = false;
			this.DgvCmd.AllowUserToResizeColumns = false;
			this.DgvCmd.AllowUserToResizeRows = false;
			this.DgvCmd.BackgroundColor = System.Drawing.Color.LightGray;
			this.DgvCmd.ColumnHeadersHeight = 20;
			this.DgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.DgvCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.DgvTb21});
			this.DgvCmd.ContextMenuStrip = this.CmsNull;
			this.DgvCmd.GridColor = System.Drawing.Color.LightGray;
			this.DgvCmd.Location = new System.Drawing.Point(172, 133);
			this.DgvCmd.Margin = new System.Windows.Forms.Padding(0);
			this.DgvCmd.MultiSelect = false;
			this.DgvCmd.Name = "DgvCmd";
			this.DgvCmd.ReadOnly = true;
			this.DgvCmd.RowHeadersVisible = false;
			this.DgvCmd.RowTemplate.Height = 21;
			this.DgvCmd.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.DgvCmd.Size = new System.Drawing.Size(68, 23);
			this.DgvCmd.TabIndex = 0;
			this.DgvCmd.TabStop = false;
			this.DgvCmd.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCmd_CellFormatting);
			this.DgvCmd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCmd_CellMouseClick);
			this.DgvCmd.Enter += new System.EventHandler(this.DgvCmd_Enter);
			this.DgvCmd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvCmd_KeyDown);
			this.DgvCmd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvCmd_KeyUp);
			this.DgvCmd.Leave += new System.EventHandler(this.DgvCmd_Leave);
			// 
			// DgvTb21
			// 
			this.DgvTb21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DgvTb21.ContextMenuStrip = this.CmsNull;
			this.DgvTb21.HeaderText = "コマンド";
			this.DgvTb21.MinimumWidth = 400;
			this.DgvTb21.Name = "DgvTb21";
			this.DgvTb21.ReadOnly = true;
			this.DgvTb21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DgvTb21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DgvTb21.Width = 400;
			// 
			// TbResult
			// 
			this.TbResult.AcceptsTab = true;
			this.TbResult.AllowDrop = true;
			this.TbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TbResult.BackColor = System.Drawing.Color.Black;
			this.TbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbResult.ContextMenuStrip = this.CmsResult;
			this.TbResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbResult.ForeColor = System.Drawing.Color.Lime;
			this.TbResult.Location = new System.Drawing.Point(10, 161);
			this.TbResult.Margin = new System.Windows.Forms.Padding(0);
			this.TbResult.MaxLength = 2147483647;
			this.TbResult.Multiline = true;
			this.TbResult.Name = "TbResult";
			this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbResult.Size = new System.Drawing.Size(484, 239);
			this.TbResult.TabIndex = 0;
			this.TbResult.TabStop = false;
			this.TbResult.WordWrap = false;
			this.TbResult.TextChanged += new System.EventHandler(this.TbResult_TextChanged);
			this.TbResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.TbResult_DragEnter);
			this.TbResult.Enter += new System.EventHandler(this.TbResult_Enter);
			this.TbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbResult_KeyDown);
			this.TbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbResult_KeyUp);
			this.TbResult.Leave += new System.EventHandler(this.TbResult_Leave);
			this.TbResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbResult_MouseUp);
			// 
			// CmsCmdMemo
			// 
			this.CmsCmdMemo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsCmdMemo_全クリア,
			this.CmsCmdMemo_全コピー,
			this.CmsCmdMemo_上書き,
			this.toolStripSeparator2,
			this.CmsCmdMemo_貼り付け});
			this.CmsCmdMemo.Name = "CmsResult";
			this.CmsCmdMemo.Size = new System.Drawing.Size(116, 98);
			// 
			// CmsCmdMemo_全クリア
			// 
			this.CmsCmdMemo_全クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmdMemo_全クリア.Image")));
			this.CmsCmdMemo_全クリア.Name = "CmsCmdMemo_全クリア";
			this.CmsCmdMemo_全クリア.Size = new System.Drawing.Size(115, 22);
			this.CmsCmdMemo_全クリア.Text = "全クリア";
			this.CmsCmdMemo_全クリア.Click += new System.EventHandler(this.CmsCmdMemo_全クリア_Click);
			// 
			// CmsCmdMemo_全コピー
			// 
			this.CmsCmdMemo_全コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmdMemo_全コピー.Image")));
			this.CmsCmdMemo_全コピー.Name = "CmsCmdMemo_全コピー";
			this.CmsCmdMemo_全コピー.Size = new System.Drawing.Size(115, 22);
			this.CmsCmdMemo_全コピー.Text = "全コピー";
			this.CmsCmdMemo_全コピー.Click += new System.EventHandler(this.CmsCmdMemo_全コピー_Click);
			// 
			// CmsCmdMemo_上書き
			// 
			this.CmsCmdMemo_上書き.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmdMemo_上書き.Image")));
			this.CmsCmdMemo_上書き.Name = "CmsCmdMemo_上書き";
			this.CmsCmdMemo_上書き.Size = new System.Drawing.Size(115, 22);
			this.CmsCmdMemo_上書き.Text = "上書き";
			this.CmsCmdMemo_上書き.Click += new System.EventHandler(this.CmsCmdMemo_上書き_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
			// 
			// CmsCmdMemo_貼り付け
			// 
			this.CmsCmdMemo_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsCmdMemo_貼り付け.Image")));
			this.CmsCmdMemo_貼り付け.Name = "CmsCmdMemo_貼り付け";
			this.CmsCmdMemo_貼り付け.Size = new System.Drawing.Size(115, 22);
			this.CmsCmdMemo_貼り付け.Text = "貼り付け";
			this.CmsCmdMemo_貼り付け.Click += new System.EventHandler(this.CmsCmdMemo_貼り付け_Click);
			// 
			// LblWait
			// 
			this.LblWait.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LblWait.AutoSize = true;
			this.LblWait.BackColor = System.Drawing.Color.Red;
			this.LblWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LblWait.Font = new System.Drawing.Font("ＭＳ ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.LblWait.ForeColor = System.Drawing.Color.White;
			this.LblWait.Location = new System.Drawing.Point(198, 24);
			this.LblWait.Margin = new System.Windows.Forms.Padding(0);
			this.LblWait.Name = "LblWait";
			this.LblWait.Padding = new System.Windows.Forms.Padding(14, 4, 8, 5);
			this.LblWait.Size = new System.Drawing.Size(109, 24);
			this.LblWait.TabIndex = 0;
			this.LblWait.Text = "Waiting...";
			this.LblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LblWait.Visible = false;
			// 
			// TbInfo
			// 
			this.TbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.TbInfo.BackColor = System.Drawing.Color.DimGray;
			this.TbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbInfo.ContextMenuStrip = this.CmsNull;
			this.TbInfo.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbInfo.ForeColor = System.Drawing.Color.White;
			this.TbInfo.Location = new System.Drawing.Point(115, 424);
			this.TbInfo.Margin = new System.Windows.Forms.Padding(0);
			this.TbInfo.Name = "TbInfo";
			this.TbInfo.ReadOnly = true;
			this.TbInfo.Size = new System.Drawing.Size(315, 12);
			this.TbInfo.TabIndex = 0;
			this.TbInfo.TabStop = false;
			this.TbInfo.Text = "TbInfo";
			this.TbInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TbInfo.WordWrap = false;
			// 
			// Lbl_F1
			// 
			this.Lbl_F1.AutoSize = true;
			this.Lbl_F1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F1.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F1.ForeColor = System.Drawing.Color.White;
			this.Lbl_F1.Location = new System.Drawing.Point(10, 125);
			this.Lbl_F1.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F1.Name = "Lbl_F1";
			this.Lbl_F1.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F1.TabIndex = 0;
			this.Lbl_F1.Text = "F1";
			// 
			// Lbl_F2
			// 
			this.Lbl_F2.AutoSize = true;
			this.Lbl_F2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F2.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F2.ForeColor = System.Drawing.Color.White;
			this.Lbl_F2.Location = new System.Drawing.Point(86, 125);
			this.Lbl_F2.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F2.Name = "Lbl_F2";
			this.Lbl_F2.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F2.TabIndex = 0;
			this.Lbl_F2.Text = "F2";
			// 
			// Lbl_F3
			// 
			this.Lbl_F3.AutoSize = true;
			this.Lbl_F3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F3.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F3.ForeColor = System.Drawing.Color.White;
			this.Lbl_F3.Location = new System.Drawing.Point(171, 125);
			this.Lbl_F3.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F3.Name = "Lbl_F3";
			this.Lbl_F3.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F3.TabIndex = 0;
			this.Lbl_F3.Text = "F3";
			// 
			// Lbl_F4
			// 
			this.Lbl_F4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_F4.AutoSize = true;
			this.Lbl_F4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F4.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F4.ForeColor = System.Drawing.Color.White;
			this.Lbl_F4.Location = new System.Drawing.Point(324, 125);
			this.Lbl_F4.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F4.Name = "Lbl_F4";
			this.Lbl_F4.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F4.TabIndex = 0;
			this.Lbl_F4.Text = "F4";
			// 
			// Lbl_F5
			// 
			this.Lbl_F5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_F5.AutoSize = true;
			this.Lbl_F5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F5.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F5.ForeColor = System.Drawing.Color.White;
			this.Lbl_F5.Location = new System.Drawing.Point(414, 125);
			this.Lbl_F5.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F5.Name = "Lbl_F5";
			this.Lbl_F5.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F5.TabIndex = 0;
			this.Lbl_F5.Text = "F5";
			// 
			// Lbl_F7
			// 
			this.Lbl_F7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_F7.AutoSize = true;
			this.Lbl_F7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F7.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F7.ForeColor = System.Drawing.Color.White;
			this.Lbl_F7.Location = new System.Drawing.Point(471, 125);
			this.Lbl_F7.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F7.Name = "Lbl_F7";
			this.Lbl_F7.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F7.TabIndex = 0;
			this.Lbl_F7.Text = "F7";
			// 
			// Lbl_F8
			// 
			this.Lbl_F8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_F8.AutoSize = true;
			this.Lbl_F8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F8.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F8.ForeColor = System.Drawing.Color.White;
			this.Lbl_F8.Location = new System.Drawing.Point(10, 401);
			this.Lbl_F8.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F8.Name = "Lbl_F8";
			this.Lbl_F8.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F8.TabIndex = 0;
			this.Lbl_F8.Text = "F8";
			// 
			// Lbl_F9
			// 
			this.Lbl_F9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_F9.AutoSize = true;
			this.Lbl_F9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F9.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F9.ForeColor = System.Drawing.Color.White;
			this.Lbl_F9.Location = new System.Drawing.Point(86, 401);
			this.Lbl_F9.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F9.Name = "Lbl_F9";
			this.Lbl_F9.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F9.TabIndex = 0;
			this.Lbl_F9.Text = "F9";
			// 
			// LblCmd
			// 
			this.LblCmd.AutoSize = true;
			this.LblCmd.BackColor = System.Drawing.Color.DimGray;
			this.LblCmd.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.LblCmd.ForeColor = System.Drawing.Color.Red;
			this.LblCmd.Location = new System.Drawing.Point(0, 28);
			this.LblCmd.Margin = new System.Windows.Forms.Padding(0);
			this.LblCmd.Name = "LblCmd";
			this.LblCmd.Size = new System.Drawing.Size(17, 11);
			this.LblCmd.TabIndex = 0;
			this.LblCmd.Text = "●";
			this.LblCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblCmdMemo
			// 
			this.LblCmdMemo.AutoSize = true;
			this.LblCmdMemo.BackColor = System.Drawing.Color.DimGray;
			this.LblCmdMemo.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.LblCmdMemo.ForeColor = System.Drawing.Color.Red;
			this.LblCmdMemo.Location = new System.Drawing.Point(0, 74);
			this.LblCmdMemo.Margin = new System.Windows.Forms.Padding(0);
			this.LblCmdMemo.Name = "LblCmdMemo";
			this.LblCmdMemo.Size = new System.Drawing.Size(17, 11);
			this.LblCmdMemo.TabIndex = 0;
			this.LblCmdMemo.Text = "●";
			this.LblCmdMemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblResult
			// 
			this.LblResult.AutoSize = true;
			this.LblResult.BackColor = System.Drawing.Color.DimGray;
			this.LblResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.LblResult.ForeColor = System.Drawing.Color.Red;
			this.LblResult.Location = new System.Drawing.Point(0, 165);
			this.LblResult.Margin = new System.Windows.Forms.Padding(0);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(17, 11);
			this.LblResult.TabIndex = 0;
			this.LblResult.Text = "●";
			this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Lbl_F6
			// 
			this.Lbl_F6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Lbl_F6.AutoSize = true;
			this.Lbl_F6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Lbl_F6.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_F6.ForeColor = System.Drawing.Color.White;
			this.Lbl_F6.Location = new System.Drawing.Point(443, 125);
			this.Lbl_F6.Margin = new System.Windows.Forms.Padding(0);
			this.Lbl_F6.Name = "Lbl_F6";
			this.Lbl_F6.Size = new System.Drawing.Size(17, 11);
			this.Lbl_F6.TabIndex = 0;
			this.Lbl_F6.Text = "F6";
			// 
			// LblCurDir
			// 
			this.LblCurDir.AutoSize = true;
			this.LblCurDir.BackColor = System.Drawing.Color.DimGray;
			this.LblCurDir.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.LblCurDir.ForeColor = System.Drawing.Color.Red;
			this.LblCurDir.Location = new System.Drawing.Point(0, 8);
			this.LblCurDir.Margin = new System.Windows.Forms.Padding(0);
			this.LblCurDir.Name = "LblCurDir";
			this.LblCurDir.Size = new System.Drawing.Size(17, 11);
			this.LblCurDir.TabIndex = 4;
			this.LblCurDir.Text = "●";
			this.LblCurDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CmsTextSelect
			// 
			this.CmsTextSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsTextSelect_Cancel,
			this.toolStripSeparator9,
			this.CmsTextSelect_コピー,
			this.CmsTextSelect_切り取り,
			this.toolStripSeparator6,
			this.CmsTextSelect_貼り付け,
			this.toolStripSeparator10,
			this.CmsTextSelect_DQで囲む,
			this.CmsTextSelect_DQを消去,
			this.toolStripSeparator3,
			this.CmsTextSelect_ネット検索,
			this.toolStripSeparator15,
			this.CmsTextSelect_関連付けられたアプリケーションで開く});
			this.CmsTextSelect.Name = "CmsResult";
			this.CmsTextSelect.Size = new System.Drawing.Size(247, 210);
			// 
			// CmsTextSelect_Cancel
			// 
			this.CmsTextSelect_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmsTextSelect_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_Cancel.Image")));
			this.CmsTextSelect_Cancel.Name = "CmsTextSelect_Cancel";
			this.CmsTextSelect_Cancel.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_Cancel.Text = "選択";
			this.CmsTextSelect_Cancel.Click += new System.EventHandler(this.CmsTextSelect_Cancel_Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(243, 6);
			// 
			// CmsTextSelect_コピー
			// 
			this.CmsTextSelect_コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_コピー.Image")));
			this.CmsTextSelect_コピー.Name = "CmsTextSelect_コピー";
			this.CmsTextSelect_コピー.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_コピー.Text = "コピー";
			this.CmsTextSelect_コピー.Click += new System.EventHandler(this.CmsTextSelect_コピー_Click);
			// 
			// CmsTextSelect_切り取り
			// 
			this.CmsTextSelect_切り取り.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_切り取り.Image")));
			this.CmsTextSelect_切り取り.Name = "CmsTextSelect_切り取り";
			this.CmsTextSelect_切り取り.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_切り取り.Text = "切り取り";
			this.CmsTextSelect_切り取り.Click += new System.EventHandler(this.CmsTextSelect_切り取り_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(243, 6);
			// 
			// CmsTextSelect_貼り付け
			// 
			this.CmsTextSelect_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_貼り付け.Image")));
			this.CmsTextSelect_貼り付け.Name = "CmsTextSelect_貼り付け";
			this.CmsTextSelect_貼り付け.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_貼り付け.Text = "貼り付け";
			this.CmsTextSelect_貼り付け.Click += new System.EventHandler(this.CmsTextSelect_貼り付け_Click);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(243, 6);
			// 
			// CmsTextSelect_DQで囲む
			// 
			this.CmsTextSelect_DQで囲む.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_DQで囲む.Image")));
			this.CmsTextSelect_DQで囲む.Name = "CmsTextSelect_DQで囲む";
			this.CmsTextSelect_DQで囲む.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_DQで囲む.Text = "選択範囲を \" で囲む";
			this.CmsTextSelect_DQで囲む.Click += new System.EventHandler(this.CmsTextSelect_DQで囲む_Click);
			// 
			// CmsTextSelect_DQを消去
			// 
			this.CmsTextSelect_DQを消去.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_DQを消去.Image")));
			this.CmsTextSelect_DQを消去.Name = "CmsTextSelect_DQを消去";
			this.CmsTextSelect_DQを消去.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_DQを消去.Text = "選択範囲の \" を消去";
			this.CmsTextSelect_DQを消去.Click += new System.EventHandler(this.CmsTextSelect_DQを消去_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(243, 6);
			// 
			// CmsTextSelect_ネット検索
			// 
			this.CmsTextSelect_ネット検索.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CmsTextSelect_ネット検索_Google,
			this.CmsTextSelect_ネット検索_Google翻訳,
			this.CmsTextSelect_ネット検索_Googleマップ,
			this.CmsTextSelect_ネット検索_YouTube,
			this.CmsTextSelect_ネット検索_Wikipedia});
			this.CmsTextSelect_ネット検索.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_ネット検索.Image")));
			this.CmsTextSelect_ネット検索.Name = "CmsTextSelect_ネット検索";
			this.CmsTextSelect_ネット検索.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_ネット検索.Text = "ネット検索";
			// 
			// CmsTextSelect_ネット検索_Google
			// 
			this.CmsTextSelect_ネット検索_Google.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_ネット検索_Google.Image")));
			this.CmsTextSelect_ネット検索_Google.Name = "CmsTextSelect_ネット検索_Google";
			this.CmsTextSelect_ネット検索_Google.Size = new System.Drawing.Size(141, 22);
			this.CmsTextSelect_ネット検索_Google.Text = "Google";
			this.CmsTextSelect_ネット検索_Google.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_Google_Click);
			// 
			// CmsTextSelect_ネット検索_Google翻訳
			// 
			this.CmsTextSelect_ネット検索_Google翻訳.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_ネット検索_Google翻訳.Image")));
			this.CmsTextSelect_ネット検索_Google翻訳.Name = "CmsTextSelect_ネット検索_Google翻訳";
			this.CmsTextSelect_ネット検索_Google翻訳.Size = new System.Drawing.Size(141, 22);
			this.CmsTextSelect_ネット検索_Google翻訳.Text = "Google 翻訳";
			this.CmsTextSelect_ネット検索_Google翻訳.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_Google翻訳_Click);
			// 
			// CmsTextSelect_ネット検索_Googleマップ
			// 
			this.CmsTextSelect_ネット検索_Googleマップ.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_ネット検索_Googleマップ.Image")));
			this.CmsTextSelect_ネット検索_Googleマップ.Name = "CmsTextSelect_ネット検索_Googleマップ";
			this.CmsTextSelect_ネット検索_Googleマップ.Size = new System.Drawing.Size(141, 22);
			this.CmsTextSelect_ネット検索_Googleマップ.Text = "Google マップ";
			this.CmsTextSelect_ネット検索_Googleマップ.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_Googleマップ_Click);
			// 
			// CmsTextSelect_ネット検索_YouTube
			// 
			this.CmsTextSelect_ネット検索_YouTube.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_ネット検索_YouTube.Image")));
			this.CmsTextSelect_ネット検索_YouTube.Name = "CmsTextSelect_ネット検索_YouTube";
			this.CmsTextSelect_ネット検索_YouTube.Size = new System.Drawing.Size(141, 22);
			this.CmsTextSelect_ネット検索_YouTube.Text = "YouTube";
			this.CmsTextSelect_ネット検索_YouTube.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_YouTube_Click);
			// 
			// CmsTextSelect_ネット検索_Wikipedia
			// 
			this.CmsTextSelect_ネット検索_Wikipedia.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_ネット検索_Wikipedia.Image")));
			this.CmsTextSelect_ネット検索_Wikipedia.Name = "CmsTextSelect_ネット検索_Wikipedia";
			this.CmsTextSelect_ネット検索_Wikipedia.Size = new System.Drawing.Size(141, 22);
			this.CmsTextSelect_ネット検索_Wikipedia.Text = "Wikipedia";
			this.CmsTextSelect_ネット検索_Wikipedia.Click += new System.EventHandler(this.CmsTextSelect_ネット検索_Wikipedia_Click);
			// 
			// toolStripSeparator15
			// 
			this.toolStripSeparator15.Name = "toolStripSeparator15";
			this.toolStripSeparator15.Size = new System.Drawing.Size(243, 6);
			// 
			// CmsTextSelect_関連付けられたアプリケーションで開く
			// 
			this.CmsTextSelect_関連付けられたアプリケーションで開く.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_関連付けられたアプリケーションで開く.Image")));
			this.CmsTextSelect_関連付けられたアプリケーションで開く.Name = "CmsTextSelect_関連付けられたアプリケーションで開く";
			this.CmsTextSelect_関連付けられたアプリケーションで開く.Size = new System.Drawing.Size(246, 22);
			this.CmsTextSelect_関連付けられたアプリケーションで開く.Text = "関連付けられたアプリケーションで開く";
			this.CmsTextSelect_関連付けられたアプリケーションで開く.Click += new System.EventHandler(this.CmsTextSelect_関連付けられたアプリケーションで開く_Click);
			// 
			// RtbCmdMemo
			// 
			this.RtbCmdMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.RtbCmdMemo.BackColor = System.Drawing.Color.Black;
			this.RtbCmdMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RtbCmdMemo.ContextMenuStrip = this.CmsCmdMemo;
			this.RtbCmdMemo.DetectUrls = false;
			this.RtbCmdMemo.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RtbCmdMemo.ForeColor = System.Drawing.Color.Yellow;
			this.RtbCmdMemo.Location = new System.Drawing.Point(10, 70);
			this.RtbCmdMemo.Margin = new System.Windows.Forms.Padding(0);
			this.RtbCmdMemo.Name = "RtbCmdMemo";
			this.RtbCmdMemo.Size = new System.Drawing.Size(485, 52);
			this.RtbCmdMemo.TabIndex = 0;
			this.RtbCmdMemo.TabStop = false;
			this.RtbCmdMemo.Text = "";
			this.RtbCmdMemo.Enter += new System.EventHandler(this.RtbCmdMemo_Enter);
			this.RtbCmdMemo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RtbCmdMemo_KeyUp);
			this.RtbCmdMemo.Leave += new System.EventHandler(this.RtbCmdMemo_Leave);
			this.RtbCmdMemo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RtbCmdMemo_MouseUp);
			// 
			// BtnResult1
			// 
			this.BtnResult1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnResult1.BackColor = System.Drawing.Color.DimGray;
			this.BtnResult1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
			this.BtnResult1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResult1.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnResult1.ForeColor = System.Drawing.Color.White;
			this.BtnResult1.Location = new System.Drawing.Point(127, 400);
			this.BtnResult1.Margin = new System.Windows.Forms.Padding(0);
			this.BtnResult1.Name = "BtnResult1";
			this.BtnResult1.Size = new System.Drawing.Size(58, 18);
			this.BtnResult1.TabIndex = 0;
			this.BtnResult1.TabStop = false;
			this.BtnResult1.Text = "1";
			this.BtnResult1.UseVisualStyleBackColor = false;
			this.BtnResult1.Click += new System.EventHandler(this.BtnResult1_Click);
			// 
			// BtnResult2
			// 
			this.BtnResult2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnResult2.BackColor = System.Drawing.Color.DimGray;
			this.BtnResult2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
			this.BtnResult2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResult2.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnResult2.ForeColor = System.Drawing.Color.White;
			this.BtnResult2.Location = new System.Drawing.Point(184, 400);
			this.BtnResult2.Margin = new System.Windows.Forms.Padding(0);
			this.BtnResult2.Name = "BtnResult2";
			this.BtnResult2.Size = new System.Drawing.Size(58, 18);
			this.BtnResult2.TabIndex = 0;
			this.BtnResult2.TabStop = false;
			this.BtnResult2.Text = "2";
			this.BtnResult2.UseVisualStyleBackColor = false;
			this.BtnResult2.Click += new System.EventHandler(this.BtnResult2_Click);
			// 
			// BtnResult3
			// 
			this.BtnResult3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnResult3.BackColor = System.Drawing.Color.DimGray;
			this.BtnResult3.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
			this.BtnResult3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResult3.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnResult3.ForeColor = System.Drawing.Color.White;
			this.BtnResult3.Location = new System.Drawing.Point(241, 400);
			this.BtnResult3.Margin = new System.Windows.Forms.Padding(0);
			this.BtnResult3.Name = "BtnResult3";
			this.BtnResult3.Size = new System.Drawing.Size(58, 18);
			this.BtnResult3.TabIndex = 0;
			this.BtnResult3.TabStop = false;
			this.BtnResult3.Text = "3";
			this.BtnResult3.UseVisualStyleBackColor = false;
			this.BtnResult3.Click += new System.EventHandler(this.BtnResult3_Click);
			// 
			// BtnResult4
			// 
			this.BtnResult4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnResult4.BackColor = System.Drawing.Color.DimGray;
			this.BtnResult4.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
			this.BtnResult4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResult4.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnResult4.ForeColor = System.Drawing.Color.White;
			this.BtnResult4.Location = new System.Drawing.Point(298, 400);
			this.BtnResult4.Margin = new System.Windows.Forms.Padding(0);
			this.BtnResult4.Name = "BtnResult4";
			this.BtnResult4.Size = new System.Drawing.Size(58, 18);
			this.BtnResult4.TabIndex = 0;
			this.BtnResult4.TabStop = false;
			this.BtnResult4.Text = "4";
			this.BtnResult4.UseVisualStyleBackColor = false;
			this.BtnResult4.Click += new System.EventHandler(this.BtnResult4_Click);
			// 
			// BtnResult5
			// 
			this.BtnResult5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.BtnResult5.BackColor = System.Drawing.Color.DimGray;
			this.BtnResult5.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
			this.BtnResult5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnResult5.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnResult5.ForeColor = System.Drawing.Color.White;
			this.BtnResult5.Location = new System.Drawing.Point(355, 400);
			this.BtnResult5.Margin = new System.Windows.Forms.Padding(0);
			this.BtnResult5.Name = "BtnResult5";
			this.BtnResult5.Size = new System.Drawing.Size(58, 18);
			this.BtnResult5.TabIndex = 0;
			this.BtnResult5.TabStop = false;
			this.BtnResult5.Text = "5";
			this.BtnResult5.UseVisualStyleBackColor = false;
			this.BtnResult5.Click += new System.EventHandler(this.BtnResult5_Click);
			// 
			// PanelResult
			// 
			this.PanelResult.AllowDrop = true;
			this.PanelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.PanelResult.BackColor = System.Drawing.Color.Transparent;
			this.PanelResult.Controls.Add(this.BtnPasteCancel);
			this.PanelResult.Controls.Add(this.BtnPasteFilename);
			this.PanelResult.Controls.Add(this.BtnPasteTextfile);
			this.PanelResult.ForeColor = System.Drawing.Color.Black;
			this.PanelResult.Location = new System.Drawing.Point(10, 161);
			this.PanelResult.Margin = new System.Windows.Forms.Padding(0);
			this.PanelResult.Name = "PanelResult";
			this.PanelResult.Size = new System.Drawing.Size(467, 222);
			this.PanelResult.TabIndex = 0;
			this.PanelResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelResult_DragDrop);
			this.PanelResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelResult_DragEnter);
			this.PanelResult.DragLeave += new System.EventHandler(this.PanelResult_DragLeave);
			// 
			// BtnPasteCancel
			// 
			this.BtnPasteCancel.AllowDrop = true;
			this.BtnPasteCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPasteCancel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BtnPasteCancel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.BtnPasteCancel.FlatAppearance.BorderSize = 2;
			this.BtnPasteCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPasteCancel.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnPasteCancel.ForeColor = System.Drawing.Color.Black;
			this.BtnPasteCancel.Location = new System.Drawing.Point(21, 170);
			this.BtnPasteCancel.Margin = new System.Windows.Forms.Padding(0);
			this.BtnPasteCancel.Name = "BtnPasteCancel";
			this.BtnPasteCancel.Size = new System.Drawing.Size(425, 32);
			this.BtnPasteCancel.TabIndex = 3;
			this.BtnPasteCancel.TabStop = false;
			this.BtnPasteCancel.Text = "キャンセル";
			this.BtnPasteCancel.UseVisualStyleBackColor = false;
			this.BtnPasteCancel.Click += new System.EventHandler(this.BtnPasteCancel_Click);
			this.BtnPasteCancel.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPasteCancel_DragDrop);
			this.BtnPasteCancel.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnPasteCancel_DragEnter);
			// 
			// BtnPasteFilename
			// 
			this.BtnPasteFilename.AllowDrop = true;
			this.BtnPasteFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPasteFilename.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BtnPasteFilename.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
			this.BtnPasteFilename.FlatAppearance.BorderSize = 2;
			this.BtnPasteFilename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPasteFilename.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnPasteFilename.ForeColor = System.Drawing.Color.RoyalBlue;
			this.BtnPasteFilename.Location = new System.Drawing.Point(20, 95);
			this.BtnPasteFilename.Margin = new System.Windows.Forms.Padding(0);
			this.BtnPasteFilename.Name = "BtnPasteFilename";
			this.BtnPasteFilename.Size = new System.Drawing.Size(427, 65);
			this.BtnPasteFilename.TabIndex = 2;
			this.BtnPasteFilename.TabStop = false;
			this.BtnPasteFilename.Text = "[ファイル名]を取得";
			this.BtnPasteFilename.UseVisualStyleBackColor = false;
			this.BtnPasteFilename.Click += new System.EventHandler(this.BtnPasteFilename_Click);
			this.BtnPasteFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPasteFilename_DragDrop);
			this.BtnPasteFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnPasteFilename_DragEnter);
			// 
			// BtnPasteTextfile
			// 
			this.BtnPasteTextfile.AllowDrop = true;
			this.BtnPasteTextfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPasteTextfile.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BtnPasteTextfile.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
			this.BtnPasteTextfile.FlatAppearance.BorderSize = 2;
			this.BtnPasteTextfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPasteTextfile.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnPasteTextfile.ForeColor = System.Drawing.Color.Crimson;
			this.BtnPasteTextfile.Location = new System.Drawing.Point(20, 20);
			this.BtnPasteTextfile.Margin = new System.Windows.Forms.Padding(0);
			this.BtnPasteTextfile.Name = "BtnPasteTextfile";
			this.BtnPasteTextfile.Size = new System.Drawing.Size(427, 65);
			this.BtnPasteTextfile.TabIndex = 1;
			this.BtnPasteTextfile.TabStop = false;
			this.BtnPasteTextfile.Text = "[テキストファイル]を読込";
			this.BtnPasteTextfile.UseVisualStyleBackColor = false;
			this.BtnPasteTextfile.Click += new System.EventHandler(this.BtnPasteTextfile_Click);
			this.BtnPasteTextfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPasteTextfile_DragDrop);
			this.BtnPasteTextfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnPasteTextfile_DragEnter);
			// 
			// BtnCmdExecStream
			// 
			this.BtnCmdExecStream.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.BtnCmdExecStream.BackColor = System.Drawing.Color.RoyalBlue;
			this.BtnCmdExecStream.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.BtnCmdExecStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCmdExecStream.Font = new System.Drawing.Font("Yu Gothic UI", 6F);
			this.BtnCmdExecStream.ForeColor = System.Drawing.Color.White;
			this.BtnCmdExecStream.Location = new System.Drawing.Point(230, 49);
			this.BtnCmdExecStream.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCmdExecStream.Name = "BtnCmdExecStream";
			this.BtnCmdExecStream.Size = new System.Drawing.Size(45, 22);
			this.BtnCmdExecStream.TabIndex = 0;
			this.BtnCmdExecStream.TabStop = false;
			this.BtnCmdExecStream.Text = "✖";
			this.BtnCmdExecStream.UseVisualStyleBackColor = false;
			this.BtnCmdExecStream.Visible = false;
			this.BtnCmdExecStream.Click += new System.EventHandler(this.BtnCmdExecStream_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(504, 441);
			this.Controls.Add(this.BtnCmdExecStream);
			this.Controls.Add(this.LblWait);
			this.Controls.Add(this.PanelResult);
			this.Controls.Add(this.BtnDgvMacro);
			this.Controls.Add(this.DgvMacro);
			this.Controls.Add(this.BtnDgvCmd);
			this.Controls.Add(this.DgvCmd);
			this.Controls.Add(this.TbDgvCmdSearch);
			this.Controls.Add(this.RtbCmdMemo);
			this.Controls.Add(this.TbCmd);
			this.Controls.Add(this.CbResultHistory);
			this.Controls.Add(this.CbCmdHistory);
			this.Controls.Add(this.BtnResultMem);
			this.Controls.Add(this.BtnCmdExec);
			this.Controls.Add(this.NudTbResult);
			this.Controls.Add(this.Lbl2);
			this.Controls.Add(this.TbResult);
			this.Controls.Add(this.TbCurDir);
			this.Controls.Add(this.CbTextCode);
			this.Controls.Add(this.BtnAllClear);
			this.Controls.Add(this.LblCmd);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.LblCmdMemo);
			this.Controls.Add(this.BtnMemoCopy);
			this.Controls.Add(this.TbInfo);
			this.Controls.Add(this.LblCurDir);
			this.Controls.Add(this.Lbl_F1);
			this.Controls.Add(this.Lbl_F2);
			this.Controls.Add(this.Lbl_F3);
			this.Controls.Add(this.Lbl_F4);
			this.Controls.Add(this.Lbl_F5);
			this.Controls.Add(this.Lbl_F6);
			this.Controls.Add(this.Lbl_F7);
			this.Controls.Add(this.Lbl_F8);
			this.Controls.Add(this.Lbl_F9);
			this.Controls.Add(this.BtnResult1);
			this.Controls.Add(this.BtnResult2);
			this.Controls.Add(this.BtnResult3);
			this.Controls.Add(this.BtnResult4);
			this.Controls.Add(this.BtnResult5);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(520, 480);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.DgvMacro)).EndInit();
			this.CmsResult.ResumeLayout(false);
			this.CmsCmd.ResumeLayout(false);
			this.CmsTbCurDir.ResumeLayout(false);
			this.CmsCbTextCode.ResumeLayout(false);
			this.CmsTbDgvCmdSearch.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NudTbResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvCmd)).EndInit();
			this.CmsCmdMemo.ResumeLayout(false);
			this.CmsTextSelect.ResumeLayout(false);
			this.PanelResult.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView DgvMacro;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_貼り付け;
		private System.Windows.Forms.TextBox TbCmd;
		private System.Windows.Forms.ToolStripSeparator CmsResult_L3;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_全コピー;
		private System.Windows.Forms.TextBox TbCurDir;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存;
		private System.Windows.Forms.ContextMenuStrip CmsCmd;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_貼り付け;
		private System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
		private System.Windows.Forms.NumericUpDown NudTbResult;
		private System.Windows.Forms.Label Lbl2;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_全コピー;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_全クリア;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_全クリア;
		private System.Windows.Forms.TextBox TbDgvCmdSearch;
		private System.Windows.Forms.DataGridView DgvCmd;
		private System.Windows.Forms.TextBox TbResult;
		private System.Windows.Forms.Button BtnCmdExec;
		private System.Windows.Forms.Button BtnResultMem;
		private System.Windows.Forms.ContextMenuStrip CmsCmdMemo;
		private System.Windows.Forms.ToolStripMenuItem CmsCmdMemo_全クリア;
		private System.Windows.Forms.ToolStripMenuItem CmsCmdMemo_全コピー;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem CmsCmdMemo_貼り付け;
		private System.Windows.Forms.ComboBox CbTextCode;
		private System.Windows.Forms.ComboBox CbCmdHistory;
		private System.Windows.Forms.ComboBox CbResultHistory;
		private System.Windows.Forms.Label LblWait;
		private System.Windows.Forms.TextBox TbInfo;
		private System.Windows.Forms.Button BtnAllClear;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドをグループ化;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドをグループ化_追加;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドをグループ化_出力;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドを保存;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドを読込;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドをグループ化_クリア;
		private System.Windows.Forms.Button BtnDgvMacro;
		private System.Windows.Forms.Button BtnDgvCmd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_コマンドをグループ化_簡単な説明;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.Label Lbl_F1;
		private System.Windows.Forms.Label Lbl_F2;
		private System.Windows.Forms.Label Lbl_F3;
		private System.Windows.Forms.Label Lbl_F4;
		private System.Windows.Forms.Label Lbl_F5;
		private System.Windows.Forms.Label Lbl_F7;
		private System.Windows.Forms.Label Lbl_F8;
		private System.Windows.Forms.Label Lbl_F9;
		private System.Windows.Forms.Label LblCmd;
		private System.Windows.Forms.Label LblCmdMemo;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnMemoCopy;
		private System.Windows.Forms.Label Lbl_F6;
		private System.Windows.Forms.Label LblCurDir;
		private System.Windows.Forms.ContextMenuStrip CmsCbTextCode;
		private System.Windows.Forms.ToolStripMenuItem CmsCbTextCode_全コピー;
		private System.Windows.Forms.ContextMenuStrip CmsTbCurDir;
		private System.Windows.Forms.ToolStripMenuItem CmsTbCurDir_全コピー;
		private System.Windows.Forms.ContextMenuStrip CmsTbDgvCmdSearch;
		private System.Windows.Forms.ToolStripMenuItem CmsTbDgvCmdSearch_全クリア;
		private System.Windows.Forms.ToolStripMenuItem CmsTbDgvCmdSearch_貼り付け;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_上書き;
		private System.Windows.Forms.ToolStripMenuItem CmsCmdMemo_上書き;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_上書き;
		private System.Windows.Forms.ContextMenuStrip CmsTextSelect;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_コピー;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_切り取り;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_Google;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_YouTube;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_フォルダ選択;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_Wikipedia;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_貼り付け;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_ファイル選択;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_全選択;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_Cancel;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvTb21;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_Google翻訳;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_ネット検索_Googleマップ;
		private System.Windows.Forms.RichTextBox RtbCmdMemo;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_DQで囲む;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_日付;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_時間;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_マイクロ秒;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_DQを消去;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.Button BtnResult1;
		private System.Windows.Forms.Button BtnResult2;
		private System.Windows.Forms.Button BtnResult3;
		private System.Windows.Forms.Button BtnResult4;
		private System.Windows.Forms.Button BtnResult5;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvTb11;
		private System.Windows.Forms.DataGridViewTextBoxColumn DgvTb12;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_年;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_月;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_日;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_時;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_分;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_秒;
		private System.Windows.Forms.Panel PanelResult;
		private System.Windows.Forms.Button BtnPasteTextfile;
		private System.Windows.Forms.Button BtnPasteFilename;
		private System.Windows.Forms.Button BtnPasteCancel;
		private System.Windows.Forms.Button BtnCmdExecStream;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_出力のデータ;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_出力の行番号;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_出力の行データ;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_改行;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_マクロ変数_タブ;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_関連付けられたアプリケーションで開く;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_定数など;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_定数など_SJIS;
		private System.Windows.Forms.ToolStripMenuItem CmsCmd_定数など_UTF8;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_ファイル名を貼り付け;
	}
}

