using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200170B RID: 5899
	[Token(Token = "0x200170B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1554", Offset = "0x10F1554")]
	public class UICheckIsNewbieOrVeteranController : UIPopupWindowController
	{
		// Token: 0x06006DD8 RID: 28120 RVA: 0x0001EF30 File Offset: 0x0001D130
		[Token(Token = "0x6006DD8")]
		[Address(RVA = "0x1BF1B58", Offset = "0x1BF1B58", VA = "0x7BBC3F1B58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD9")]
		[Address(RVA = "0x1BF1BA8", Offset = "0x1BF1BA8", VA = "0x7BBC3F1BA8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDA")]
		[Address(RVA = "0x1BF1E0C", Offset = "0x1BF1E0C", VA = "0x7BBC3F1E0C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDB")]
		[Address(RVA = "0x1BF1ED8", Offset = "0x1BF1ED8", VA = "0x7BBC3F1ED8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDC")]
		[Address(RVA = "0x1BF1E04", Offset = "0x1BF1E04", VA = "0x7BBC3F1E04")]
		private void OnChooseNewbie()
		{
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDD")]
		[Address(RVA = "0x1BF208C", Offset = "0x1BF208C", VA = "0x7BBC3F208C")]
		private void OnChooseVeteran()
		{
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDE")]
		[Address(RVA = "0x1BF2094", Offset = "0x1BF2094", VA = "0x7BBC3F2094")]
		private void OnChooseMaster()
		{
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DDF")]
		[Address(RVA = "0x1BF1EE0", Offset = "0x1BF1EE0", VA = "0x7BBC3F1EE0")]
		private void OnChooseChange(EAccount.NewbieChoice choice)
		{
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0x1BF209C", Offset = "0x1BF209C", VA = "0x7BBC3F209C")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE1")]
		[Address(RVA = "0x1BF2198", Offset = "0x1BF2198", VA = "0x7BBC3F2198", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE2")]
		[Address(RVA = "0x1BF2214", Offset = "0x1BF2214", VA = "0x7BBC3F2214", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x0001EF48 File Offset: 0x0001D148
		[Token(Token = "0x6006DE3")]
		[Address(RVA = "0x1BF2290", Offset = "0x1BF2290", VA = "0x7BBC3F2290", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE4")]
		[Address(RVA = "0x1BF2298", Offset = "0x1BF2298", VA = "0x7BBC3F2298")]
		public UICheckIsNewbieOrVeteranController()
		{
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DE5")]
		[Address(RVA = "0x1BF22A0", Offset = "0x1BF22A0", VA = "0x7BBC3F22A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114135C", Offset = "0x114135C")]
		private void <OnUIOpen>b__4_0()
		{
		}

		// Token: 0x040088BA RID: 35002
		[Token(Token = "0x40088BA")]
		[FieldOffset(Offset = "0x98")]
		private UICheckIsNewbieOrVeteranView m_View;

		// Token: 0x040088BB RID: 35003
		[Token(Token = "0x40088BB")]
		[FieldOffset(Offset = "0xA0")]
		private EAccount.NewbieChoice m_Choice;
	}
}
