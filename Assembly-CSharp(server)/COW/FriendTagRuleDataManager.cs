using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010FE RID: 4350
	[Token(Token = "0x20010FE")]
	public class FriendTagRuleDataManager : SingletonModule<FriendTagRuleDataManager>
	{
		// Token: 0x060043F8 RID: 17400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F8")]
		[Address(RVA = "0x1B9C47C", Offset = "0x1B9C47C", VA = "0x7BBC39C47C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F9")]
		[Address(RVA = "0x1B9C530", Offset = "0x1B9C530", VA = "0x7BBC39C530", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043FA")]
		[Address(RVA = "0x1B9C538", Offset = "0x1B9C538", VA = "0x7BBC39C538")]
		public FriendTagRuleData GetTagData(RecommendedFriendTag tag)
		{
			return null;
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FB")]
		[Address(RVA = "0x1B9C610", Offset = "0x1B9C610", VA = "0x7BBC39C610")]
		public FriendTagRuleDataManager()
		{
		}

		// Token: 0x040053FE RID: 21502
		[Token(Token = "0x40053FE")]
		[FieldOffset(Offset = "0x18")]
		public List<FriendTagRuleData> m_FriendTagRoleDataList;

		// Token: 0x020010FF RID: 4351
		[Token(Token = "0x20010FF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC44", Offset = "0x10EAC44")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060043FC RID: 17404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043FC")]
			[Address(RVA = "0x1B9C608", Offset = "0x1B9C608", VA = "0x7BBC39C608")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x060043FD RID: 17405 RVA: 0x00014DD8 File Offset: 0x00012FD8
			[Token(Token = "0x60043FD")]
			[Address(RVA = "0x1B9C680", Offset = "0x1B9C680", VA = "0x7BBC39C680")]
			internal bool <GetTagData>b__0(FriendTagRuleData x)
			{
				return default(bool);
			}

			// Token: 0x040053FF RID: 21503
			[Token(Token = "0x40053FF")]
			[FieldOffset(Offset = "0x10")]
			public RecommendedFriendTag tag;
		}
	}
}
