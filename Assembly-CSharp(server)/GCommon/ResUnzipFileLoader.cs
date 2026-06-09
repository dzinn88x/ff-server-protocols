using System;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FCE RID: 4046
	[Token(Token = "0x2000FCE")]
	public class ResUnzipFileLoader : ResFileLoader
	{
		// Token: 0x06003B3E RID: 15166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x2972FD0", Offset = "0x2972FD0", VA = "0x7BBD172FD0", Slot = "7")]
		protected override void OnStart(float time)
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x2973204", Offset = "0x2973204", VA = "0x7BBD173204", Slot = "10")]
		public override bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00012768 File Offset: 0x00010968
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x2973214", Offset = "0x2973214", VA = "0x7BBD173214", Slot = "6")]
		public override bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x297321C", Offset = "0x297321C", VA = "0x7BBD17321C", Slot = "11")]
		protected override void OnUpdate(float time)
		{
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x29736B8", Offset = "0x29736B8", VA = "0x7BBD1736B8", Slot = "9")]
		protected override void OnNotify()
		{
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x2973810", Offset = "0x2973810", VA = "0x7BBD173810", Slot = "8")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x29738A8", Offset = "0x29738A8", VA = "0x7BBD1738A8", Slot = "5")]
		public override bool IsTimeout(float time)
		{
			return default(bool);
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x296C6CC", Offset = "0x296C6CC", VA = "0x7BBD16C6CC")]
		public void CloseInput()
		{
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x29737D8", Offset = "0x29737D8", VA = "0x7BBD1737D8")]
		private void CloseOutput()
		{
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x2973878", Offset = "0x2973878", VA = "0x7BBD173878")]
		private void ClearHashWorker()
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x296763C", Offset = "0x296763C", VA = "0x7BBD16763C")]
		public ResUnzipFileLoader()
		{
		}

		// Token: 0x04004CB8 RID: 19640
		[Token(Token = "0x4004CB8")]
		[FieldOffset(Offset = "0x48")]
		public string OutputPath;

		// Token: 0x04004CB9 RID: 19641
		[Token(Token = "0x4004CB9")]
		[FieldOffset(Offset = "0x50")]
		public Action<string, ResUnzipFileLoader> OnLoaded;

		// Token: 0x04004CBA RID: 19642
		[Token(Token = "0x4004CBA")]
		[FieldOffset(Offset = "0x58")]
		public int BufferSize;

		// Token: 0x04004CBB RID: 19643
		[Token(Token = "0x4004CBB")]
		[FieldOffset(Offset = "0x60")]
		private GZipInputStream m_GZipStream;

		// Token: 0x04004CBC RID: 19644
		[Token(Token = "0x4004CBC")]
		[FieldOffset(Offset = "0x68")]
		private FileStream m_OutputStream;

		// Token: 0x04004CBD RID: 19645
		[Token(Token = "0x4004CBD")]
		[FieldOffset(Offset = "0x70")]
		private long m_SizeUnzipped;

		// Token: 0x04004CBE RID: 19646
		[Token(Token = "0x4004CBE")]
		[FieldOffset(Offset = "0x78")]
		private byte[] m_Buffer;

		// Token: 0x04004CBF RID: 19647
		[Token(Token = "0x4004CBF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsFinished;

		// Token: 0x04004CC0 RID: 19648
		[Token(Token = "0x4004CC0")]
		[FieldOffset(Offset = "0x88")]
		private SHA1CryptoServiceProvider m_HashWorker;
	}
}
