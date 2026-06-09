using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FE8 RID: 4072
	[Token(Token = "0x2000FE8")]
	public class ResUpdaterProgressMonitor
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x00012D38 File Offset: 0x00010F38
		[Token(Token = "0x17000716")]
		public long TotalSizeInByte
		{
			[Token(Token = "0x6003C57")]
			[Address(RVA = "0x2968450", Offset = "0x2968450", VA = "0x7BBD168450")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x17000717")]
		public long TotalLoadedSizeInByte
		{
			[Token(Token = "0x6003C58")]
			[Address(RVA = "0x2968488", Offset = "0x2968488", VA = "0x7BBD168488")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C59")]
		[Address(RVA = "0x297B9B0", Offset = "0x297B9B0", VA = "0x7BBD17B9B0")]
		public void Clear()
		{
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5A")]
		[Address(RVA = "0x297B9BC", Offset = "0x297B9BC", VA = "0x7BBD17B9BC")]
		public void AddLoaderInfo(long fileSize)
		{
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5B")]
		[Address(RVA = "0x297B9CC", Offset = "0x297B9CC", VA = "0x7BBD17B9CC")]
		public void OnLoadInProgress(long loadedSize)
		{
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5C")]
		[Address(RVA = "0x296BA14", Offset = "0x296BA14", VA = "0x7BBD16BA14")]
		public void OnLoadFinished(long loadedSize)
		{
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5D")]
		[Address(RVA = "0x297B9D4", Offset = "0x297B9D4", VA = "0x7BBD17B9D4")]
		public ResUpdaterProgressMonitor()
		{
		}

		// Token: 0x04004D7E RID: 19838
		[Token(Token = "0x4004D7E")]
		[FieldOffset(Offset = "0x10")]
		private long m_TotalSizeInByte;

		// Token: 0x04004D7F RID: 19839
		[Token(Token = "0x4004D7F")]
		[FieldOffset(Offset = "0x18")]
		private long m_TotalLoadedSizeInByte;

		// Token: 0x04004D80 RID: 19840
		[Token(Token = "0x4004D80")]
		[FieldOffset(Offset = "0x20")]
		private long m_TotalLoadingSizeInByte;
	}
}
