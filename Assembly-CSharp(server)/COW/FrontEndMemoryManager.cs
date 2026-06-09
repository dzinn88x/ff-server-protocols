using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CDB RID: 7387
	[Token(Token = "0x2001CDB")]
	public class FrontEndMemoryManager : SingletonModule<FrontEndMemoryManager>
	{
		// Token: 0x0600A125 RID: 41253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A125")]
		[Address(RVA = "0x18675DC", Offset = "0x18675DC", VA = "0x7BBC0675DC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A126 RID: 41254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A126")]
		[Address(RVA = "0x18675E8", Offset = "0x18675E8", VA = "0x7BBC0675E8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A127 RID: 41255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A127")]
		[Address(RVA = "0x18676A4", Offset = "0x18676A4", VA = "0x7BBC0676A4")]
		public void OnLoadCDN(int count)
		{
		}

		// Token: 0x0600A128 RID: 41256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A128")]
		[Address(RVA = "0x186780C", Offset = "0x186780C", VA = "0x7BBC06780C")]
		public void OnLoadCGCount(int count)
		{
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A129")]
		[Address(RVA = "0x18678AC", Offset = "0x18678AC", VA = "0x7BBC0678AC")]
		public void OnLoadUMACount(int count)
		{
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A12A")]
		[Address(RVA = "0x186794C", Offset = "0x186794C", VA = "0x7BBC06794C")]
		public void OnLoadPreview3dModel(int count)
		{
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A12B")]
		[Address(RVA = "0x1867744", Offset = "0x1867744", VA = "0x7BBC067744")]
		public void TryClearMemory()
		{
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A12C")]
		[Address(RVA = "0x18679EC", Offset = "0x18679EC", VA = "0x7BBC0679EC")]
		public void ClearUnusedAssets(bool uma = true, bool bTryCleanupFor32bitAndroid = false, bool bForceCleanup = false)
		{
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x0002A498 File Offset: 0x00028698
		[Token(Token = "0x600A12D")]
		[Address(RVA = "0x1867BE4", Offset = "0x1867BE4", VA = "0x7BBC067BE4")]
		public bool SkipGachaFullCG()
		{
			return default(bool);
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A12E")]
		[Address(RVA = "0x1867C88", Offset = "0x1867C88", VA = "0x7BBC067C88")]
		public FrontEndMemoryManager()
		{
		}

		// Token: 0x0400A7CA RID: 42954
		[Token(Token = "0x400A7CA")]
		[FieldOffset(Offset = "0x14")]
		private int loadedCDNCount;

		// Token: 0x0400A7CB RID: 42955
		[Token(Token = "0x400A7CB")]
		[FieldOffset(Offset = "0x18")]
		private int loadedCGCount;

		// Token: 0x0400A7CC RID: 42956
		[Token(Token = "0x400A7CC")]
		[FieldOffset(Offset = "0x1C")]
		private int loadedUMACount;

		// Token: 0x0400A7CD RID: 42957
		[Token(Token = "0x400A7CD")]
		[FieldOffset(Offset = "0x20")]
		private int loadedPreview3dModelCount;

		// Token: 0x0400A7CE RID: 42958
		[Token(Token = "0x400A7CE")]
		private const int lowMemoryThreshold = 150;
	}
}
