using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FE3 RID: 8163
	[Token(Token = "0x2001FE3")]
	internal class UIModelReplay : UIBaseModel
	{
		// Token: 0x0600B53E RID: 46398 RVA: 0x000336A8 File Offset: 0x000318A8
		[Token(Token = "0x600B53E")]
		[Address(RVA = "0x22F1E2C", Offset = "0x22F1E2C", VA = "0x7BBCAF1E2C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B53F")]
		[Address(RVA = "0x22F1E34", Offset = "0x22F1E34", VA = "0x7BBCAF1E34")]
		public List<ReplayInfo> GetAllReplaysByTime()
		{
			return null;
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x000336C0 File Offset: 0x000318C0
		[Token(Token = "0x600B540")]
		[Address(RVA = "0x22F1F94", Offset = "0x22F1F94", VA = "0x7BBCAF1F94")]
		public bool Play(ReplayInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B541")]
		[Address(RVA = "0x22F204C", Offset = "0x22F204C", VA = "0x7BBCAF204C")]
		public void Del(ReplayInfo info)
		{
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B542")]
		[Address(RVA = "0x22F2108", Offset = "0x22F2108", VA = "0x7BBCAF2108")]
		public UIModelReplay()
		{
		}

		// Token: 0x0400B785 RID: 46981
		[Token(Token = "0x400B785")]
		[FieldOffset(Offset = "0x18")]
		private List<ReplayInfo> m_ReplayInfoList;

		// Token: 0x0400B786 RID: 46982
		[Token(Token = "0x400B786")]
		public const uint PropID_ReplayDeleted = 2U;

		// Token: 0x02001FE4 RID: 8164
		[Token(Token = "0x2001FE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD694", Offset = "0x10FD694")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B544 RID: 46404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B544")]
			[Address(RVA = "0x22F21FC", Offset = "0x22F21FC", VA = "0x7BBCAF21FC")]
			public <>c()
			{
			}

			// Token: 0x0600B545 RID: 46405 RVA: 0x000336D8 File Offset: 0x000318D8
			[Token(Token = "0x600B545")]
			[Address(RVA = "0x22F2204", Offset = "0x22F2204", VA = "0x7BBCAF2204")]
			internal int <GetAllReplaysByTime>b__3_0(ReplayInfo a, ReplayInfo b)
			{
				return 0;
			}

			// Token: 0x0400B787 RID: 46983
			[Token(Token = "0x400B787")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelReplay.<>c <>9;

			// Token: 0x0400B788 RID: 46984
			[Token(Token = "0x400B788")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ReplayInfo> <>9__3_0;
		}
	}
}
