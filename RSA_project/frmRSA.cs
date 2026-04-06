using System.Security.Cryptography;
using System;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTaoKhoa_Click(object sender, EventArgs e)
		{
			// Tạo khóa RSA 2048-bit
			using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
			{
				// false = Chỉ lấy Khóa công khai
				txtPublicKey.Text = rsa.ToXmlString(false);

				// true = Lấy Khóa bí mật (nó bao gồm cả thông số public bên trong)
				txtPrivateKey.Text = rsa.ToXmlString(true);
			}
		}

		private void btnMaHoa_Click(object sender, EventArgs e)
		{
			try
			{
				using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
				{
					// Nạp khóa công khai từ ô TextBox vào hệ thống
					rsa.FromXmlString(txtPublicKey.Text);

					// Chuyển chữ ở ô "Mã ban đầu" thành mảng byte
					byte[] dataToEncrypt = Encoding.UTF8.GetBytes(txtInput.Text);

					// Mã hóa (dùng false để xài padding PKCS#1 v1.5 tiêu chuẩn)
					byte[] encryptedData = rsa.Encrypt(dataToEncrypt, false);

					// Ép ra chuỗi Base64 và nhét vào ô "Mã lúc sau"
					txtOutput.Text = Convert.ToBase64String(encryptedData);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi mã hóa: " + ex.Message);
			}
		}

		private void btnGiaiMa_Click(object sender, EventArgs e)
		{
			try
			{
				using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
				{
					// Nạp khóa bí mật từ ô TextBox vào hệ thống
					rsa.FromXmlString(txtPrivateKey.Text);

					// Lấy chuỗi loằng ngoằng ở ô "Mã lúc sau" chuyển lại thành mảng byte
					byte[] dataToDecrypt = Convert.FromBase64String(txtOutput.Text);

					// Giải mã
					byte[] decryptedData = rsa.Decrypt(dataToDecrypt, false);

					// Đổi mảng byte về lại chữ tiếng Việt và ném ngược sang ô "Mã ban đầu"
					txtInput.Text = Encoding.UTF8.GetString(decryptedData);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi giải mã (Sai khóa hoặc dữ liệu hỏng): " + ex.Message);
			}
		}
	}
}
