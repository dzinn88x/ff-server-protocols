using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200166F RID: 5743
	[Token(Token = "0x200166F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F016C", Offset = "0x10F016C")]
	public class UIStandardItemMini2Controller : UIBaseController
	{
		// Token: 0x06006806 RID: 26630 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
		[Token(Token = "0x6006806")]
		[Address(RVA = "0x163ED58", Offset = "0x163ED58", VA = "0x7BBBE3ED58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006807")]
		[Address(RVA = "0x163EDA8", Offset = "0x163EDA8", VA = "0x7BBBE3EDA8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006808")]
		[Address(RVA = "0x163EE0C", Offset = "0x163EE0C", VA = "0x7BBBE3EE0C")]
		public void SetStandItemMiniData(StatndardItemMiniData data)
		{
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006809")]
		[Address(RVA = "0x163EE14", Offset = "0x163EE14", VA = "0x7BBBE3EE14")]
		public void RefreshView()
		{
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680A")]
		[Address(RVA = "0x163F22C", Offset = "0x163F22C", VA = "0x7BBBE3F22C")]
		public void SetBtnClickEvent(EventDelegate.Callback callback)
		{
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680B")]
		[Address(RVA = "0x163F13C", Offset = "0x163F13C", VA = "0x7BBBE3F13C")]
		public void SetQualityBG()
		{
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680C")]
		[Address(RVA = "0x163F028", Offset = "0x163F028", VA = "0x7BBBE3F028")]
		public void RefreshBaseItemView(BaseItemInfo info)
		{
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680D")]
		[Address(RVA = "0x163F0DC", Offset = "0x163F0DC", VA = "0x7BBBE3F0DC")]
		public void SetClaimedState(bool show)
		{
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680E")]
		[Address(RVA = "0x163F230", Offset = "0x163F230", VA = "0x7BBBE3F230")]
		public UIStandardItemMini2Controller()
		{
		}

		// Token: 0x04008508 RID: 34056
		[Token(Token = "0x4008508")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardItemMini2View m_View;

		// Token: 0x04008509 RID: 34057
		[Token(Token = "0x4008509")]
		[FieldOffset(Offset = "0x60")]
		public StatndardItemMiniData m_Data;
	}
}
