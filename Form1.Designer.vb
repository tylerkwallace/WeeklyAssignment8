<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.imgBox = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBox
        '
        Me.imgBox.BackgroundImage = Global.WeeklyAssignment8.My.Resources.Resources.smarthome
        Me.imgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBox.Location = New System.Drawing.Point(-3, 0)
        Me.imgBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.imgBox.Name = "imgBox"
        Me.imgBox.Size = New System.Drawing.Size(328, 322)
        Me.imgBox.TabIndex = 0
        Me.imgBox.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(392, 58)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(228, 66)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Smart Home " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(393, 135)
        Me.cboMonths.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(224, 27)
        Me.cboMonths.TabIndex = 2
        '
        'lblSavings
        '
        Me.lblSavings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(170, 372)
        Me.lblSavings.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(63, 19)
        Me.lblSavings.TabIndex = 3
        Me.lblSavings.Text = "Label1"
        Me.lblSavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverage
        '
        Me.lblAverage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(203, 523)
        Me.lblAverage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(63, 19)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.Text = "Label2"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMax
        '
        Me.lblMax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(136, 582)
        Me.lblMax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(63, 19)
        Me.lblMax.TabIndex = 5
        Me.lblMax.Text = "Label3"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDisplay.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.White
        Me.btnDisplay.Location = New System.Drawing.Point(229, 443)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(248, 34)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display Statistics"
        Me.btnDisplay.UseVisualStyleBackColor = False
        Me.btnDisplay.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(685, 646)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.imgBox)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Home Application"
        CType(Me.imgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgBox As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents lblSavings As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents btnDisplay As Button
End Class
