using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015D3 RID: 5587
	[Token(Token = "0x20015D3")]
	public class UIHudMatchResultHeroicMarkState : UIHudMatchResultStateBase
	{
		// Token: 0x060062FE RID: 25342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0x17A5970", Offset = "0x17A5970", VA = "0x7BBBFA5970")]
		public UIHudMatchResultHeroicMarkState(UIHudMatchResultStateMachine machine)
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x0001C848 File Offset: 0x0001AA48
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0x17A5A00", Offset = "0x17A5A00", VA = "0x7BBBFA5A00", Slot = "5")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x0001C860 File Offset: 0x0001AA60
		[Token(Token = "0x6006300")]
		[Address(RVA = "0x17A5BDC", Offset = "0x17A5BDC", VA = "0x7BBBFA5BDC", Slot = "6")]
		protected override bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006301")]
		[Address(RVA = "0x17A5CF8", Offset = "0x17A5CF8", VA = "0x7BBBFA5CF8", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x040081D4 RID: 33236
		[Token(Token = "0x40081D4")]
		[FieldOffset(Offset = "0x20")]
		private EHeroicMarkType m_HeroicType;

		// Token: 0x040081D5 RID: 33237
		[Token(Token = "0x40081D5")]
		[FieldOffset(Offset = "0x24")]
		private uint m_HeroicBefore;

		// Token: 0x040081D6 RID: 33238
		[Token(Token = "0x40081D6")]
		[FieldOffset(Offset = "0x28")]
		private uint m_HeroicAfter;
	}
}
