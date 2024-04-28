<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        grpCustomerInformation = New GroupBox()
        txtEmail = New TextBox()
        mskContact = New MaskedTextBox()
        txtSurname = New TextBox()
        txtName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        grpProductsInformation = New GroupBox()
        chkGlass = New CheckBox()
        chkCoolerBox = New CheckBox()
        chkOpener = New CheckBox()
        radHeineken = New RadioButton()
        radBlack = New RadioButton()
        btnClear = New Button()
        btnShowPromotion = New Button()
        btnExit = New Button()
        lstOutput = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grpCustomerInformation.SuspendLayout()
        grpProductsInformation.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ScrollBar
        PictureBox1.Image = My.Resources.Resources.store_quality_liquor
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(207, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe Fluent Icons", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(260, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(353, 61)
        Label1.TabIndex = 1
        Label1.Text = "QUALITY LIQUORS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(236, 268)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 2
        ' 
        ' grpCustomerInformation
        ' 
        grpCustomerInformation.Controls.Add(txtEmail)
        grpCustomerInformation.Controls.Add(mskContact)
        grpCustomerInformation.Controls.Add(txtSurname)
        grpCustomerInformation.Controls.Add(txtName)
        grpCustomerInformation.Controls.Add(Label6)
        grpCustomerInformation.Controls.Add(Label5)
        grpCustomerInformation.Controls.Add(Label4)
        grpCustomerInformation.Controls.Add(Label3)
        grpCustomerInformation.Location = New Point(12, 155)
        grpCustomerInformation.Name = "grpCustomerInformation"
        grpCustomerInformation.Size = New Size(601, 180)
        grpCustomerInformation.TabIndex = 3
        grpCustomerInformation.TabStop = False
        grpCustomerInformation.Text = "Customer Information"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(152, 133)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(391, 27)
        txtEmail.TabIndex = 7
        ' 
        ' mskContact
        ' 
        mskContact.Location = New Point(152, 95)
        mskContact.Mask = "(999) 000-0000"
        mskContact.Name = "mskContact"
        mskContact.Size = New Size(391, 27)
        mskContact.TabIndex = 6
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(152, 63)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(391, 27)
        txtSurname.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(152, 28)
        txtName.Name = "txtName"
        txtName.Size = New Size(391, 27)
        txtName.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(69, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 3
        Label6.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 20)
        Label5.TabIndex = 2
        Label5.Text = "Contact:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 1
        Label4.Text = "Surname:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(69, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 0
        Label3.Text = "Name:"
        ' 
        ' grpProductsInformation
        ' 
        grpProductsInformation.Controls.Add(chkGlass)
        grpProductsInformation.Controls.Add(chkCoolerBox)
        grpProductsInformation.Controls.Add(chkOpener)
        grpProductsInformation.Controls.Add(radHeineken)
        grpProductsInformation.Controls.Add(radBlack)
        grpProductsInformation.Location = New Point(12, 341)
        grpProductsInformation.Name = "grpProductsInformation"
        grpProductsInformation.Size = New Size(601, 149)
        grpProductsInformation.TabIndex = 4
        grpProductsInformation.TabStop = False
        grpProductsInformation.Text = "Product Information  "
        ' 
        ' chkGlass
        ' 
        chkGlass.AutoSize = True
        chkGlass.Location = New Point(350, 103)
        chkGlass.Name = "chkGlass"
        chkGlass.Size = New Size(103, 24)
        chkGlass.TabIndex = 5
        chkGlass.Text = "Beer Glass "
        chkGlass.UseVisualStyleBackColor = True
        ' 
        ' chkCoolerBox
        ' 
        chkCoolerBox.AutoSize = True
        chkCoolerBox.Location = New Point(350, 73)
        chkCoolerBox.Name = "chkCoolerBox"
        chkCoolerBox.Size = New Size(104, 24)
        chkCoolerBox.TabIndex = 4
        chkCoolerBox.Text = "Cooler Box"
        chkCoolerBox.UseVisualStyleBackColor = True
        ' 
        ' chkOpener
        ' 
        chkOpener.AutoSize = True
        chkOpener.Location = New Point(350, 43)
        chkOpener.Name = "chkOpener"
        chkOpener.Size = New Size(109, 24)
        chkOpener.TabIndex = 3
        chkOpener.Text = "Can Opener"
        chkOpener.UseVisualStyleBackColor = True
        ' 
        ' radHeineken
        ' 
        radHeineken.AutoSize = True
        radHeineken.Location = New Point(58, 72)
        radHeineken.Name = "radHeineken"
        radHeineken.Size = New Size(171, 24)
        radHeineken.TabIndex = 1
        radHeineken.TabStop = True
        radHeineken.Text = "Heineken 6*24 650ml"
        radHeineken.UseVisualStyleBackColor = True
        ' 
        ' radBlack
        ' 
        radBlack.AutoSize = True
        radBlack.Location = New Point(58, 42)
        radBlack.Name = "radBlack"
        radBlack.Size = New Size(181, 24)
        radBlack.TabIndex = 0
        radBlack.TabStop = True
        radBlack.Text = "Black label 6*24 650ml"
        radBlack.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.PaleTurquoise
        btnClear.Location = New Point(650, 278)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(202, 67)
        btnClear.TabIndex = 5
        btnClear.Text = "&Reset"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnShowPromotion
        ' 
        btnShowPromotion.BackColor = Color.PaleTurquoise
        btnShowPromotion.Location = New Point(650, 155)
        btnShowPromotion.Name = "btnShowPromotion"
        btnShowPromotion.Size = New Size(202, 67)
        btnShowPromotion.TabIndex = 6
        btnShowPromotion.Text = "Show &Promotional Offer"
        btnShowPromotion.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.PowderBlue
        btnExit.Location = New Point(650, 427)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(202, 63)
        btnExit.TabIndex = 7
        btnExit.Text = "&Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lstOutput
        ' 
        lstOutput.BackColor = SystemColors.ScrollBar
        lstOutput.FormattingEnabled = True
        lstOutput.Location = New Point(12, 508)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(840, 164)
        lstOutput.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(980, 718)
        Controls.Add(lstOutput)
        Controls.Add(btnExit)
        Controls.Add(btnShowPromotion)
        Controls.Add(btnClear)
        Controls.Add(grpProductsInformation)
        Controls.Add(grpCustomerInformation)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grpCustomerInformation.ResumeLayout(False)
        grpCustomerInformation.PerformLayout()
        grpProductsInformation.ResumeLayout(False)
        grpProductsInformation.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpCustomerInformation As GroupBox
    Friend WithEvents grpProductsInformation As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnShowPromotion As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mskContact As MaskedTextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents chkGlass As CheckBox
    Friend WithEvents chkCoolerBox As CheckBox
    Friend WithEvents chkOpener As CheckBox
    Friend WithEvents radHeineken As RadioButton
    Friend WithEvents radBlack As RadioButton

End Class
