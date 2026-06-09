using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BD1 RID: 7121
	[Token(Token = "0x2001BD1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAEA4", Offset = "0x10FAEA4")]
	public class UIVeteranSigninItemController : UIBaseController
	{
		// Token: 0x060099F1 RID: 39409 RVA: 0x00028848 File Offset: 0x00026A48
		[Token(Token = "0x60099F1")]
		[Address(RVA = "0x1A0E5BC", Offset = "0x1A0E5BC", VA = "0x7BBC20E5BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x17000A50 RID: 2640
		// (set) Token: 0x060099F2 RID: 39410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A50")]
		public bool IsVeteran
		{
			[Token(Token = "0x60099F2")]
			[Address(RVA = "0x1A0E18C", Offset = "0x1A0E18C", VA = "0x7BBC20E18C")]
			set
			{
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060099F3 RID: 39411 RVA: 0x00028860 File Offset: 0x00026A60
		// (set) Token: 0x060099F4 RID: 39412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A51")]
		public Vector2 ItemSize
		{
			[Token(Token = "0x60099F3")]
			[Address(RVA = "0x1A0E60C", Offset = "0x1A0E60C", VA = "0x7BBC20E60C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60099F4")]
			[Address(RVA = "0x1A0E764", Offset = "0x1A0E764", VA = "0x7BBC20E764")]
			set
			{
			}
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F5")]
		[Address(RVA = "0x1A0E894", Offset = "0x1A0E894", VA = "0x7BBC20E894", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F6")]
		[Address(RVA = "0x1A0E978", Offset = "0x1A0E978", VA = "0x7BBC20E978")]
		private void OnItemClick()
		{
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F7")]
		[Address(RVA = "0x1A0DFB8", Offset = "0x1A0DFB8", VA = "0x7BBC20DFB8")]
		public void SetRewardData(VeteranRewardItem item, int listIndex, bool isLastOne = false)
		{
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F8")]
		[Address(RVA = "0x1A0EA94", Offset = "0x1A0EA94", VA = "0x7BBC20EA94")]
		private void SetDayCountLabel(uint dayID)
		{
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099F9")]
		[Address(RVA = "0x1A0EE38", Offset = "0x1A0EE38", VA = "0x7BBC20EE38")]
		private void AdjustView(AwardItemInfo awardInfo, bool isLastOne = false)
		{
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FA")]
		[Address(RVA = "0x1A0F2A8", Offset = "0x1A0F2A8", VA = "0x7BBC20F2A8")]
		public UIVeteranSigninItemController()
		{
		}

		// Token: 0x0400A100 RID: 41216
		[Token(Token = "0x400A100")]
		[FieldOffset(Offset = "0x58")]
		private UIVeteranSigninItemView m_View;

		// Token: 0x0400A101 RID: 41217
		[Token(Token = "0x400A101")]
		[FieldOffset(Offset = "0x60")]
		private UIWidget m_ItemWidget;

		// Token: 0x0400A102 RID: 41218
		[Token(Token = "0x400A102")]
		private const string QUALITY_FORMAT = "UI_quality_{0}";

		// Token: 0x0400A103 RID: 41219
		[Token(Token = "0x400A103")]
		[FieldOffset(Offset = "0x68")]
		private int m_IndexInList;

		// Token: 0x0400A104 RID: 41220
		[Token(Token = "0x400A104")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsVeteran;
	}
}
