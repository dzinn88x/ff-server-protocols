using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BFF RID: 7167
	[Token(Token = "0x2001BFF")]
	public class UIHUDReadyVote : UIBaseController
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x00028E60 File Offset: 0x00027060
		[Token(Token = "0x17000A5A")]
		public int VoteBodyID
		{
			[Token(Token = "0x6009BC3")]
			[Address(RVA = "0x16BDD48", Offset = "0x16BDD48", VA = "0x7BBBEBDD48")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x00028E78 File Offset: 0x00027078
		[Token(Token = "0x6009BC4")]
		[Address(RVA = "0x16BDD50", Offset = "0x16BDD50", VA = "0x7BBBEBDD50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009BC5 RID: 39877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC5")]
		[Address(RVA = "0x16BDDA0", Offset = "0x16BDDA0", VA = "0x7BBBEBDDA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009BC6 RID: 39878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC6")]
		[Address(RVA = "0x16BDE84", Offset = "0x16BDE84", VA = "0x7BBBEBDE84")]
		public void SetVoteInfo(bool isBodyVote, int bodyID = -1)
		{
		}

		// Token: 0x06009BC7 RID: 39879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC7")]
		[Address(RVA = "0x16BDE9C", Offset = "0x16BDE9C", VA = "0x7BBBEBDE9C")]
		public void ClearVoteInfo()
		{
		}

		// Token: 0x06009BC8 RID: 39880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC8")]
		[Address(RVA = "0x16BDEAC", Offset = "0x16BDEAC", VA = "0x7BBBEBDEAC")]
		private void ToVote()
		{
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC9")]
		[Address(RVA = "0x16BDF8C", Offset = "0x16BDF8C", VA = "0x7BBBEBDF8C")]
		public void SetEnable(bool value)
		{
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BCA")]
		[Address(RVA = "0x16BE010", Offset = "0x16BE010", VA = "0x7BBBEBE010")]
		public UIHUDReadyVote()
		{
		}

		// Token: 0x0400A1F0 RID: 41456
		[Token(Token = "0x400A1F0")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDReadyVoteView m_View;

		// Token: 0x0400A1F1 RID: 41457
		[Token(Token = "0x400A1F1")]
		[FieldOffset(Offset = "0x60")]
		private bool m_IsCurValid;

		// Token: 0x0400A1F2 RID: 41458
		[Token(Token = "0x400A1F2")]
		[FieldOffset(Offset = "0x61")]
		private bool m_IsBodyVote;

		// Token: 0x0400A1F3 RID: 41459
		[Token(Token = "0x400A1F3")]
		[FieldOffset(Offset = "0x64")]
		private int m_VoteBodyID;
	}
}
