﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenContainingFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateMergedPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetDependantFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegexTest = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnGetDependantFiles = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnGenerateMergedPage = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = Global.ASPStudio.My.Resources.Resources.Services_5724
        Me.Button1.Location = New System.Drawing.Point(3, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Parse"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(385, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "List of files in provided folder"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(764, 502)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1023, 502)
        Me.SplitContainer1.SplitterDistance = 255
        Me.SplitContainer1.TabIndex = 5
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.HotTracking = True
        Me.TreeView1.LabelEdit = True
        Me.TreeView1.Location = New System.Drawing.Point(0, 13)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(255, 489)
        Me.TreeView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenContainingFolderToolStripMenuItem, Me.ToolStripSeparator1, Me.GenerateMergedPageToolStripMenuItem, Me.GetDependantFilesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 76)
        '
        'OpenContainingFolderToolStripMenuItem
        '
        Me.OpenContainingFolderToolStripMenuItem.Image = Global.ASPStudio.My.Resources.Resources.folder_Open_16xLG
        Me.OpenContainingFolderToolStripMenuItem.Name = "OpenContainingFolderToolStripMenuItem"
        Me.OpenContainingFolderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenContainingFolderToolStripMenuItem.Text = "Open Containing Folder"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        'GenerateMergedPageToolStripMenuItem
        '
        Me.GenerateMergedPageToolStripMenuItem.Image = Global.ASPStudio.My.Resources.Resources.Compilablefile_7113
        Me.GenerateMergedPageToolStripMenuItem.Name = "GenerateMergedPageToolStripMenuItem"
        Me.GenerateMergedPageToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GenerateMergedPageToolStripMenuItem.Text = "Generate Merged Page"
        '
        'GetDependantFilesToolStripMenuItem
        '
        Me.GetDependantFilesToolStripMenuItem.Image = Global.ASPStudio.My.Resources.Resources.asset_treeView_12x12_on
        Me.GetDependantFilesToolStripMenuItem.Name = "GetDependantFilesToolStripMenuItem"
        Me.GetDependantFilesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GetDependantFilesToolStripMenuItem.Text = "Get Dependant Files"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnRegexTest)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnGetDependantFiles)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComboBox2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComboBox1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnGenerateMergedPage)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1023, 591)
        Me.SplitContainer2.SplitterDistance = 502
        Me.SplitContainer2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(826, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Classes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(630, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Methods:"
        '
        'btnRegexTest
        '
        Me.btnRegexTest.Image = Global.ASPStudio.My.Resources.Resources.Services_5724
        Me.btnRegexTest.Location = New System.Drawing.Point(378, 41)
        Me.btnRegexTest.Name = "btnRegexTest"
        Me.btnRegexTest.Size = New System.Drawing.Size(117, 23)
        Me.btnRegexTest.TabIndex = 13
        Me.btnRegexTest.Text = "Regex Test"
        Me.btnRegexTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegexTest.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox3.Location = New System.Drawing.Point(0, 65)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(1023, 20)
        Me.TextBox3.TabIndex = 12
        '
        'btnGetDependantFiles
        '
        Me.btnGetDependantFiles.Image = Global.ASPStudio.My.Resources.Resources.asset_treeView_12x12_on
        Me.btnGetDependantFiles.Location = New System.Drawing.Point(236, 41)
        Me.btnGetDependantFiles.Name = "btnGetDependantFiles"
        Me.btnGetDependantFiles.Size = New System.Drawing.Size(136, 23)
        Me.btnGetDependantFiles.TabIndex = 11
        Me.btnGetDependantFiles.Text = "Get Dependant Files"
        Me.btnGetDependantFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGetDependantFiles.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(878, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(687, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'btnGenerateMergedPage
        '
        Me.btnGenerateMergedPage.Image = Global.ASPStudio.My.Resources.Resources.Compilablefile_7113
        Me.btnGenerateMergedPage.Location = New System.Drawing.Point(84, 41)
        Me.btnGenerateMergedPage.Name = "btnGenerateMergedPage"
        Me.btnGenerateMergedPage.Size = New System.Drawing.Size(146, 23)
        Me.btnGenerateMergedPage.TabIndex = 8
        Me.btnGenerateMergedPage.Text = "Generate Merged Page"
        Me.btnGenerateMergedPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenerateMergedPage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Filter:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(435, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 591)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "Form1"
        Me.Text = "ASPStudio - Includes Mapper"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnGenerateMergedPage As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenContainingFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGetDependantFiles As System.Windows.Forms.Button
    Friend WithEvents GenerateMergedPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetDependantFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnRegexTest As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
