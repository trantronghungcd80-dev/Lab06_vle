namespace abc;

partial class frmNhapLieu
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblSoDong = new Label();
        lblSoCot = new Label();
        txtSoDong = new TextBox();
        txtSoCot = new TextBox();
        btnKhoiTao = new Button();
        SuspendLayout();
        // 
        // lblSoDong
        // 
        lblSoDong.AutoSize = true;
        lblSoDong.Font = new Font("Segoe UI", 10F);
        lblSoDong.Location = new Point(20, 25);
        lblSoDong.Name = "lblSoDong";
        lblSoDong.Size = new Size(60, 19);
        lblSoDong.TabIndex = 0;
        lblSoDong.Text = "Số dòng";
        // 
        // lblSoCot
        // 
        lblSoCot.AutoSize = true;
        lblSoCot.Font = new Font("Segoe UI", 10F);
        lblSoCot.Location = new Point(20, 62);
        lblSoCot.Name = "lblSoCot";
        lblSoCot.Size = new Size(47, 19);
        lblSoCot.TabIndex = 2;
        lblSoCot.Text = "Số cột";
        // 
        // txtSoDong
        // 
        txtSoDong.Font = new Font("Segoe UI", 10F);
        txtSoDong.Location = new Point(90, 22);
        txtSoDong.Name = "txtSoDong";
        txtSoDong.Size = new Size(120, 25);
        txtSoDong.TabIndex = 1;
        // 
        // txtSoCot
        // 
        txtSoCot.Font = new Font("Segoe UI", 10F);
        txtSoCot.Location = new Point(90, 59);
        txtSoCot.Name = "txtSoCot";
        txtSoCot.Size = new Size(120, 25);
        txtSoCot.TabIndex = 3;
        // 
        // btnKhoiTao
        // 
        btnKhoiTao.Font = new Font("Segoe UI", 10F);
        btnKhoiTao.Location = new Point(230, 22);
        btnKhoiTao.Name = "btnKhoiTao";
        btnKhoiTao.Size = new Size(120, 62);
        btnKhoiTao.TabIndex = 4;
        btnKhoiTao.Text = "Khởi tạo form";
        btnKhoiTao.UseVisualStyleBackColor = true;
        btnKhoiTao.Click += btnKhoiTao_Click;
        // 
        // frmNhapLieu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(375, 110);
        Controls.Add(btnKhoiTao);
        Controls.Add(txtSoCot);
        Controls.Add(txtSoDong);
        Controls.Add(lblSoCot);
        Controls.Add(lblSoDong);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "frmNhapLieu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Nhập liệu";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblSoDong;
    private Label lblSoCot;
    private TextBox txtSoDong;
    private TextBox txtSoCot;
    private Button btnKhoiTao;
}
