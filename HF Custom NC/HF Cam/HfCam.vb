Public Class frmHfCam
    Private Sub HfCam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        NcTextBox.Clear()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Nc Files |*.nc|Tap Files |*.tap|All Files |*. "
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            NcTextBox.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, NcTextBox.Text)
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        NcTextBox.Undo()
    End Sub
    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        NcTextBox.Redo()
    End Sub
    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        NcTextBox.Cut()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        NcTextBox.Copy()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        NcTextBox.Paste()
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        NcTextBox.SelectAll()
    End Sub
    Private Sub RenumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReNumberToolStripMenuItem.Click
        Dim frmLineNumbering As New frmLineNumbering
        frmLineNumbering.Show()
    End Sub
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            NcTextBox.Font = FontDialog1.Font
        End If
    End Sub
    Private Sub TextColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            NcTextBox.ForeColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            NcTextBox.BackColor = ColorDialog1.Color
        End If
    End Sub
    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If
    End Sub
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub AutoCadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoCadToolStripMenuItem.Click
        Dim CadPath = My.Settings.CadPath

        If System.IO.Directory.Exists(CadPath) Then
            Process.Start(CadPath)
        Else
            MessageBox.Show("Please Select Cad Path in Environment")
        End If
    End Sub
    Private Sub EnvironmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvironmentToolStripMenuItem.Click
        Dim frmEnvironment As New frmEnvironment
        frmEnvironment.Show()
    End Sub

    Private Sub ProgramSignOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramSignOffToolStripMenuItem.Click

    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N10 G00 G20 G40 G80 G99" & vbNewLine &
            "N20 G28 U0" & vbNewLine &
            "N30 G28 W0" & vbNewLine &
            "N40 G54 (WORK OFFSET)" & vbNewLine
    End Sub

    Private Sub ToolChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolChangeToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N50 M01" & vbNewLine &
            "N60 T0101 (TOOL NAME)" & vbNewLine &
            "N70 M41" & vbNewLine &
            "N80 G96 S350" & vbNewLine &
            "N90 M03" & vbNewLine &
            "N100 M08" & vbNewLine &
             vbNewLine &
            "N120 G00 Z1.000 M09" & vbNewLine &
            "N130 M05 G40 G28 U0" & vbNewLine &
            "N140 G28 W0" & vbNewLine
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N150 M30" & vbNewLine
    End Sub

    Private Sub CenterDrillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterDrillToolStripMenuItem.Click
        NcTextBox.SelectedText = "N160 G00 Z.100" & vbNewLine &
            "N170 X.0" & vbNewLine &
            "N180 G01 Z-.400 F.007"
    End Sub

    Private Sub RepeptitiveODToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeptitiveODToolStripMenuItem.Click
        NcTextBox.SelectedText = "N190 G00 Z.100 (O.D.)" & vbNewLine &
            "N200 X5.500" & vbNewLine &
            "N210 G71 U.050 R.025" & vbNewLine &
            "N220 G71 P140 Q160 U.030 W.0 F.015" & vbNewLine &
            "N230 G00 X5.200" & vbNewLine &
            "N240 G01 Z-2.300" & vbNewLine &
            "N250 X5.600" & vbNewLine &
            "N260 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepeptitiveIDWCutterCompToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeptitiveIDWCutterCompToolStripMenuItem.Click
        NcTextBox.SelectedText = "N270 G00 Z.100 (O.D.)" & vbNewLine &
            "N280 X5.500" & vbNewLine &
            "N290 G42 X5.500 Z.100" & vbNewLine &
            "N300 G71 U.050 R.025" & vbNewLine &
            "N310 G71 P140 Q160 U.030 W.0 F.015" & vbNewLine &
            "N320 G01 X5.250 Z.100" & vbNewLine &
            "N330 Z-2.300" & vbNewLine &
            "N340 X5.600" & vbNewLine &
            "N350 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepeptitiveDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeptitiveIDToolStripMenuItem.Click
        NcTextBox.SelectedText = "N360 G00 Z.100 (I.D.)" & vbNewLine &
            "N370 X5.500" & vbNewLine &
            "N380 G71 U.050 R.025" & vbNewLine &
            "N390 G71 P140 Q160 U-.030 W.0 F.015" & vbNewLine &
            "N400 G00 X6.000" & vbNewLine &
            "N410 G01 Z-2.300" & vbNewLine &
            "N420 X5.000" & vbNewLine &
            "N430 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepeptitiveIDWCutterCompToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeptitiveIDWCutterCompToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N440 G00 Z.100 (I.D.)" & vbNewLine &
            "N450 X5.500" & vbNewLine &
            "N460 G41 X5.500 Z.100" & vbNewLine &
            "N470 G71 U.050 R.025" & vbNewLine &
            "N480 G71 P140 Q160 U-.030 W.0 F.015" & vbNewLine &
            "N490 G01 X5.750 Z.100" & vbNewLine &
            "N500 Z-2.300" & vbNewLine &
            "N510 X5.000" & vbNewLine &
            "N520 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepeptitiveFaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepeptitiveFaceToolStripMenuItem.Click
        NcTextBox.SelectedText = "N530 G00 Z.060 (FACE)" & vbNewLine &
            "N540 X5.250" & vbNewLine &
            "N550 G72 W.030 R.025" & vbNewLine &
            "N560 G72 P190 Q200 U.0 W.020 F.015" & vbNewLine &
            "N570 G00 Z.0" & vbNewLine &
            "N580 G01 X3.750" & vbNewLine &
            "N590 G70 P190 Q200 F.007"
    End Sub

    Private Sub PeckDrillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeckDrillingToolStripMenuItem.Click
        NcTextBox.SelectedText = "N600 G00 Z1.000" & vbNewLine &
            "N610 X.0" & vbNewLine &
            "N620 Z.050" & vbNewLine &
            "N630 G74 R.050" & vbNewLine &
            "N640 G74 X.0 Z-.500 P0 Q1000 R0 F.006" & vbNewLine &
            "N650 G00 Z.050" & vbNewLine &
            "N660 G00 Z-.450" & vbNewLine &
            "N670 G74 R.050" & vbNewLine &
            "N680 G74 X.0 Z-1.000 P0 Q1000 R0 F.006" & vbNewLine &
            "N690 G00 Z.050" & vbNewLine &
            "N700 G00 Z-.950" & vbNewLine &
            "N710 G74 R.050" & vbNewLine &
            "N720 G74 X.0 Z-1.500 P0 Q1000 R0 F.006" & vbNewLine &
            "N730 G00 Z.050" & vbNewLine &
            "N740 G00 Z-1.450" & vbNewLine &
            "N750 G74 R.050" & vbNewLine &
            "N760 G74 X.0 Z-2.000 P0 Q1000 R0 F.006" & vbNewLine &
            "N770 G00 Z.050" & vbNewLine &
            "N780 G00 Z-1.950" & vbNewLine &
            "N790 G74 R.050" & vbNewLine &
            "N800 G74 X.0 Z-2.500 P0 Q1000 R0 F.006" & vbNewLine &
            "N810 G00 Z.050" & vbNewLine &
            "N820 G00 Z-2.450" & vbNewLine &
            "N830 G74 R.050" & vbNewLine &
            "N840 G74 X.0 Z-3.000 P0 Q1000 R0 F.006" & vbNewLine &
            "N850 G00 Z.050"
    End Sub

    Private Sub PeckFaceGroovingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeckFaceGroovingToolStripMenuItem.Click
        NcTextBox.SelectedText = "N860 G00 Z1.000" & vbNewLine &
            "N870 X2.000" & vbNewLine &
            "N880 Z.100" & vbNewLine &
            "N890 G74 R.010" & vbNewLine &
            "N900 G74 X5.250 Z-.625 P140 Q160 R0 F.006"
    End Sub

    Private Sub PeckGroovingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeckGroovingToolStripMenuItem.Click
        NcTextBox.SelectedText = "N910 G00 Z.100 (PECK GROOVING)" & vbNewLine &
            "N920 X9.500 Z-1.500" & vbNewLine &
            "N930 G75 R.010" & vbNewLine &
            "N940 G75 X7.000 Z-2.000 P1000 Q1200 R0 F.003"
    End Sub

    Private Sub RepetitiveThreadingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepetitiveThreadingToolStripMenuItem.Click
        NcTextBox.SelectedText = "N950 G00 Z.100" & vbNewLine &
            "N960 X1.500" & vbNewLine &
            "N970 G76 P020060 Q0060 R0040" & vbNewLine &
            "N980 G76 X1.352 Z-3.125 R0 P0721 Q0100 F.083333"
    End Sub

    Private Sub StartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem1.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N10 M28" & vbNewLine &
            "N20 M39" & vbNewLine &
            "N30 G00 G20 G40 G80 G99" & vbNewLine &
            "N40 G28 V0" & vbNewLine &
            "N50 G28 U0" & vbNewLine &
            "N60 G28 W0 H0" & vbNewLine &
            "N70 G54 (WORK OFFSET)" & vbNewLine
    End Sub

    Private Sub ToolChangeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolChangeToolStripMenuItem1.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N80 M01" & vbNewLine &
            "N90 T0101 (TOOL NAME)" & vbNewLine &
            "N100 G97 S1000" & vbNewLine &
            "N110 M03" & vbNewLine &
            "N120 M08" & vbNewLine &
             vbNewLine &
            "N140 G01 Z1.000 M09" & vbNewLine &
            "N150 M05" & vbNewLine &
            "N160 M39" & vbNewLine &
            "N170 G28 V0" & vbNewLine &
            "N180 G28 U0" & vbNewLine &
            "N190 G28 W0 H0" & vbNewLine
    End Sub

    Private Sub EndToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem1.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N200 M29" & vbNewLine &
            "N210 M30" & vbNewLine
    End Sub

    Private Sub FaceDrillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaceDrillingToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.SelectedText = "N220 G00 C0.00 Z.100" & vbNewLine &
            "N230 G83 X14.875 H30.0 Z-1.250 R.0 P0 Q2500 F.004 K12 M38" & vbNewLine &
            "N240 G80"
    End Sub

    Private Sub FaceTappingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaceTappingToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.SelectedText = "N250 G00 C0.00 Z.100" & vbNewLine &
            "N260 M79 S100" & vbNewLine &
            "N270 G84 X14.875 H30.0 Z-1.000 R.0 P0 Q2500 F.050 K12 M38" & vbNewLine &
            "N280 G80"
    End Sub

    Private Sub FaceBoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaceBoringToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.SelectedText = "N290 G00 C0.00 X15.350" & vbNewLine &
            "N300 G85 X15.000 H30.0 Z-.500 R.0 P0 F.004 K12 M38" & vbNewLine &
            "N310 G80"
    End Sub

    Private Sub SideDrillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideDrillingToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.SelectedText = "N320 G00 C0.00 X15.350" & vbNewLine &
            "N330 G87 Z-.500 H90.0 X14.300 R.0 P0 Q2000 F.004 K4 M38" & vbNewLine &
            "N340 G80"
    End Sub

    Private Sub SideTappingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideTappingToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.SelectedText = "N350 G00 C0.00 X15.350" & vbNewLine &
            "N360 M79 S100" & vbNewLine &
            "N370 G88 Z-.500 H30.0 X14.300 R.0 P0 Q2500 F.050 K12 M38" & vbNewLine &
            "N380 G80"
    End Sub

    Private Sub SideBoringToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideBoringToolStripMenuItem.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.SelectedText = "N390 G00 C0.00 X15.350" & vbNewLine &
            "N400 G89 Z-.500 H30.0 X14.350 R.0 P0 F.004 K12 M39" & vbNewLine &
            "N410 G80"
    End Sub

    Private Sub StartToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem2.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N10 M53" & vbNewLine &
            "N20 G00 G20 G40 G99" & vbNewLine &
            "N30 G28 U0 W0" & vbNewLine &
            "N40 G54 (WORK OFFSET)" & vbNewLine &
            "N50 M21" & vbNewLine
    End Sub

    Private Sub ToolChangeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolChangeToolStripMenuItem2.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N60 M01" & vbNewLine &
            "N70 T0101 (TOOL NAME)" & vbNewLine &
            "N80 M41" & vbNewLine &
            "N90 G96 S650" & vbNewLine &
            "N100 M04" & vbNewLine &
            "N110 M08" & vbNewLine &
             vbNewLine &
            "N130 G00 Z1.000 M09" & vbNewLine &
            "N140 M05 G40 G28 U0 W0" & vbNewLine
    End Sub

    Private Sub EndToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem2.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N150 M52" & vbNewLine &
            "N160 M30"
    End Sub

    Private Sub RepetitiveODToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepetitiveODToolStripMenuItem.Click
        NcTextBox.SelectedText = "N170 G00 X5.500 Z.100 (O.D.)" & vbNewLine &
            "N180 G71 U.050 R.025" & vbNewLine &
            "N190 G71 P140 Q160 U.030 W.0 F.015" & vbNewLine &
            "N200 G00 X5.250" & vbNewLine &
            "N210 G01 Z-2.300" & vbNewLine &
            "N220 X5.600" & vbNewLine &
            "N230 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepetitiveODWCutterCompToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepetitiveODWCutterCompToolStripMenuItem.Click
        NcTextBox.SelectedText = "N240 G00 X5.500 Z.100 (O.D.)" & vbNewLine &
            "N250 G71 U.050 R.025" & vbNewLine &
            "N260 G71 P140 Q160 U.030 W.0 F.015" & vbNewLine &
            "N270 G01 G42 X5.250 Z.100" & vbNewLine &
            "N280 Z-2.300" & vbNewLine &
            "N290 X5.600" & vbNewLine &
            "N300 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepetitiveIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepetitiveIDToolStripMenuItem.Click
        NcTextBox.SelectedText = "N310 G00 X5.500 Z.100 (I.D.)" & vbNewLine &
            "N320 G71 U.050 R.025" & vbNewLine &
            "N330 G71 P140 Q160 U-.030 W.0 F.015" & vbNewLine &
            "N340 G00 X6.000" & vbNewLine &
            "N350 G01 Z-2.300" & vbNewLine &
            "N360 X5.000" & vbNewLine &
            "N370 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepetitiveIDWCutterCompToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepetitiveIDWCutterCompToolStripMenuItem.Click
        NcTextBox.SelectedText = "N380 G00 X5.500 Z.100 (I.D.)" & vbNewLine &
            "N390 G71 U.050 R.025" & vbNewLine &
            "N400 G71 P140 Q160 U.030 W.0 F.015" & vbNewLine &
            "N410 G01 G42 X5.250 Z.100" & vbNewLine &
            "N420 Z-2.300" & vbNewLine &
            "N430 X5.600" & vbNewLine &
            "N440 G70 P140 Q160 F.007"
    End Sub

    Private Sub RepetitiveFaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepetitiveFaceToolStripMenuItem.Click
        NcTextBox.SelectedText = "N450 G00 X5.250 Z.060 (FACE)" & vbNewLine &
            "N460 G72 W.030 R.025" & vbNewLine &
            "N470 G72 P190 Q200 U.0 W.020 F.015" & vbNewLine &
            "N480 G00 Z0.0" & vbNewLine &
            "N490 G01 X3.750" & vbNewLine &
            "N500 G70 P190 Q200 F.007"
    End Sub

    Private Sub StartToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem3.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N10 M53" & vbNewLine &
            "N20 M90" & vbNewLine &
            "N30 G00 G20 G40 G99" & vbNewLine &
            "N40 M35" & vbNewLine &
            "N50 G28 U0 W0 H0" & vbNewLine &
            "N60 G54 (WORK OFFSET)" & vbNewLine &
            "N70 M21" & vbNewLine
    End Sub

    Private Sub ToolChangeToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolChangeToolStripMenuItem3.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N80 M01" & vbNewLine &
            "N90 T0101 (TOOL NAME)" & vbNewLine &
            "N100 M41" & vbNewLine &
            "N110 G97 S1200" & vbNewLine &
            "N120 M33" & vbNewLine &
            "N130 M08" & vbNewLine &
             vbNewLine &
            "N150 G80" & vbNewLine &
            "N160 G00 Z1.000 M09" & vbNewLine &
            "N170 M35" & vbNewLine &
            "N180 M90" & vbNewLine &
            "N190 G40 G28 U0 W0 H0" & vbNewLine
    End Sub

    Private Sub EndToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem3.Click
        Dim CurrentText As String = NcTextBox.Text
        NcTextBox.Text = CurrentText + "N200 M05" & vbNewLine &
            "N210 M52" & vbNewLine &
            "N220 M30" & vbNewLine
    End Sub

    Private Sub FaceDrillingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaceDrillingToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N230 G00 C-15.0 Z.100" & vbNewLine &
            "N240 G83 X14.875 H30.0 Z-1.250 R-.020 Q2500 F.004 K12 M89"
    End Sub

    Private Sub FaceTappingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaceTappingToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N250 G00 C-15.0 Z.100" & vbNewLine &
            "N260 G84 X14.875 H30.0 Z-1.000 R.050 F.050 K12 M89"
    End Sub

    Private Sub FaceBoringToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaceBoringToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N270 G00 C-15.0 Z.100" & vbNewLine &
            "N280 G85 X15.000 H30.0 Z-.500 R.020 F.004 K12 M89"
    End Sub

    Private Sub SideDrillingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideDrillingToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N290 G00 C-60.0 X15.350" & vbNewLine &
            "N300 G87 Z-.500 H90.0 X14.300 R-.020 Q2000 F.004 K4 M89"
    End Sub

    Private Sub SideTappingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideTappingToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N310 G00 C-60.0 X15.350" & vbNewLine &
            "N320 G88 Z-.500 H30.0 X14.300 R.050 F.050 K12 M89"
    End Sub

    Private Sub SideBoringToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideBoringToolStripMenuItem1.Click
        NcTextBox.SelectedText = "N330 G00 C-15.0 X15.350" & vbNewLine &
            "N340 G89 Z-.500 H30.0 X14.350 R.050 F.004 K12 M89"
    End Sub
End Class