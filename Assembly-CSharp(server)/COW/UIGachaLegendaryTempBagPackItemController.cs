using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017F5 RID: 6133
	[Token(Token = "0x20017F5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3254", Offset = "0x10F3254")]
	public class UIGachaLegendaryTempBagPackItemController : UIEasyListItemController
	{
		// Token: 0x06007714 RID: 30484 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		[Token(Token = "0x6007714")]
		[Address(RVA = "0x2057708", Offset = "0x2057708", VA = "0x7BBC857708")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007715")]
		[Address(RVA = "0x2057758", Offset = "0x2057758", VA = "0x7BBC857758", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007716")]
		[Address(RVA = "0x205783C", Offset = "0x205783C", VA = "0x7BBC85783C")]
		public void SetToggleValue(bool v)
		{
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007717")]
		[Address(RVA = "0x2057884", Offset = "0x2057884", VA = "0x7BBC857884")]
		public void OnRefreshToggleValue()
		{
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007718")]
		[Address(RVA = "0x20579A4", Offset = "0x20579A4", VA = "0x7BBC8579A4")]
		public void OnToggleSelected()
		{
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007719")]
		[Address(RVA = "0x2058730", Offset = "0x2058730", VA = "0x7BBC858730", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771A")]
		[Address(RVA = "0x2058978", Offset = "0x2058978", VA = "0x7BBC858978")]
		public UIGachaLegendaryTempBagPackItemController()
		{
		}

		// Token: 0x04008D97 RID: 36247
		[Token(Token = "0x4008D97")]
		[FieldOffset(Offset = "0x70")]
		public bool QuickSelect;

		// Token: 0x04008D98 RID: 36248
		[Token(Token = "0x4008D98")]
		[FieldOffset(Offset = "0x74")]
		public int RealIndex;

		// Token: 0x04008D99 RID: 36249
		[Token(Token = "0x4008D99")]
		[FieldOffset(Offset = "0x78")]
		public GachaShowItem Data;

		// Token: 0x04008D9A RID: 36250
		[Token(Token = "0x4008D9A")]
		[FieldOffset(Offset = "0x80")]
		private UIGachaLegendaryTempBagPackItemView m_View;

		// Token: 0x04008D9B RID: 36251
		[Token(Token = "0x4008D9B")]
		[FieldOffset(Offset = "0x88")]
		private UIGachaShowRewardItemController m_GachaShowRewardItem;
	}
}
