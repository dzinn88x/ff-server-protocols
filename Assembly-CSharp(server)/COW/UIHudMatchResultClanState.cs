using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015CF RID: 5583
	[Token(Token = "0x20015CF")]
	public class UIHudMatchResultClanState : UIHudMatchResultStateBase
	{
		// Token: 0x060062E9 RID: 25321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E9")]
		[Address(RVA = "0x15CE710", Offset = "0x15CE710", VA = "0x7BBBDCE710")]
		public UIHudMatchResultClanState(UIHudMatchResultStateMachine machine)
		{
		}

		// Token: 0x060062EA RID: 25322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EA")]
		[Address(RVA = "0x15CE71C", Offset = "0x15CE71C", VA = "0x7BBBDCE71C", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060062EB RID: 25323 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		[Token(Token = "0x60062EB")]
		[Address(RVA = "0x15CE7C8", Offset = "0x15CE7C8", VA = "0x7BBBDCE7C8", Slot = "5")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x060062EC RID: 25324 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		[Token(Token = "0x60062EC")]
		[Address(RVA = "0x15CE858", Offset = "0x15CE858", VA = "0x7BBBDCE858", Slot = "6")]
		protected override bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x060062ED RID: 25325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062ED")]
		[Address(RVA = "0x15CE934", Offset = "0x15CE934", VA = "0x7BBBDCE934", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x060062EE RID: 25326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EE")]
		[Address(RVA = "0x15CE96C", Offset = "0x15CE96C", VA = "0x7BBBDCE96C", Slot = "8")]
		protected override void OnExit()
		{
		}

		// Token: 0x040081CE RID: 33230
		[Token(Token = "0x40081CE")]
		[FieldOffset(Offset = "0x20")]
		private FakeSubmitRes m_ClanMatchResult;
	}
}
