using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CDC RID: 7388
	[Token(Token = "0x2001CDC")]
	public class FullScreenPreviewDataManager : SingletonModule<FullScreenPreviewDataManager>
	{
		// Token: 0x0600A12F RID: 41263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A12F")]
		[Address(RVA = "0x1868144", Offset = "0x1868144", VA = "0x7BBC068144", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A130")]
		[Address(RVA = "0x18681F8", Offset = "0x18681F8", VA = "0x7BBC0681F8", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A131")]
		[Address(RVA = "0x18681FC", Offset = "0x18681FC", VA = "0x7BBC0681FC")]
		public FullScreenPreviewData GetFullScreenPreviewDataByID(uint itemID)
		{
			return null;
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A132")]
		[Address(RVA = "0x18682D4", Offset = "0x18682D4", VA = "0x7BBC0682D4")]
		public FullScreenPreviewDataManager()
		{
		}

		// Token: 0x0400A7CF RID: 42959
		[Token(Token = "0x400A7CF")]
		[FieldOffset(Offset = "0x18")]
		private List<FullScreenPreviewData> m_DataList;

		// Token: 0x02001CDD RID: 7389
		[Token(Token = "0x2001CDD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBA34", Offset = "0x10FBA34")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600A133 RID: 41267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A133")]
			[Address(RVA = "0x18682CC", Offset = "0x18682CC", VA = "0x7BBC0682CC")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0600A134 RID: 41268 RVA: 0x0002A4B0 File Offset: 0x000286B0
			[Token(Token = "0x600A134")]
			[Address(RVA = "0x186836C", Offset = "0x186836C", VA = "0x7BBC06836C")]
			internal bool <GetFullScreenPreviewDataByID>b__0(FullScreenPreviewData d)
			{
				return default(bool);
			}

			// Token: 0x0400A7D0 RID: 42960
			[Token(Token = "0x400A7D0")]
			[FieldOffset(Offset = "0x10")]
			public uint itemID;
		}
	}
}
