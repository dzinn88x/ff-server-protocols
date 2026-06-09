using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200116B RID: 4459
	[Token(Token = "0x200116B")]
	public class PlayerSocialTagsDataManager : SingletonModule<PlayerSocialTagsDataManager>
	{
		// Token: 0x06004571 RID: 17777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x1EFEFD0", Offset = "0x1EFEFD0", VA = "0x7BBC6FEFD0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x1EFF1DC", Offset = "0x1EFF1DC", VA = "0x7BBC6FF1DC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x1EFF23C", Offset = "0x1EFF23C", VA = "0x7BBC6FF23C")]
		public string GetSocicalKeyById(uint typeid, uint sortid)
		{
			return null;
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x1EFF454", Offset = "0x1EFF454", VA = "0x7BBC6FF454")]
		public List<PlayerSocialTagsData> GetPlayerSocialTagsByType(uint type)
		{
			return null;
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x1EFF554", Offset = "0x1EFF554", VA = "0x7BBC6FF554")]
		public PlayerSocialTagsDataManager()
		{
		}

		// Token: 0x04005654 RID: 22100
		[Token(Token = "0x4005654")]
		[FieldOffset(Offset = "0x18")]
		private List<PlayerSocialTagsData> m_ListData;

		// Token: 0x0200116C RID: 4460
		[Token(Token = "0x200116C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAD84", Offset = "0x10EAD84")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06004576 RID: 17782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004576")]
			[Address(RVA = "0x1EFF54C", Offset = "0x1EFF54C", VA = "0x7BBC6FF54C")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06004577 RID: 17783 RVA: 0x000151F8 File Offset: 0x000133F8
			[Token(Token = "0x6004577")]
			[Address(RVA = "0x1EFF5EC", Offset = "0x1EFF5EC", VA = "0x7BBC6FF5EC")]
			internal bool <GetPlayerSocialTagsByType>b__0(PlayerSocialTagsData x)
			{
				return default(bool);
			}

			// Token: 0x04005655 RID: 22101
			[Token(Token = "0x4005655")]
			[FieldOffset(Offset = "0x10")]
			public uint type;
		}
	}
}
