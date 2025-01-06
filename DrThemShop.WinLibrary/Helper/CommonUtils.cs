using DrThemShop.WinLibrary.CustomControl;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace DrThemShop.WinLibrary.Helper
{
    public static class CommonUtils
    {
        /// <summary>
        /// 	Logger
        /// </summary>
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public static byte[] CompressImageToSize(byte[] imageBytes, int targetSizeKB)
		{
			using (var inputStream = new MemoryStream(imageBytes))
			using (var originalImage = Image.FromStream(inputStream))
			{
				long quality = 90L; // Bắt đầu với mức chất lượng 90
				byte[] compressedImage;

				do
				{
					using (var outputStream = new MemoryStream())
					{
						// Thiết lập thông số nén JPEG
						var encoderParameters = new EncoderParameters(1);
						encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

						// Lấy bộ mã hóa ảnh JPEG
						var jpegEncoder = ImageCodecInfo.GetImageEncoders()
														.First(codec => codec.FormatID == ImageFormat.Jpeg.Guid);

						// Nén ảnh
						originalImage.Save(outputStream, jpegEncoder, encoderParameters);

						// Lấy byte[] của ảnh đã nén
						compressedImage = outputStream.ToArray();

						// Giảm mức chất lượng cho lần nén tiếp theo
						quality -= 5L;
					}

				} while (compressedImage.Length > targetSizeKB * 1024 && quality > 10L);

				return compressedImage;
			}
		}

		/// <summary>
		/// Hàm cắt đi dấu nháy trong chuổi
		/// </summary>
		/// <param name="Str">Chuổi ký tự truyền vào</param>
		/// <returns>Chuổi ký tự trả về</returns>
		public static string ConvertString(string strValue)
		{
			if (!string.IsNullOrEmpty(strValue))
			{
				string strConvert = strValue.Replace("'", "''");
				return strConvert;
			}

			return strValue;
		}
	}

	public static class CommonUtils_Win
	{
		/// <summary>
		/// 	Logger
		/// </summary>
		private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public static void Alert(string msg, FrmAlert.enmType type)
		{
			FrmAlert.enmType etype = type;

			switch (type)
			{
				case FrmAlert.enmType.Success:
					_logger.Debug(msg);
					break;
				case FrmAlert.enmType.Warning:
					_logger.Warn(msg);
					break;
				case FrmAlert.enmType.Error:
					_logger.Error(msg);
					break;
				case FrmAlert.enmType.Info:
					_logger.Info(msg);
					break;

			}

			FrmAlert frm = new FrmAlert();
			frm.showAlert(msg, etype);
		}
	}
}
