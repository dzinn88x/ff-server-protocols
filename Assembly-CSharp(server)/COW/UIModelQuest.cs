using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FC1 RID: 8129
	[Token(Token = "0x2001FC1")]
	public class UIModelQuest : UIBaseModel
	{
		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x0600B453 RID: 46163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C35")]
		public DailyBonus DailyBonus
		{
			[Token(Token = "0x600B453")]
			[Address(RVA = "0x23939C8", Offset = "0x23939C8", VA = "0x7BBCB939C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x00033258 File Offset: 0x00031458
		[Token(Token = "0x600B454")]
		[Address(RVA = "0x23939D0", Offset = "0x23939D0", VA = "0x7BBCB939D0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B455")]
		[Address(RVA = "0x23939D8", Offset = "0x23939D8", VA = "0x7BBCB939D8")]
		public void RequestDailyBonus()
		{
		}

		// Token: 0x0600B456 RID: 46166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B456")]
		[Address(RVA = "0x2393BC0", Offset = "0x2393BC0", VA = "0x7BBCB93BC0")]
		public UIModelQuest()
		{
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B457")]
		[Address(RVA = "0x2393C48", Offset = "0x2393C48", VA = "0x7BBCB93C48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146DCC", Offset = "0x1146DCC")]
		private void <RequestDailyBonus>b__5_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B6DA RID: 46810
		[Token(Token = "0x400B6DA")]
		public const uint PropID_DailyBonus = 2U;

		// Token: 0x0400B6DB RID: 46811
		[Token(Token = "0x400B6DB")]
		[FieldOffset(Offset = "0x18")]
		private DailyBonus m_DailyBonus;
	}
}
