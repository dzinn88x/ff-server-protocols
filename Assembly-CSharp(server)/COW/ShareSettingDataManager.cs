using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D15 RID: 7445
	[Token(Token = "0x2001D15")]
	public class ShareSettingDataManager : SingletonModule<ShareSettingDataManager>
	{
		// Token: 0x0600A212 RID: 41490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A212")]
		[Address(RVA = "0x1B376AC", Offset = "0x1B376AC", VA = "0x7BBC3376AC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A213")]
		[Address(RVA = "0x1B3770C", Offset = "0x1B3770C", VA = "0x7BBC33770C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A214")]
		[Address(RVA = "0x1B378E4", Offset = "0x1B378E4", VA = "0x7BBC3378E4")]
		public ShareSettingData GetShareSetting(uint shareID)
		{
			return null;
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A215")]
		[Address(RVA = "0x1B37A1C", Offset = "0x1B37A1C", VA = "0x7BBC337A1C")]
		public ShareSettingDataManager()
		{
		}

		// Token: 0x0400A885 RID: 43141
		[Token(Token = "0x400A885")]
		[FieldOffset(Offset = "0x18")]
		private List<ShareSettingData> m_Data;
	}
}
