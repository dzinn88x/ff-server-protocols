using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016A4 RID: 5796
	[Token(Token = "0x20016A4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F080C", Offset = "0x10F080C")]
	public class UIAnnouncementRewardItemController : UIBaseController
	{
		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		[Token(Token = "0x17000916")]
		public Vector2 ItemSize
		{
			[Token(Token = "0x60069A6")]
			[Address(RVA = "0x1B14828", Offset = "0x1B14828", VA = "0x7BBC314828")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		[Token(Token = "0x60069A7")]
		[Address(RVA = "0x1B14980", Offset = "0x1B14980", VA = "0x7BBC314980")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A8")]
		[Address(RVA = "0x1B149D0", Offset = "0x1B149D0", VA = "0x7BBC3149D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A9")]
		[Address(RVA = "0x1B14A34", Offset = "0x1B14A34", VA = "0x7BBC314A34")]
		public void ShowChoosedSprite()
		{
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AA")]
		[Address(RVA = "0x1B14A78", Offset = "0x1B14A78", VA = "0x7BBC314A78")]
		public void SetData(AttendaceItemInfo attendaceInfo)
		{
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0x1B14EF4", Offset = "0x1B14EF4", VA = "0x7BBC314EF4")]
		public UIAnnouncementRewardItemController()
		{
		}

		// Token: 0x04008670 RID: 34416
		[Token(Token = "0x4008670")]
		[FieldOffset(Offset = "0x58")]
		private UIAnnouncementRewardItemView m_View;

		// Token: 0x04008671 RID: 34417
		[Token(Token = "0x4008671")]
		[FieldOffset(Offset = "0x60")]
		private UIWidget m_ItemWiget;

		// Token: 0x04008672 RID: 34418
		[Token(Token = "0x4008672")]
		private const uint SIGNED_COLOR = 2779096575U;

		// Token: 0x04008673 RID: 34419
		[Token(Token = "0x4008673")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<uint, string> ID_TO_LOCKEY_MAP;
	}
}
