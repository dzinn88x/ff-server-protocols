using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001168 RID: 4456
	[Token(Token = "0x2001168")]
	public class PlayerBattleTagsInfoManager : SingletonModule<PlayerBattleTagsInfoManager>
	{
		// Token: 0x06004566 RID: 17766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x1EFE584", Offset = "0x1EFE584", VA = "0x7BBC6FE584", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004567 RID: 17767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x1EFE850", Offset = "0x1EFE850", VA = "0x7BBC6FE850", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004568 RID: 17768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004568")]
		[Address(RVA = "0x1EFE8B0", Offset = "0x1EFE8B0", VA = "0x7BBC6FE8B0")]
		public PlayerBattleTagsInfoData GetDataById(uint id)
		{
			return null;
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004569")]
		[Address(RVA = "0x1EFE9E8", Offset = "0x1EFE9E8", VA = "0x7BBC6FE9E8")]
		public List<PlayerBattleTagsInfoData> GetAllData()
		{
			return null;
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x1EFE9F0", Offset = "0x1EFE9F0", VA = "0x7BBC6FE9F0")]
		public PlayerBattleTagsInfoManager()
		{
		}

		// Token: 0x0400564E RID: 22094
		[Token(Token = "0x400564E")]
		[FieldOffset(Offset = "0x18")]
		private List<PlayerBattleTagsInfoData> m_ListData;

		// Token: 0x02001169 RID: 4457
		[Token(Token = "0x2001169")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAD74", Offset = "0x10EAD74")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600456C RID: 17772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600456C")]
			[Address(RVA = "0x1EFEAEC", Offset = "0x1EFEAEC", VA = "0x7BBC6FEAEC")]
			public <>c()
			{
			}

			// Token: 0x0600456D RID: 17773 RVA: 0x000151E0 File Offset: 0x000133E0
			[Token(Token = "0x600456D")]
			[Address(RVA = "0x1EFEAF4", Offset = "0x1EFEAF4", VA = "0x7BBC6FEAF4")]
			internal int <OnInit>b__1_0(PlayerBattleTagsInfoData a, PlayerBattleTagsInfoData b)
			{
				return 0;
			}

			// Token: 0x0400564F RID: 22095
			[Token(Token = "0x400564F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PlayerBattleTagsInfoManager.<>c <>9;

			// Token: 0x04005650 RID: 22096
			[Token(Token = "0x4005650")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<PlayerBattleTagsInfoData> <>9__1_0;
		}
	}
}
