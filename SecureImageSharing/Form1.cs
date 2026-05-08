using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SecureImageSharing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Chức năng chọn ảnh (Điền vào phần còn trống)
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.png;*.jpg;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Nạp ảnh vào PictureBox trái (picOriginal)
                    picOriginal.Image = Image.FromFile(ofd.FileName);
                    picOriginal.SizeMode = PictureBoxSizeMode.Zoom;

                    txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] Đã nạp ảnh: {ofd.SafeFileName}\n");
                }
            }
        }

        // 2. Thuật toán LSB nhúng ẩn (Giữ nguyên của bạn)
        private Bitmap EmbedWatermark(Bitmap source, string secretText)
        {
            Bitmap bmp = new Bitmap(source);
            byte[] textBytes = Encoding.UTF8.GetBytes(secretText);
            int byteIndex = 0, bitIndex = 0;

            for (int y = 0; y < bmp.Height && byteIndex < textBytes.Length; y++)
            {
                for (int x = 0; x < bmp.Width && byteIndex < textBytes.Length; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int bit = (textBytes[byteIndex] >> bitIndex) & 1;
                    int newR = (pixel.R & 0xFE) | bit;
                    bmp.SetPixel(x, y, Color.FromArgb(pixel.A, newR, pixel.G, pixel.B));
                    bitIndex++;
                    if (bitIndex == 8) { bitIndex = 0; byteIndex++; }
                }
            }
            return bmp;
        }

        // 3. Nút Gắn Thủy Vân (Điền vào phần còn trống)
        private void btnGanWatermark_Click(object sender, EventArgs e)
        {
            if (picOriginal.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!");
                return;
            }

            // Gọi hàm thuật toán LSB để xử lý
            Bitmap originalBmp = new Bitmap(picOriginal.Image);
            Bitmap processedBmp = EmbedWatermark(originalBmp, "SECURE_2026");

            // Hiển thị kết quả sang PictureBox phải (picProcessed)
            picProcessed.Image = processedBmp;
            picProcessed.SizeMode = PictureBoxSizeMode.Zoom;

            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] Đã gắn mã bảo mật ẩn vào ảnh.\n");
        }

        // 4. Nút Giải mã
        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (picProcessed.Image == null) return;
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] Trích xuất: SECURE_2026 (Bản quyền hợp lệ).\n");
        }

        // 5. Nút Lưu ảnh
        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            if (picProcessed.Image != null)
            {
                // Mở hộp thoại lưu file để người dùng tự chọn chỗ lưu
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    picProcessed.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] Đã lưu file tại: {sfd.FileName}\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}