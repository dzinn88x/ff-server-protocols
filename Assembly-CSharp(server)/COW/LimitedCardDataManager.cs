using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CE4 RID: 7396
	[Token(Token = "0x2001CE4")]
	public class LimitedCardDataManager : SingletonModule<LimitedCardDataManager>
	{
		// Token: 0x0600A157 RID: 41303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A157")]
		[Address(RVA = "0x1403E64", Offset = "0x1403E64", VA = "0x7BBBC03E64", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A158")]
		[Address(RVA = "0x1403F18", Offset = "0x1403F18", VA = "0x7BBBC03F18", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A159")]
		[Address(RVA = "0x1403F80", Offset = "0x1403F80", VA = "0x7BBBC03F80", Slot = "8")]
		protected override void OnUnloadMemeory()
		{
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A15A")]
		[Address(RVA = "0x1403FFC", Offset = "0x1403FFC", VA = "0x7BBBC03FFC", Slot = "9")]
		protected override void OnReloadMemory()
		{
		}

		// Token: 0x0600A15B RID: 41307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A15B")]
		[Address(RVA = "0x13F4704", Offset = "0x13F4704", VA = "0x7BBBBF4704")]
		public LimitedCardData FindLimitedCardDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x0002A5D0 File Offset: 0x000287D0
		[Token(Token = "0x600A15C")]
		[Address(RVA = "0x14040FC", Offset = "0x14040FC", VA = "0x7BBBC040FC")]
		public uint GetItemExpireMins(uint id)
		{
			return 0U;
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x0002A5E8 File Offset: 0x000287E8
		[Token(Token = "0x600A15D")]
		[Address(RVA = "0x140412C", Offset = "0x140412C", VA = "0x7BBBC0412C")]
		public CSSharedItemDataManager.StoreQuality GetEffectItemQuality(uint id)
		{
			return CSSharedItemDataManager.StoreQuality.StoreQuality_NONE;
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A15E")]
		[Address(RVA = "0x14041F8", Offset = "0x14041F8", VA = "0x7BBBC041F8")]
		public LimitedCardDataManager()
		{
		}

		// Token: 0x0400A7E6 RID: 42982
		[Token(Token = "0x400A7E6")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, LimitedCardData> m_dictTypeToLimitedCardData;
	}
}
