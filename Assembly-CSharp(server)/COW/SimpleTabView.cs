using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025AC RID: 9644
	[Token(Token = "0x20025AC")]
	public class SimpleTabView : MonoBehaviour
	{
		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600C671 RID: 50801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCC")]
		public UIGrid SubContentGrid
		{
			[Token(Token = "0x600C671")]
			[Address(RVA = "0x1B38DAC", Offset = "0x1B38DAC", VA = "0x7BBC338DAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C672")]
		[Address(RVA = "0x1B38DB4", Offset = "0x1B38DB4", VA = "0x7BBC338DB4")]
		public void SetData(string title, Action<bool> onChange)
		{
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C673")]
		[Address(RVA = "0x1B3900C", Offset = "0x1B3900C", VA = "0x7BBC33900C")]
		public void ClearData()
		{
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C674")]
		[Address(RVA = "0x1B39088", Offset = "0x1B39088", VA = "0x7BBC339088")]
		public void SetToggleStatus(bool status)
		{
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C675")]
		[Address(RVA = "0x1B39164", Offset = "0x1B39164", VA = "0x7BBC339164")]
		public SimpleTabView()
		{
		}

		// Token: 0x0400F900 RID: 63744
		[Token(Token = "0x400F900")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UILabel m_EnableTitleLabel;

		// Token: 0x0400F901 RID: 63745
		[Token(Token = "0x400F901")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UILabel m_DisableTitleLabel;

		// Token: 0x0400F902 RID: 63746
		[Token(Token = "0x400F902")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIToggle m_Toggle;

		// Token: 0x0400F903 RID: 63747
		[Token(Token = "0x400F903")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIGrid m_SubContentGrid;

		// Token: 0x0400F904 RID: 63748
		[Token(Token = "0x400F904")]
		[FieldOffset(Offset = "0x38")]
		private EventDelegate.Callback m_OnChange;

		// Token: 0x020025AD RID: 9645
		[Token(Token = "0x20025AD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE34", Offset = "0x10FDE34")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600C676 RID: 50806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C676")]
			[Address(RVA = "0x1B39004", Offset = "0x1B39004", VA = "0x7BBC339004")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0600C677 RID: 50807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C677")]
			[Address(RVA = "0x1B3916C", Offset = "0x1B3916C", VA = "0x7BBC33916C")]
			internal void <SetData>b__0()
			{
			}

			// Token: 0x0600C678 RID: 50808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C678")]
			[Address(RVA = "0x1B391FC", Offset = "0x1B391FC", VA = "0x7BBC3391FC")]
			internal void <SetData>b__1()
			{
			}

			// Token: 0x0400F905 RID: 63749
			[Token(Token = "0x400F905")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onChange;

			// Token: 0x0400F906 RID: 63750
			[Token(Token = "0x400F906")]
			[FieldOffset(Offset = "0x18")]
			public SimpleTabView <>4__this;
		}
	}
}
