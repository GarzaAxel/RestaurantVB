<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(baseForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnCarrito = New System.Windows.Forms.Button()
        Me.btnPostres = New System.Windows.Forms.Button()
        Me.btnBebidas = New System.Windows.Forms.Button()
        Me.btnComidas = New System.Windows.Forms.Button()
        Me.btnCombos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tnNuevaOrden = New System.Windows.Forms.Button()
        Me.lbOpcion = New System.Windows.Forms.Label()
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.lbTOTAL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnCompletar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelFondo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnAdmin)
        Me.Panel1.Controls.Add(Me.btnCarrito)
        Me.Panel1.Controls.Add(Me.btnPostres)
        Me.Panel1.Controls.Add(Me.btnBebidas)
        Me.Panel1.Controls.Add(Me.btnComidas)
        Me.Panel1.Controls.Add(Me.btnCombos)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 745)
        Me.Panel1.TabIndex = 0
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.Location = New System.Drawing.Point(4, 648)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(340, 94)
        Me.btnAdmin.TabIndex = 8
        Me.btnAdmin.Text = "          Admin"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnCarrito
        '
        Me.btnCarrito.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCarrito.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnCarrito.FlatAppearance.BorderSize = 0
        Me.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarrito.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCarrito.Image = CType(resources.GetObject("btnCarrito.Image"), System.Drawing.Image)
        Me.btnCarrito.Location = New System.Drawing.Point(4, 547)
        Me.btnCarrito.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCarrito.Name = "btnCarrito"
        Me.btnCarrito.Size = New System.Drawing.Size(340, 94)
        Me.btnCarrito.TabIndex = 7
        Me.btnCarrito.Text = "          Carrito"
        Me.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCarrito.UseVisualStyleBackColor = True
        '
        'btnPostres
        '
        Me.btnPostres.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPostres.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnPostres.FlatAppearance.BorderSize = 0
        Me.btnPostres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostres.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPostres.Image = CType(resources.GetObject("btnPostres.Image"), System.Drawing.Image)
        Me.btnPostres.Location = New System.Drawing.Point(4, 446)
        Me.btnPostres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPostres.Name = "btnPostres"
        Me.btnPostres.Size = New System.Drawing.Size(340, 94)
        Me.btnPostres.TabIndex = 6
        Me.btnPostres.Text = "          Postres"
        Me.btnPostres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPostres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPostres.UseVisualStyleBackColor = True
        '
        'btnBebidas
        '
        Me.btnBebidas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBebidas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnBebidas.FlatAppearance.BorderSize = 0
        Me.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBebidas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBebidas.Image = CType(resources.GetObject("btnBebidas.Image"), System.Drawing.Image)
        Me.btnBebidas.Location = New System.Drawing.Point(4, 345)
        Me.btnBebidas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(340, 94)
        Me.btnBebidas.TabIndex = 5
        Me.btnBebidas.Text = "          Bebidas"
        Me.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBebidas.UseVisualStyleBackColor = True
        '
        'btnComidas
        '
        Me.btnComidas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnComidas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnComidas.FlatAppearance.BorderSize = 0
        Me.btnComidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComidas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComidas.Image = CType(resources.GetObject("btnComidas.Image"), System.Drawing.Image)
        Me.btnComidas.Location = New System.Drawing.Point(4, 244)
        Me.btnComidas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnComidas.Name = "btnComidas"
        Me.btnComidas.Size = New System.Drawing.Size(340, 94)
        Me.btnComidas.TabIndex = 4
        Me.btnComidas.Text = "          Comidas"
        Me.btnComidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnComidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnComidas.UseVisualStyleBackColor = True
        '
        'btnCombos
        '
        Me.btnCombos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCombos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnCombos.FlatAppearance.BorderSize = 0
        Me.btnCombos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCombos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCombos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCombos.Image = CType(resources.GetObject("btnCombos.Image"), System.Drawing.Image)
        Me.btnCombos.Location = New System.Drawing.Point(4, 143)
        Me.btnCombos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCombos.Name = "btnCombos"
        Me.btnCombos.Size = New System.Drawing.Size(340, 94)
        Me.btnCombos.TabIndex = 3
        Me.btnCombos.Text = "          Combos"
        Me.btnCombos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCombos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCombos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 125)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(357, 12)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Controls.Add(Me.tnNuevaOrden)
        Me.Panel2.Controls.Add(Me.lbOpcion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(369, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1146, 68)
        Me.Panel2.TabIndex = 1
        '
        'tnNuevaOrden
        '
        Me.tnNuevaOrden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tnNuevaOrden.BackColor = System.Drawing.Color.YellowGreen
        Me.tnNuevaOrden.FlatAppearance.BorderSize = 2
        Me.tnNuevaOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tnNuevaOrden.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tnNuevaOrden.Image = CType(resources.GetObject("tnNuevaOrden.Image"), System.Drawing.Image)
        Me.tnNuevaOrden.Location = New System.Drawing.Point(969, 5)
        Me.tnNuevaOrden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tnNuevaOrden.Name = "tnNuevaOrden"
        Me.tnNuevaOrden.Size = New System.Drawing.Size(168, 55)
        Me.tnNuevaOrden.TabIndex = 3
        Me.tnNuevaOrden.Text = "   Nueva orden"
        Me.tnNuevaOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tnNuevaOrden.UseVisualStyleBackColor = False
        '
        'lbOpcion
        '
        Me.lbOpcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbOpcion.AutoSize = True
        Me.lbOpcion.BackColor = System.Drawing.Color.Orange
        Me.lbOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOpcion.ForeColor = System.Drawing.Color.Black
        Me.lbOpcion.Location = New System.Drawing.Point(516, 18)
        Me.lbOpcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOpcion.Name = "lbOpcion"
        Me.lbOpcion.Size = New System.Drawing.Size(120, 31)
        Me.lbOpcion.TabIndex = 2
        Me.lbOpcion.Text = "Chicken"
        '
        'PanelFondo
        '
        Me.PanelFondo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PanelFondo.Controls.Add(Me.lbTOTAL)
        Me.PanelFondo.Controls.Add(Me.Label4)
        Me.PanelFondo.Controls.Add(Me.btnRemover)
        Me.PanelFondo.Controls.Add(Me.btnCompletar)
        Me.PanelFondo.Controls.Add(Me.btnAgregar)
        Me.PanelFondo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFondo.Location = New System.Drawing.Point(369, 679)
        Me.PanelFondo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(1146, 66)
        Me.PanelFondo.TabIndex = 2
        '
        'lbTOTAL
        '
        Me.lbTOTAL.AutoSize = True
        Me.lbTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTOTAL.Location = New System.Drawing.Point(255, 16)
        Me.lbTOTAL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTOTAL.Name = "lbTOTAL"
        Me.lbTOTAL.Size = New System.Drawing.Size(30, 31)
        Me.lbTOTAL.TabIndex = 7
        Me.lbTOTAL.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total en carrito:"
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.BackColor = System.Drawing.Color.Red
        Me.btnRemover.FlatAppearance.BorderSize = 2
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRemover.Image = CType(resources.GetObject("btnRemover.Image"), System.Drawing.Image)
        Me.btnRemover.Location = New System.Drawing.Point(405, 7)
        Me.btnRemover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(239, 55)
        Me.btnRemover.TabIndex = 2
        Me.btnRemover.Text = "   Remover"
        Me.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'btnCompletar
        '
        Me.btnCompletar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompletar.BackColor = System.Drawing.Color.DarkGray
        Me.btnCompletar.FlatAppearance.BorderSize = 2
        Me.btnCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompletar.Image = CType(resources.GetObject("btnCompletar.Image"), System.Drawing.Image)
        Me.btnCompletar.Location = New System.Drawing.Point(652, 7)
        Me.btnCompletar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompletar.Name = "btnCompletar"
        Me.btnCompletar.Size = New System.Drawing.Size(239, 55)
        Me.btnCompletar.TabIndex = 1
        Me.btnCompletar.Text = "   Completar compra"
        Me.btnCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompletar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGray
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(898, 7)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(239, 55)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "    Agregar al carrito"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(369, 68)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1146, 611)
        Me.PanelPrincipal.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(67, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(213, 128)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'baseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1515, 745)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.PanelFondo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "baseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelFondo.ResumeLayout(False)
        Me.PanelFondo.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnCarrito As Button
    Friend WithEvents btnPostres As Button
    Friend WithEvents btnBebidas As Button
    Friend WithEvents btnComidas As Button
    Friend WithEvents btnCombos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents lbOpcion As Label
    Friend WithEvents lbTOTAL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRemover As Button
    Friend WithEvents btnCompletar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tnNuevaOrden As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
