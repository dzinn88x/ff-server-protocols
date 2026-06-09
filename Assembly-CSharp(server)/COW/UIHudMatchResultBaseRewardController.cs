using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015F0 RID: 5616
	[Token(Token = "0x20015F0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF60C", Offset = "0x10EF60C")]
	public class UIHudMatchResultBaseRewardController : UIBaseController
	{
		// Token: 0x060063ED RID: 25581 RVA: 0x0001CB90 File Offset: 0x0001AD90
		[Token(Token = "0x60063ED")]
		[Address(RVA = "0x15CC084", Offset = "0x15CC084", VA = "0x7BBBDCC084")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0x15C9A80", Offset = "0x15C9A80", VA = "0x7BBBDC9A80")]
		public void ShowRewardData(MatchIncome income)
		{
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063EF")]
		[Address(RVA = "0x15CC0D4", Offset = "0x15CC0D4", VA = "0x7BBBDCC0D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0x15CC284", Offset = "0x15CC284", VA = "0x7BBBDCC284")]
		private void OnClickDetailBtn()
		{
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0x15CC3C8", Offset = "0x15CC3C8", VA = "0x7BBBDCC3C8")]
		private void OnClickDetailMaskBtn()
		{
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F2")]
		[Address(RVA = "0x15CC454", Offset = "0x15CC454", VA = "0x7BBBDCC454")]
		public UIHudMatchResultBaseRewardController()
		{
		}

		// Token: 0x040082B7 RID: 33463
		[Token(Token = "0x40082B7")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMatchResultBaseRewardView m_View;

		// Token: 0x040082B8 RID: 33464
		[Token(Token = "0x40082B8")]
		[FieldOffset(Offset = "0x60")]
		private MatchResultDetailInfo m_DetailInfo;
	}
}
