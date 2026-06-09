using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200116E RID: 4462
	[Token(Token = "0x200116E")]
	public class PlayerSocialTagsInfoManager : SingletonModule<PlayerSocialTagsInfoManager>
	{
		// Token: 0x0600457B RID: 17787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x1EFF79C", Offset = "0x1EFF79C", VA = "0x7BBC6FF79C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457C")]
		[Address(RVA = "0x1EFFA68", Offset = "0x1EFFA68", VA = "0x7BBC6FFA68", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x1EFFAC8", Offset = "0x1EFFAC8", VA = "0x7BBC6FFAC8")]
		public PlayerSocialTagsInfoData GetDataById(uint id)
		{
			return null;
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457E")]
		[Address(RVA = "0x1EFFC00", Offset = "0x1EFFC00", VA = "0x7BBC6FFC00")]
		public List<PlayerSocialTagsInfoData> GetAllData()
		{
			return null;
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457F")]
		[Address(RVA = "0x1EFFC08", Offset = "0x1EFFC08", VA = "0x7BBC6FFC08")]
		public PlayerSocialTagsInfoManager()
		{
		}

		// Token: 0x0400565A RID: 22106
		[Token(Token = "0x400565A")]
		[FieldOffset(Offset = "0x18")]
		private List<PlayerSocialTagsInfoData> m_ListData;

		// Token: 0x0200116F RID: 4463
		[Token(Token = "0x200116F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAD94", Offset = "0x10EAD94")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004581 RID: 17793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004581")]
			[Address(RVA = "0x1EFFD04", Offset = "0x1EFFD04", VA = "0x7BBC6FFD04")]
			public <>c()
			{
			}

			// Token: 0x06004582 RID: 17794 RVA: 0x00015210 File Offset: 0x00013410
			[Token(Token = "0x6004582")]
			[Address(RVA = "0x1EFFD0C", Offset = "0x1EFFD0C", VA = "0x7BBC6FFD0C")]
			internal int <OnInit>b__1_0(PlayerSocialTagsInfoData a, PlayerSocialTagsInfoData b)
			{
				return 0;
			}

			// Token: 0x0400565B RID: 22107
			[Token(Token = "0x400565B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PlayerSocialTagsInfoManager.<>c <>9;

			// Token: 0x0400565C RID: 22108
			[Token(Token = "0x400565C")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<PlayerSocialTagsInfoData> <>9__1_0;
		}
	}
}
