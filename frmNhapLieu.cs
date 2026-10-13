namespace abc;

public partial class frmNhapLieu : Form
{
    public frmNhapLieu()
    {
        InitializeComponent();
    }

    private void btnKhoiTao_Click(object sender, EventArgs e)
    {
        int sodong, socot;
        if (!int.TryParse(txtSoDong.Text, out sodong))
            sodong = 1;
        if (!int.TryParse(txtSoCot.Text, out socot))
            socot = 1;
        frmXuat frmX = new frmXuat(sodong, socot);
        // canh giữa
        frmX.StartPosition = FormStartPosition.CenterScreen;
        frmX.ShowDialog(); // hiện
    }
}
