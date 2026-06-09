using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001961 RID: 6497
	[Token(Token = "0x2001961")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6264", Offset = "0x10F6264")]
	internal class UIHudSpecialPopupController : UIBaseController
	{
		// Token: 0x060083FA RID: 33786 RVA: 0x00023D90 File Offset: 0x00021F90
		[Token(Token = "0x60083FA")]
		[Address(RVA = "0x166C950", Offset = "0x166C950", VA = "0x7BBBE6C950")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083FB RID: 33787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083FB")]
		[Address(RVA = "0x166C9A0", Offset = "0x166C9A0", VA = "0x7BBBE6C9A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083FC")]
		[Address(RVA = "0x166CFEC", Offset = "0x166CFEC", VA = "0x7BBBE6CFEC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083FD")]
		[Address(RVA = "0x166CFF4", Offset = "0x166CFF4", VA = "0x7BBBE6CFF4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083FE RID: 33790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083FE")]
		[Address(RVA = "0x166D0BC", Offset = "0x166D0BC", VA = "0x7BBBE6D0BC")]
		public void SetMessage(GameBannerInfo gb, {Z|h[YF zoneType)
		{
		}

		// Token: 0x060083FF RID: 33791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083FF")]
		[Address(RVA = "0x166D8C0", Offset = "0x166D8C0", VA = "0x7BBBE6D8C0")]
		private void AutoHide()
		{
		}

		// Token: 0x06008400 RID: 33792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008400")]
		[Address(RVA = "0x166D01C", Offset = "0x166D01C", VA = "0x7BBBE6D01C")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008401")]
		[Address(RVA = "0x166D968", Offset = "0x166D968", VA = "0x7BBBE6D968", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008402")]
		[Address(RVA = "0x166D990", Offset = "0x166D990", VA = "0x7BBBE6D990")]
		public UIHudSpecialPopupController()
		{
		}

		// Token: 0x0400948C RID: 38028
		[Token(Token = "0x400948C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSpecialPopupView m_View;

		// Token: 0x0400948D RID: 38029
		[Token(Token = "0x400948D")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;

		// Token: 0x0400948E RID: 38030
		[Token(Token = "0x400948E")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHudSpecialPopupController.ZoneColorGroup> m_ZoneColorGroupList;

		// Token: 0x02001962 RID: 6498
		[Token(Token = "0x2001962")]
		public class ZoneColorGroup
		{
			// Token: 0x06008403 RID: 33795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008403")]
			[Address(RVA = "0x166CF04", Offset = "0x166CF04", VA = "0x7BBBE6CF04")]
			public ZoneColorGroup({Z|h[YF zoneType, Color iconColor, Color bgColor, Color bgColor2, Color bgColor3)
			{
			}

			// Token: 0x0400948F RID: 38031
			[Token(Token = "0x400948F")]
			[FieldOffset(Offset = "0x10")]
			public {Z|h[YF zoneType;

			// Token: 0x04009490 RID: 38032
			[Token(Token = "0x4009490")]
			[FieldOffset(Offset = "0x14")]
			public Color iconColor;

			// Token: 0x04009491 RID: 38033
			[Token(Token = "0x4009491")]
			[FieldOffset(Offset = "0x24")]
			public Color bgColor;

			// Token: 0x04009492 RID: 38034
			[Token(Token = "0x4009492")]
			[FieldOffset(Offset = "0x34")]
			public Color bgColor2;

			// Token: 0x04009493 RID: 38035
			[Token(Token = "0x4009493")]
			[FieldOffset(Offset = "0x44")]
			public Color bgColor3;
		}
	}
}
